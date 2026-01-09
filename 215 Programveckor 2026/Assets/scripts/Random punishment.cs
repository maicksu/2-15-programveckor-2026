using Assets.scripts;
using System.Collections.Generic;
using UnityEngine;

public class Randompunishment : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private List<Punishments> punishment = new List<Punishments>();

    public Randompunishment()
    {
        punishment.Add(new Punishments("bolts", -2));
        punishment.Add(new Punishments("oil", -1));
        punishment.Add(new Punishments("skrews", -3));
        Shuffle(punishment);
    }
    public void Shuffle(List<Punishments> list)
    {
        for (int i = list.Count - 1; i > 0; i--)
            Swap(list, i, Random.Range(0, i + 1));

        //shufflar decket 
    }
    public void Swap(List<Punishments> list, int i, int j)
    {
        Punishments temp = list[i];
        list[i] = list[j];
        list[j] = temp;
    }
}
