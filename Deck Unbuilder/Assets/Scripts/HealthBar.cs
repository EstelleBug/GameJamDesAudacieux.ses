using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthBar : MonoBehaviour
{
    [Header("Components")]
    public RawImage healthbar;
    public TextMeshProUGUI txtHealth;
    public TextMeshProUGUI txtMaxHealth;

    RectTransform healthBarTransform;

    float healthbarWidthMax;
    float healthbarHeightMax;
    
    void Awake()
    {
        healthBarTransform = healthbar.GetComponent<RectTransform>();
    }

    // Start is called before the first frame update
    void Start()
    {
        Vector2 dimensions = healthbar.transform.parent.GetComponent<RectTransform>().sizeDelta;
        healthbarWidthMax = dimensions.x;
        healthbarHeightMax = dimensions.y;

        healthBarTransform.sizeDelta = new Vector2(healthbarWidthMax, healthbarHeightMax);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetHealth(float health, float maxHealth)
    {
        healthBarTransform.sizeDelta = new Vector2(health / maxHealth * healthbarWidthMax, healthbarHeightMax);
    }
}
