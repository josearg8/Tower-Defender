using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBardE1 : MonoBehaviour
{
    public Slider Slider;
    public Gradient gradient;
    public Image fillImage; 
    

    public void MaxHealth(int Health)
    {
        Slider.maxValue = Health;
        Slider.value = Health;
        fillImage.color = gradient.Evaluate(1f);
    }
    public void SetHealth (int vida)
    {
        Slider.value = vida;
        fillImage.color = gradient.Evaluate(Slider.normalizedValue);
    }
}
