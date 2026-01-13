using Assets.scripts;
using JetBrains.Annotations;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputSystem.LowLevel.InputStateHistory;

public class Randompunishment : MonoBehaviour
{
    private playeritem playeritem;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private List<Items> punishment = new List<Items>();

    public Randompunishment()
    {
        punishment.Add(new Items("Wings", -1));
        punishment.Add(new Items("GasTank", -1));
        punishment.Add(new Items("Scraps", -1));
        punishment.Add(new Items("ControlPanel", -1));
        punishment.Add(new Items("Thruster", -1));

        Shuffle(punishment);
        

    }
    public void Shuffle(List<Items> list)
    {
        for (int i = list.Count - 1; i > 0; i--)
            Swap(list, i, Random.Range(0, i + 1));

        //shufflar decket 
    }
    public void Swap(List<Items> list, int i, int j)
    {
        Items temp = list[i];
        list[i] = list[j];
        list[j] = temp;
    }
   
    public void drawpunishment()
    {
        playeritem.playeritems.Add(punishment[0]);
    }

}
