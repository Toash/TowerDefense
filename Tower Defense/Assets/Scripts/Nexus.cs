using UnityEngine;
using UnityEngine.Events;


public class Nexus : MonoBehaviour
{
    public UnityEvent enemyReachedNexus;

    public void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Enemy>() != null) 
        {
            enemyReachedNexus?.Invoke();
            Debug.Log("#Enemy# Enemy reached nexus");
        }
    }
}
