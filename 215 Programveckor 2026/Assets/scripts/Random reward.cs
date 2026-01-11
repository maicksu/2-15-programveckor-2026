using Assets.scripts;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Randomreward : MonoBehaviour
{
    private List<Items> reward = new List<Items>();

    public Randomreward()
    {
        reward.Add(new Items("Wings", 2));
        reward.Add(new Items("GasTank", 1));
        reward.Add(new Items("Scraps", 3));
        Shuffle(reward);
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

}



