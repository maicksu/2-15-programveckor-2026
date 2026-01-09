using Assets.scripts;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Randomreward : MonoBehaviour
{
    private List<Rewards> reward = new List<Rewards>();

    public Randomreward()
    {
        reward.Add(new Rewards("bolts", 2));
        reward.Add(new Rewards("oil", 1));
        reward.Add(new Rewards("skrews", 3));
        Shuffle(reward);
    }
    public void Shuffle(List<Rewards> list)
    {
        for (int i = list.Count - 1; i > 0; i--)
            Swap(list, i, Random.Range(0, i + 1));

        //shufflar decket 
    }
    public void Swap(List<Rewards> list, int i, int j)
    {
        Rewards temp = list[i];
        list[i] = list[j];
        list[j] = temp;
    }

}



