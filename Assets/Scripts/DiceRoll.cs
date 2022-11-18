using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceRoll : MonoBehaviour
{
    public int diceNumber;

    //How many Elements
    public int[] luckyNumbers = new int [8];
    public GameObject[] MyGameObjectArray;

    public AudioClip diceSFX;
    private AudioSource _audioSource;

    public bool luckyNumberWasDrawn;

    // Start is called before the first frame update
    void Start()
    {
        //LuckyNumbers Elements
        luckyNumbers[0] = 1;
        luckyNumbers[1] = 3;
        luckyNumbers[2] = 6;
        luckyNumbers[3]= 14;
        luckyNumbers[4]= 24;
        luckyNumbers[5]= 30;
        luckyNumbers[6]= 38;
        luckyNumbers[7]= 42;

        _audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            diceNumber = Random.Range(1, 51);

            Debug.Log("dice number: " + diceNumber);

            for(int i = 0; i < luckyNumbers.Length; i++)
            {
            //do this
                Debug.Log("for loop i " + i);

                 if(diceNumber == luckyNumbers[i])
                   {
                    Debug.Log(diceNumber + " You won!");
                    luckyNumberWasDrawn = true;

                    _audioSource.PlayOneShot(diceSFX, 1f);
                   }

                 else if(i == (luckyNumbers.Length-1) && luckyNumberWasDrawn == false)
                 {
                    Debug.Log("You loose.");
                 }
            }

            luckyNumberWasDrawn = false;
            
        }
    }
}
