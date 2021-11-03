using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public void SetMaxHealth(int _Health)
    {
        slider.maxValue = _Health;
        slider.value = _Health;

    }
    public void SetHealth(int _Health)
    {
        slider.value = _Health;
    }
}
