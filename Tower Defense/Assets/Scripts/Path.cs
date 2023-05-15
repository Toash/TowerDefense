using System;
using UnityEngine;


//An array of empty gameobjects that enemies go towards, eventually reaching the nexus.
public class Path : MonoBehaviour
{
    [SerializeField]
    private GameObject[] targets;

    public GameObject getNextTarget(GameObject currentTarget)
    {
        try
        {
            for(int i = 0; i < targets.Length; i++)
            {
                if(targets[i].GetInstanceID() == currentTarget.GetInstanceID())
                {
                    // Check if next target is avaliable
                    if(targets[i+1] != null)
                    {
                        return targets[i + 1];
                    }
                    else
                    {
                        throw new System.IndexOutOfRangeException();
                    }
                }
            }
        }
        catch (System.IndexOutOfRangeException e)
        {
            Debug.LogError("Current target is the nexus! cannot get next target.");
        }

        return currentTarget;
    }

    private void OnDrawGizmos()
    {
        //Draw line gizmos connecting each target
        for(int i=0; i < targets.Length; i++)
        {
            if(targets[i+1] != null)
            {
                Gizmos.color = Color.green;
                Gizmos.DrawLine(targets[i].transform.position, targets[i + 1].transform.position);
            }
            
        }
    }

}
