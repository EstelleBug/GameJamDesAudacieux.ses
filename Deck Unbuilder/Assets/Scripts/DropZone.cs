using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler
{
    public GameControl gameControl;
    public Transform CardUsed;

    public void OnDrop(PointerEventData eventData)
    {
        Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
        if (d != null)
        {
            float cardDamage = d.damage;

            if (gameObject.name == "CardDropArea")
            {
                // Move the card to the cardUsedEmpty position
                d.parentToReturnTo = CardUsed.transform;

                if (gameControl != null)
                {
                    gameControl.TakeDamage(cardDamage);
                }
            }
            else
            {
                d.parentToReturnTo = this.transform;
            }
        }
    }
}
