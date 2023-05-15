using UnityEngine;

public abstract class Tower : MonoBehaviour
{
    [SerializeField]
    protected int cost;

    [SerializeField]
    protected int damage;

    [SerializeField]
    protected float range;

    [SerializeField]
    protected GameObject model;
}
