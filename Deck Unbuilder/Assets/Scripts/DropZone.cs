using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler
{
    public GameControl gameControl;
    public Transform CardUsed;
    public Transform Hand;
    public Transform Deck;
    public int maxCardsInHand = 3;

    private List<Draggable> cardsInHand = new List<Draggable>();

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
    }

    public void OnDrop(PointerEventData eventData)
    {
        Draggable draggedCard = eventData.pointerDrag.GetComponent<Draggable>();
        if (draggedCard != null)
        {
            float cardDamage = draggedCard.damage;

            if (gameObject.name == "CardDropArea")
            {
                // Move the card to the cardUsedEmpty position
                draggedCard.parentToReturnTo = CardUsed.transform;

                if (gameControl != null)
                {
                    gameControl.TakeDamage(cardDamage);
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
