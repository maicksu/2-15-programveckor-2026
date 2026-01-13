using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class playeritem : MonoBehaviour
{
    private Items items;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public List<Items> playeritems = new List<Items>();

    int totalWings = 0;
    int totalGasTank = 0;
    int totalScraps = 0;
    int totalControlPanel = 0;
    int totalThruster = 0;

    private void Update()
    {
        for (int i = 0; i <= playeritems.Count; i++)
        {
            if (items.name == "Wings")
            {
                totalWings += playeritems[i].amount;
            }
        }
        for (int i = 0; i <= playeritems.Count; i++)
        {
            if (items.name == "GasTank")
            {
                totalGasTank += playeritems[i].amount;
            }
        }
        for (int i = 0; i <= playeritems.Count; i++)
        {
            if (items.name == "Scraps")
            {
                totalScraps += playeritems[i].amount;
            }
        }
        for (int i = 0; i <= playeritems.Count; i++)
        {
            if (items.name == "ControlPanel")
            {
                totalControlPanel += playeritems[i].amount;
            }
        }
        for (int i = 0; i <= playeritems.Count; i++)
        {
            if (items.name == "Thruster")
            {
                totalThruster += playeritems[i].amount;
            }
        }

        //TMPname.text = 

    }



}
