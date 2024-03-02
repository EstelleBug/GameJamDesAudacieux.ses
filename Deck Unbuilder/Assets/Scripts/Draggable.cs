using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class Draggable : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    private RectTransform rectTransform;
    private Image image;
    private CanvasGroup canvasGroup;
    public Transform parentToReturnTo = null;
    public Transform CardUsed;
    public float damage;

    public void OnBeginDrag(PointerEventData eventData)
    {
        image.color = new Color32(255, 255, 255, 170);

        rectTransform.SetParent(rectTransform.parent.parent);

        canvasGroup.blocksRaycasts = false;
        Debug.Log("OnBeginDrag called");
    }

    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition += eventData.delta;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        image.color = new Color32(255, 255, 255, 255);

        if (parentToReturnTo == CardUsed)
        {
            rectTransform.SetParent(CardUsed);
        }
        else
        {
            rectTransform.SetParent(parentToReturnTo);
        }

        canvasGroup.blocksRaycasts = true;
    }

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        image = GetComponent<Image>();
        canvasGroup = GetComponent<CanvasGroup>();
        parentToReturnTo = rectTransform.parent;

    }
}