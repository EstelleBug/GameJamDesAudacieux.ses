using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using FMODUnity;

public class DropZone : MonoBehaviour, IDropHandler
{
    public GameControl gameControl;
    public Transform CardUsed;
    public Transform Hand;
    public Transform Deck;
    public int maxCardsInHand;

    private List<Draggable> cardsInHand = new List<Draggable>();

    private TurnManager turnManager;
    [SerializeField] private StudioEventEmitter DropZoneCard;

    void Start()
    {
        Draggable[] initialCards = GetComponentsInChildren<Draggable>();
        foreach (Draggable card in initialCards)
        {
            if (card.parentToReturnTo == Hand.transform)
            {
                cardsInHand.Add(card);
            }
        }
        turnManager = TurnManager.Instance;
    }


    public void OnDrop(PointerEventData eventData)
    {
        Draggable draggedCard = eventData.pointerDrag.GetComponent<Draggable>();
        if (draggedCard != null)
        {
            float cardDamage = draggedCard.damage;

            if (gameObject.name == "CardDropArea" && !turnManager.IsNPCTurn()) //&& turnManager.IsPlayerAllowToDrop()
            {
                // Move the card to the cardUsedEmpty position
                draggedCard.parentToReturnTo = CardUsed.transform;
                DropZoneCard.Play();

                if (draggedCard.damage < 0)
                {
                    draggedCard.damage = draggedCard.positiveDamage;
                }

                if (turnManager != null && gameControl != null)
                {
                    gameControl.TakeDamage(cardDamage);
                }

                if (draggedCard.gameObject.tag != "playAgain")
                {
                    turnManager.EndTurn();
                    turnManager.PlayAgainCardPlayed();
                }

                Debug.Log("Before Removal: " + cardsInHand.Count);
                cardsInHand.Remove(draggedCard);
                //Debug.Log("After Removal: " + cardsInHand.Count);

            }
            else if (gameObject.name == "Hand")
            {
                if (cardsInHand.Count < maxCardsInHand)
                {
                    cardsInHand.Add(draggedCard);
                    draggedCard.parentToReturnTo = this.transform;
                }
                else
                {
                    draggedCard.parentToReturnTo = Deck.transform;
                    draggedCard.GetComponent<RectTransform>().anchoredPosition = new Vector2(75f, -105f);
                    Debug.Log("Hand is full. Cannot add more cards.");
                }
            }
            else
            {
                draggedCard.parentToReturnTo = this.transform;
                draggedCard.GetComponent<RectTransform>().anchoredPosition = Vector2.zero;
            }

            //draggedCard.rectTransform.SetParent(draggedCard.parentToReturnTo);
        }
    }

    public void MoveCardsToDeck()
    {
        Draggable[] cardsInCardUsed = CardUsed.GetComponentsInChildren<Draggable>();

        foreach (Draggable card in cardsInCardUsed)
        {
            if (card.gameObject.tag == "Start")
            {
                card.parentToReturnTo = Hand.transform;
            }
            else
            {
                card.parentToReturnTo = Deck.transform;
                card.GetComponent<RectTransform>().anchoredPosition = Vector2.zero;
            }
        }
    }
}
