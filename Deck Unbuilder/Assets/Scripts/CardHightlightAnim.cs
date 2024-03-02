using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CardHightlightAnim : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private RectTransform rectTransform;
    private Vector2 originalPosition;
    private Color originalColor;
    private const float hoverHeight = 1.0f;

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        originalPosition = rectTransform.anchoredPosition;
        originalColor = GetComponent<Image>().color;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("OverCard");
        GetComponent<Image>().color = new Color(originalColor.r, originalColor.g, originalColor.b, 0.8f);
        rectTransform.anchoredPosition = originalPosition + new Vector2(0f, hoverHeight);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        GetComponent<Image>().color = originalColor;
        rectTransform.anchoredPosition = originalPosition;
    }
}
