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
            turnsystem.Turn();
            audioManager.PlaySFX(audioManager.Alien);
        }
        if (charecterselect.current == 2)
        {
            turnsystem.Turn();
            audioManager.PlaySFX(audioManager.Cat);
        }
        if (charecterselect.current == 3)
        {
            turnsystem.Turn();
            audioManager.PlaySFX(audioManager.Cat);
        }
        if (charecterselect.current == 4)
        {
            turnsystem.Turn();
            audioManager.PlaySFX(audioManager.Pirate);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
