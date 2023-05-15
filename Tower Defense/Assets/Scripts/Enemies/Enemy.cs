using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;
using Sirenix.OdinInspector;


[RequireComponent(typeof(NavMeshAgent))]
public abstract class Enemy : MonoBehaviour
{
    [SerializeField, Tooltip("Returns current enemy health and max health")]
    protected UnityEvent<int,int> enemyDamagedEvent;
    [SerializeField]
    protected UnityEvent enemyDiedEvent;
    [SerializeField]
    protected int maxHealth;
    [SerializeField] 
    protected float speed;


    protected Transform target;
    protected NavMeshAgent agent;
    protected int currentHealth;

    public void Awake()
    {
        currentHealth = maxHealth;

        agent = GetComponent<NavMeshAgent>();
        target = GameObject.FindGameObjectWithTag("Nexus").transform;

    }
    public void Start()
    {
        agent.speed = speed;
    }
    public void Update()
    {
        agent.SetDestination(target.position);
    }

    [Button]
    public void Damage(int amount)
    {
        currentHealth -= amount;
        enemyDamagedEvent?.Invoke(currentHealth,maxHealth);
        if(currentHealth <= 0)
        {
            die();
        }
    }

    private void die()
    {
        enemyDiedEvent?.Invoke();
        Destroy(this.gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<Nexus>() != null)
        {
            Destroy(this.gameObject);
        }
    }

}
