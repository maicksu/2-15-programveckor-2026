using Unity.VisualScripting;
using UnityEngine;

public class StartTurn : MonoBehaviour
{
    private charecterSelect charecterselect;
    private Turnsystem turnsystem;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       if (charecterselect.current == 1)
        {
            turnsystem.Turn();
        }
        if (charecterselect.current == 2)
        {
            turnsystem.Turn();
        }
        if (charecterselect.current == 3)
        {
            turnsystem.Turn();
        }
        if (charecterselect.current == 4)
        {
            turnsystem.Turn();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
