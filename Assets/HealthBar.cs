using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image fill;

    public void SetMaxHealth(int health)
    {
        // Sağlık çubuğunun maksimum değerini ayarla
        slider.maxValue = health;

        // Sağlık çubuğunun mevcut değerini ayarla
        slider.value = health;

        // Sağlık çubuğunun doluluk durumuna göre rengi belirle
        // Bu, sağlık çubuğunun tamamen dolu olduğu durumda gradientin en üst rengini kullanır
        fill.color = gradient.Evaluate(1f);
    }

    public void SetHealth(int health)
    {
        // Sağlık çubuğunun mevcut sağlık değerini ayarla
        slider.value = health;

        // Sağlık çubuğunun doluluk durumuna göre rengi belirle
        // slider.normalizedValue, sağlık çubuğunun doluluk oranını 0 ile 1 arasında bir değer olarak verir
        // Bu değer, gradientin uygun renk aralığını belirlemek için kullanılır
        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
}
