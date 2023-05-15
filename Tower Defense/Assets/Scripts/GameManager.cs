using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public static GameManager instance;


    private int enemiesAlive = 0;

    public void Start()
    {
        instance = this;
    }

    public void Reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().ToString());
    }

    //Returns true if there are any active enemies, false otherwise
    public bool EnemiesAlive()
    {
        return enemiesAlive <= 0 ? false : true;
    }
    public int GetEnemiesAlive()
    {
        return this.enemiesAlive;
    }

    public void ChangeEnemiesAlive(int amount)
    {
        enemiesAlive += amount;
    }
}
