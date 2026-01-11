using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public int players = 4;
    public int current = 1;

    private int[] playerselect;

    private void who()
    {
        playerselect = new int[players];
        for (int i = 0; i < players; i++)
        {
            playerselect[i] = -1;
        }
    }

    public void picked()
    {
        if(current <= players)
        {

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
