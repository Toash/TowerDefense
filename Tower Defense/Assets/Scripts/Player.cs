using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField]
    private int nexusHealth = 10;

    [SerializeField]
    private int startingPoints = 100;

    private int points;

    public UnityEvent playerDiedEvent;

    private void Awake()
    {
        points = startingPoints;
    }

    public void ReduceHealth(int amount)
    {
        nexusHealth -= amount;
        if(nexusHealth <= 0)
        {
            die();
        }
    }

    private void die()
    {
        playerDiedEvent?.Invoke();
    }
}
