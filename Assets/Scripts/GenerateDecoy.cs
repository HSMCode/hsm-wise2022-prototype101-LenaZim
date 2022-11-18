using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateDecoy : MonoBehaviour
{

    public GameObject Decoy;
    public GameObject [] Decoys;

    public int spawnAmount = 5;

    public float spawnPositionX = 15f;
    public float spawnPositionZ = 15f;

    public float startDelay = 2f;
    public float spawnInterval = 3f;

    // Start is called before the first frame update
    void Start()
    {
        //SpawningDecoy();

        //InvokeRepeating("SpawningDecoy", time, repeatRate);
        InvokeRepeating("SpawningDecoy", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown("x"))
        {

            SpawningDecoy();    

            //Vector3 spawnPosition = new Vector3(Random.Range(-spawnPositionX,spawnPositionX),0,Random.Range(-spawnPositionZ,spawnPositionZ));
            //Debug.Log(spawnPosition);

            //instantiate decoy 
            //Instantiate(Decoy, spawnPosition, transform.rotation);

            //for (int i = 0; i < spawnAmount; i++)
            //{
            //    Vector3 spawnPosition = new Vector3(Random.Range(-spawnPositionX,spawnPositionX),0,Random.Range(-spawnPositionZ,spawnPositionZ));

            //    Instantiate(Decoy, spawnPosition, transform.rotation);
            //}

            //SpawningDecoyParam(spawnAmount);
        }

    }

    void SpawningDecoy()
    {         
            for (int i = 0; i < spawnAmount; i++)
            {

                int decoysIndex = Random.Range(0,Decoys.Length);

                //generate random spawn position between the defined values
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnPositionX,spawnPositionX),0.5f,Random.Range(-spawnPositionZ,spawnPositionZ));

                // intsantiate decoy
                Instantiate(Decoys, spawnPosition, transform.rotation);
            }

    }


    void SpawningDecoyParam(int amount)
    {         
            for (int i = 0; i < amount; i++)
            {
                //generate random spawn position between the defined values
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnPositionX,spawnPositionX),0.5f,Random.Range(-spawnPositionZ,spawnPositionZ));

                // intsantiate decoy / decoys[], vorher Decoy
                Instantiate(Decoys[decoysIndex], spawnPosition, transform.rotation);
            }
    }


}
