using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler
{
    public GameControl gameControl;

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("Card dropped in DropZone");
        Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
        if (d != null)
        {
            d.parentToReturnTo = this.transform;

            float cardDamage = d.damage;

            if (gameControl != null)
            {
                gameControl.TakeDamage(cardDamage);
            }
        }
    }
}
