using UnityEngine;

public class PlayerCoins : MonoBehaviour
{
    public int coins = 20;

    public bool SpendCoins(int amount)
    {
        if (coins < amount)
        {
            Debug.Log("Not enough coins");
            return false;
        }

        coins -= amount;
        return true;
    }

    public void AddCoins(int amount)
    {
        coins += amount;
    }
}
