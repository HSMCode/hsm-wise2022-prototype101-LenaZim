using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceRoll : MonoBehaviour
{
    public int diceNumber;
    public int luckyN1 = 1;
    public int luckyN3 = 3;
    public int luckyN6 = 6;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            diceNumber = Random.Range(1, 7);
            Debug.Log("You rolled number: " + diceNumber);
        }
        if(diceNumber == luckyN1)
        {
            Debug.Log(luckyN1 + " You won!");
        }
        if(diceNumber == luckyN3)
        {
            Debug.Log(luckyN3 + " You can roll again!");
        }
        if(diceNumber == luckyN6)
        {
            Debug.Log(luckyN6 + " You won!");
        }
    }
}
