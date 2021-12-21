using UnityEngine;
using UnityEngine.UI;
public class HealthBar : MonoBehaviour
{
    public Image healthBarImage;
    private SomGenerator som;

    public void UpdateHealthBar()
    {
        healthBarImage.fillAmount = Mathf.Clamp(som.time / 6, 0, 1f);
    }
}