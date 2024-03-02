using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardAnim : MonoBehaviour
{
    private RectTransform rectTransform;
    private Transform parent;
    private bool isFlipped = false;

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        parent = rectTransform.parent;

        if (parent.name == "Deck")
        {
            FlipCard(true);
        }
        else
        {
            FlipCard(false);
        }
    }

    void Update()
    {
        if (parent != rectTransform.parent)
        {
            parent = rectTransform.parent;

            if (parent.name == "Deck")
            {
                FlipCard(true);
            }
            else
            {
                FlipCard(false);
            }
        }
    }

    public void FlipCard(bool isCardNeedsFlip)
    {
        isFlipped = isCardNeedsFlip;

        if (isFlipped)
        {
            rectTransform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }
        else
        {
            rectTransform.rotation = Quaternion.identity;
        }
    }
}
