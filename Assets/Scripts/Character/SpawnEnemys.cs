using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemys : MonoBehaviour
{
    public GameObject Enemy; 

    //variable for spawn amount
    public int spawnAmount = 5;

    //variables for randomizing spawn position
    public float spawnPositionX = 15f;
    public float spawnPositionZ = 15f;

    // variables for Invoke Repeating
    public float startDelay = 2f;
    public float spawnInterval = 5f;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating ("SpawningEnemyParam", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void SpawningEnemyParam()
    {
        for (int i = 0; i< spawnAmount; i++)
            {
            // generate random spawn position between the defined values
            Vector3 spawnPosition = new Vector3 (Mathf.Floor(Random.Range(-spawnPositionX,spawnPositionX)),1,Mathf.Floor(Random.Range(-spawnPositionZ,spawnPositionZ)));

            // instantiate Enemy
            Instantiate (Enemy, spawnPosition, transform.rotation);
            }
    }
}
