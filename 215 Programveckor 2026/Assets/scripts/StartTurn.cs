using Unity.VisualScripting;
using UnityEngine;

public class StartTurn : MonoBehaviour
{
    private charecterSelect charecterselect;
    private Turnsystem turnsystem;
    private Audiomanager audioManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<Audiomanager>();
    }
    void Start()
    {
       if (charecterselect.current == 1)
        {
            while (!Input.GetKeyUp(KeyCode.Space))
            {
                turnsystem.Turn();
                audioManager.PlaySFX(audioManager.Alien);
            }

        }
        if (charecterselect.current == 2)
        {
            while (!Input.GetKeyUp(KeyCode.Space))
            {
                turnsystem.Turn();
                audioManager.PlaySFX(audioManager.Astronout);
            }
        }
        if (charecterselect.current == 3)
        {
            while (!Input.GetKeyUp(KeyCode.Space))
            {
                turnsystem.Turn();
                audioManager.PlaySFX(audioManager.Cat);
            }
        }
        if (charecterselect.current == 4)
        {
            while (!Input.GetKeyUp(KeyCode.Space))
            {
                turnsystem.Turn();
                audioManager.PlaySFX(audioManager.Pirate);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
