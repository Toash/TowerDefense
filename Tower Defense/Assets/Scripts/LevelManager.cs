using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LevelManager : MonoBehaviour
{
    [SerializeField]
    private int currentLevel;

    public UnityEvent levelChanged;
    public void nextLevel()
    {
        Debug.Log("#Levels#Level changed");
        currentLevel += 1;
        levelChanged?.Invoke();
    }
    

}
