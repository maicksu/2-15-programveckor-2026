using Assets.scripts;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
    /*public int Wings { get; protected set; }
    public int Thruster { get; protected set; }
    public int ControlPanel { get; protected set; }
    public int Scraps { get; protected set; }
    public int GasTank { get; protected set; }
    */
    public string name { get; protected set; }
    public int amount
    {
        get; protected set;
    }

    public Items(string name, int amount)
    {
        this.name = name;
       this.amount = amount;
    }

}
