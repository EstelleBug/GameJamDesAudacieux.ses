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
    public int maxCardsInHand = 3;

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
                    //turnManager.EndTurn();
                }

                if (draggedCard.gameObject.tag != "playAgain")
                {
                    turnManager.EndTurn();
                }
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
                    cardsInHand.Remove(draggedCard);
                    Debug.Log("Hand is full. Cannot add more cards.");
                }
            }
            else
            {
                draggedCard.parentToReturnTo = this.transform;

                if (cardsInHand.Contains(draggedCard))
                {
                    cardsInHand.Remove(draggedCard);
                }
            }

        }
    }
}
