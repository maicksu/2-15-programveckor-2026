using TMPro;
using UnityEngine;

public class CoinFlip : MonoBehaviour
{
    public TextMeshProUGUI resultText;
    public PlayerCoins playerCoins;

    public void ChooseHeads()
    {
        Flip(true);
    }

    public void ChooseTails()
    {
        Flip(false);
    }

    void Flip(bool guessedHeads)
    {
        if (!playerCoins.SpendCoins(10))
        {
            resultText.text = "NOT ENOUGH COINS";
            return;
        }

        bool coinIsHeads = Random.Range(0, 2) == 1;

        if (coinIsHeads == guessedHeads)
        {
            resultText.text = "YOU WIN!";
            playerCoins.AddCoins(10);
        }
        else
        {
            resultText.text = "YOU LOSE!";
            playerCoins.AddCoins(-5);
        }

        Debug.Log("Guess: " + (guessedHeads ? "Heads" : "Tails"));
        Debug.Log("Result: " + (coinIsHeads ? "Heads" : "Tails"));
        Debug.Log("Coins: " + playerCoins.coins);
    }
}
