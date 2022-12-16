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
        //SpawningDecoy();

        //InvokeRepeating("SpawningDecoy", time, repeatRate);
        //InvokeRepeating("SpawningDecoy", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown("x"))
        {   

            //Vector3 spawnPosition = new Vector3(Random.Range(-spawnPositionX,spawnPositionX),0,Random.Range(-spawnPositionZ,spawnPositionZ));
            //Debug.Log(spawnPosition);

            //instantiate decoy 
            //Instantiate(Decoy, spawnPosition, transform.rotation);

            //for (int i = 0; i < spawnAmount; i++)
            //{
            //    Vector3 spawnPosition = new Vector3(Random.Range(-spawnPositionX,spawnPositionX),0,Random.Range(-spawnPositionZ,spawnPositionZ));

            //    Instantiate(Decoy, spawnPosition, transform.rotation);
            //}

            //spawn x amount (5) decoys
            //SpawningDecoys(); 

            //spawn x decoys with "x"
            SpawningDecoyParam(spawnAmount);
        }

    }

    //spawn one randomly selected decoy from decoys array
    /*void SpawningDecoy()
    {         
            for (int i = 0; i < spawnAmount; i++)
            {
                
                //array of decoys, randomly generate the index number of the array to pick warious decoys for each spawn
                int decoysIndex = Random.Range(0,Decoys.Length);

                //generate random spawn position between the defined values
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnPositionX,spawnPositionX),0.5f,Random.Range(-spawnPositionZ,spawnPositionZ));

                //intsantiate decoy
                Instantiate(Decoys[decoysIndex], spawnPosition, Decoys[decoysIndex].transform.rotation);
            }

    }*/

    //spawn decoy with given amount parameter
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