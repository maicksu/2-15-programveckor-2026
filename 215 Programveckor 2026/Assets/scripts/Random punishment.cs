using Assets.scripts;
using JetBrains.Annotations;
using System.Collections.Generic;
using UnityEngine;

public class Randompunishment : MonoBehaviour
{


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private List<Items> punishment = new List<Items>();

    public Randompunishment()
    {
        punishment.Add(new Items("Wings", -2));
        punishment.Add(new Items("GasTank", -1));
        punishment.Add(new Items("Scraps", -3));
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
      
    }

}
