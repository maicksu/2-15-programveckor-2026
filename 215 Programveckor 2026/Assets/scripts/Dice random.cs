using System;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;


public class Dicerandom : MonoBehaviour
{
    public TextMeshProUGUI DiceRoll;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))  // om det är din tur
        {
            rolldice();
        }

    }
    public int rolldice()
    {
        int Diceamount = Random.Range(1, 7);
        DiceRoll.text = "You got " + Diceamount.ToString();
        Debug.Log(Diceamount);
        return Diceamount;
    }
}
