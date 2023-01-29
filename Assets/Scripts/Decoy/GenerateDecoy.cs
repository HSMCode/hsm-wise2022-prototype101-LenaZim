using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateDecoy : MonoBehaviour
{

    public GameObject Decoy;
    public GameObject[] Decoys;

    //spawn amount
    public int spawnAmount = 5;

    //randomizing spawn position
    public float spawnPositionX = 15f;
    public float spawnPositionZ = 15f;

    //invoke repeating
    public float startDelay = 2f;
    public float spawnInterval = 3f;

    // Start is called before the first frame update
    void Start()
    {

        SpawningDecoyParam(spawnAmount);
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown("x"))
        {   
            SpawningDecoyParam(spawnAmount);
        }

    }

    void SpawningDecoyParam(int amount)
    {         
            for (int i = 0; i < amount; i++)
            {
                int decoysIndex = Random.Range(0,Decoys.Length);

                //generate random spawn position between the defined values
                Vector3 spawnPosition = new Vector3(Mathf.Floor(Random.Range(-spawnPositionX,spawnPositionX)),0.5f,Mathf.Floor(Random.Range(-spawnPositionZ,spawnPositionZ)));

                // intsantiate decoy
                Instantiate(Decoys[decoysIndex], spawnPosition, Decoys[decoysIndex].transform.rotation);
            }
    }


}