using System.Collections.Generic;
using
    UnityEngine;

public class Buffs : MonoBehaviour
{
    private Turnsystem turnsystem;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Randomreward randomreward;

    List<int> Randombuff = new List<int>()
    {
        1,
        2,
        3,
        4,
    };
    private void Awake()
    {
        randomreward = GetComponent<Randomreward>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Rollagain()
    {
        turnsystem.Turn();
    }

    private int Move3()
    {
        return 3;
    }
    private int Move6()
    {
        return 6;
    }

    private void dubblereward()
    {
        randomreward.Drawreward();
        randomreward.Drawreward();
    }

    public void Drawbuff()
    {
        if (Randombuff[0] ==1)
        {
            Rollagain();
            Randombuff.Remove(0);
        }
        if (Randombuff[0] ==2)
        {
            Move3();
            Randombuff.Remove(1);
        }
        if (Randombuff[0] ==3)
        {
            Move6();
            Randombuff.Remove(2);
        }
        if (Randombuff[0] ==4)
        {
            dubblereward();
            Randombuff.Remove(3);
        }
    }
}
