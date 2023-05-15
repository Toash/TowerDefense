using UnityEngine;
using UnityEngine.Events;

public class WaveSpawner : MonoBehaviour
{
    //Spawning - actively spawning enemies
    // Waiting - all enemies spawned, enemies are still alive, waiting for next round

    //TODO - communicate to player a countdown
    public enum SpawnState { SPAWNING, WAITING }


    // Wave with enemies
    [System.Serializable]
    public class Wave
    {
        public EnemyGroup[] enemyGroups;
        public float spawnRate; // time between spawning group of enemies
    }

    // Represents a group of enemies that is spawned in the wave
    // Currently no way to define where the enemy group spawns if multiple spawns.
    [System.Serializable]
    public class EnemyGroup
    {
        public GameObject enemy;
        public int enemyCount;
        public float spawnRate; // time between spawns
    }

    public UnityEvent enemySpawnedEvent;

    // Waves to spawn
    public Wave[] Waves;
    public int currentWave;

    public float timeBetweenWaves;

    // TODO: Multiple spawn points
    public Transform spawnPoint;


    private SpawnState state;

    public void Update()
    {
        switch (state)
        {
            case SpawnState.WAITING:
                //Check if round is over
                if (!GameManager.instance.EnemiesAlive())
                {
                    state = SpawnState.SPAWNING;
                }
                break;
            case SpawnState.SPAWNING:
                //Spawn until no more groups left
                break;
                
        }
    }

    public void SpawnEnemyGroup()
    {

    }
}
