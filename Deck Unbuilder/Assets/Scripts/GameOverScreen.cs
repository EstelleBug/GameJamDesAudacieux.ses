using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    public void Setup()
    {
        RectTransform rectTransform = GetComponent<RectTransform>();

        gameObject.SetActive(true);
        rectTransform.anchorMin = new Vector2(0f, 0f);
        rectTransform.anchorMax = new Vector2(1f, 1f);

        rectTransform.offsetMin = new Vector2(0f, 60f); // Left, Bottom
        rectTransform.offsetMax = new Vector2(0f, -79f); // Right, Top


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HideGameOver()
    {
        //gameObject.SetActive(false);
        transform.position = new Vector3(1000f, 1000f, 0f);
        Debug.Log("Close GameOver");
    }
}
