using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerBehaviour : MonoBehaviour
{
    [SerializeField]
    private TowerStats stats;
    [SerializeField, Tooltip("Where tower casts range field")]
    private Transform origin;

    private Enemy currentTarget;

    private float timer = 0;

    private void Update()
    {
        Collider[] hit = Physics.OverlapSphere(origin.position, stats.range);

        timer += Time.deltaTime;

    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(origin.position, stats.range);
    }

}
