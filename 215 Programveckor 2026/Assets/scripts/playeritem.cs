using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class playeritem : MonoBehaviour
{
    private Items items;
    private void Awake()
    {
        items = GetComponent<Items>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public List<Items> player1items = new List<Items>();
    public List<Items> player2items = new List<Items>();
    public List<Items> player3items = new List<Items>();
    public List<Items> player4items = new List<Items>();


    int totalWings = 0;
    int totalGasTank = 0;
    int totalScraps = 0;
    int totalControlPanel = 0;
    int totalThruster = 0;

    private void Update()
    {
        for (int i = 0; i <= player1items.Count; i++)
        {
            if (items.name == "Wings")
            {
                totalWings += player1items[i].amount;
            }
        }
        for (int i = 0; i <= player1items.Count; i++)
        {
            if (items.name == "GasTank")
            {
                totalGasTank += player1items[i].amount;
            }
        }
        for (int i = 0; i <= player1items.Count; i++)
        {
            if (items.name == "Scraps")
            {
                totalScraps += player1items[i].amount;
            }
        }
        for (int i = 0; i <= player1items.Count; i++)
        {
            if (items.name == "ControlPanel")
            {
                totalControlPanel += player1items[i].amount;
            }
        }
        for (int i = 0; i <= player1items.Count; i++)
        {
            if (items.name == "Thruster")
            {
                totalThruster += player1items[i].amount;
            }
        }

        //TMPname.text = 

        for (int i = 0; i <= player2items.Count; i++)
        {
            if (items.name == "Wings")
            {
                totalWings += player2items[i].amount;
            }
        }
        for (int i = 0; i <= player2items.Count; i++)
        {
            if (items.name == "GasTank")
            {
                totalGasTank += player2items[i].amount;
            }
        }
        for (int i = 0; i <= player2items.Count; i++)
        {
            if (items.name == "Scraps")
            {
                totalScraps += player2items[i].amount;
            }
        }
        for (int i = 0; i <= player2items.Count; i++)
        {
            if (items.name == "ControlPanel")
            {
                totalControlPanel += player2items[i].amount;
            }
        }
        for (int i = 0; i <= player2items.Count; i++)
        {
            if (items.name == "Thruster")
            {
                totalThruster += player2items[i].amount;
            }
        }

        //TMPname.text = 
        for (int i = 0; i <= player3items.Count; i++)
        {
            if (items.name == "Wings")
            {
                totalWings += player3items[i].amount;
            }
        }
        for (int i = 0; i <= player3items.Count; i++)
        {
            if (items.name == "GasTank")
            {
                totalGasTank += player3items[i].amount;
            }
        }
        for (int i = 0; i <= player3items.Count; i++)
        {
            if (items.name == "Scraps")
            {
                totalScraps += player3items[i].amount;
            }
        }
        for (int i = 0; i <= player3items.Count; i++)
        {
            if (items.name == "ControlPanel")
            {
                totalControlPanel += player3items[i].amount;
            }
        }
        for (int i = 0; i <= player3items.Count; i++)
        {
            if (items.name == "Thruster")
            {
                totalThruster += player3items[i].amount;
            }
        }

        //TMPname.text = 
        for (int i = 0; i <= player4items.Count; i++)
        {
            if (items.name == "Wings")
            {
                totalWings += player4items[i].amount;
            }
        }
        for (int i = 0; i <= player4items.Count; i++)
        {
            if (items.name == "GasTank")
            {
                totalGasTank += player4items[i].amount;
            }
        }
        for (int i = 0; i <= player4items.Count; i++)
        {
            if (items.name == "Scraps")
            {
                totalScraps += player4items[i].amount;
            }
        }
        for (int i = 0; i <= player4items.Count; i++)
        {
            if (items.name == "ControlPanel")
            {
                totalControlPanel += player4items[i].amount;
            }
        }
        for (int i = 0; i <= player4items.Count; i++)
        {
            if (items.name == "Thruster")
            {
                totalThruster += player4items[i].amount;
            }
        }

        //TMPname.text = 
    }



}
