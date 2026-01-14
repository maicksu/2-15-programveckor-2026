using System;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;


public class Dicerandom : MonoBehaviour
{
    private Audiomanager audioManager;
    public TextMeshProUGUI DiceRoll;
    private bool playingsound = false;
    private float timeRemaining = 1.5f;
    // här gör jag så att timmerna startar av 
    public bool timerIsRunning = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<Audiomanager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))  // om det är din tur
        {
            rolldice();
            if (playingsound == false)
            {
                audioManager.PlaySFX(audioManager.Diceshaking);
                timerIsRunning = true;
                playingsound = true;
            }

        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            audioManager.PlaySFX(audioManager.DiceRolling);
        }

        if (timerIsRunning) // det här är vad som uppdaterar timern så att den fungerar 
        {
            if (timeRemaining > 0)// här kollar jag om timern är slut om den inte är de så tar jag min timer minus deltatime så den går ner i sek
            {
                timeRemaining -= Time.deltaTime;
            }
            else // här kollar jag också om timern är slut och om den är det aktiverar jag CountdownFinished
            {
                timeRemaining = 0;
                timerIsRunning = false;
                CountdownFinished();
                timeRemaining = 14;
            }

        }
    }
    public int rolldice()
    {
        int Diceamount = Random.Range(1, 7);
        DiceRoll.text = "You got " + Diceamount.ToString();
        Debug.Log(Diceamount);
        return Diceamount;
    }
    private void CountdownFinished()
    {
        timerIsRunning = false;
        playingsound = false;
    }
}
