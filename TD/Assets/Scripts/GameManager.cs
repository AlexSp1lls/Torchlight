using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject spawnPoint;
    [SerializeField] GameObject[] enemies;
    [SerializeField] int maxEnemies;
    [SerializeField] int totalEnemies;
    [SerializeField] int enemiesToSpawn;

    private int enemiesOnScreen = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
