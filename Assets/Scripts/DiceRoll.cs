using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceRoll : MonoBehaviour
{
    public int diceNumber;
    //public int luckyN1 = 1;
    //public int luckyN3 = 3;
    //public int luckyN6 = 6;

    public int[] luckyNumbers = new int [3];
    //public int[] luckyNumbers = {1,3,6};

    public GameObject[] MyGameObjectArray;

    // Start is called before the first frame update
    void Start()
    {
        luckyNumbers[0] = 1;
        luckyNumbers[1] = 3;
        luckyNumbers[2] = 6;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            diceNumber = Random.Range(1, 7);

            Debug.Log("dice number: " + diceNumber);

            for(int i = 0; i < luckyNumbers.Length; i++)
            {
            //do this
                Debug.Log("for loop i " + i);

                 if(diceNumber == luckyNumbers[i])
                   {
                    Debug.Log(diceNumber + " You won!");
                   }

                 else
                 {
                    Debug.Log("You loose.");
                 }
            }

             //if(diceNumber == luckyNumbers[0] || diceNumber == luckyNumbers[1] || diceNumber == luckyNumbers[2])
            //{
            //Debug.Log(diceNumber + " You won!");
            //}
           //else
           //{
            //Debug.Log("You loose!");
           //}
            
        }
    }
}
