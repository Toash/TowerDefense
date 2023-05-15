using UnityEngine;
using UnityEngine.UI;

//Generic World view health bar
[RequireComponent(typeof(Canvas))]
public class HealthBar : MonoBehaviour
{
    private Canvas canvas;
    private Slider slider;
    
    private void Awake()
    {
        canvas = GetComponent<Canvas>();
        slider = canvas.GetComponentInChildren<Slider>();
    }

    private void LateUpdate()
    {
        canvas.transform.LookAt(Camera.main.transform);
    }

    public void AdjustValue(int currentHealth, int maxHealth)
    {
        float val = (float)currentHealth / (float)maxHealth;
        slider.value = val;
    }

}
