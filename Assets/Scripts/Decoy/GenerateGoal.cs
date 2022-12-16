using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateGoal : MonoBehaviour
{
    public GameObject Goal;

    public float minspawnPositionX = 5f;
    public float minspawnPositionZ = 5f;
    public float maxspawnPositionX = 15f;
    public float maxspawnPositionZ = 15f;


    // Start is called before the first frame update
    void Start()
    {
        SpawningGoal();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawningGoal()
    {
        Vector3 spawnPosition = new Vector3(Mathf.Floor(Random.Range(minspawnPositionX,maxspawnPositionX)),0,Mathf.Floor(Random.Range(minspawnPositionZ,maxspawnPositionZ)));

        Instantiate(Goal, spawnPosition, Goal.transform.rotation);
    }
}
