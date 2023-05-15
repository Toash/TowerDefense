
using UnityEngine;

[CreateAssetMenu(fileName="TowerStat", menuName ="TowerStat")]
public class TowerStats : ScriptableObject { 

    public int cost;
    public int damage;
    public float range;
    public float attackSpeed;
    public GameObject model;
}
