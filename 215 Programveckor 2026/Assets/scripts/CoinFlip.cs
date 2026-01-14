using TMPro;
using UnityEngine;

public class CoinFlip : MonoBehaviour
{
    public TextMeshProUGUI resultText;

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
        bool coinIsHeads = Random.Range(0, 2) == 1;

        if (coinIsHeads == guessedHeads)
        {
            resultText.text = "YOU WIN!";
        }
        else
        {
            resultText.text = "YOU LOSE!";
        }

        Debug.Log("Guess: " + (guessedHeads ? "Heads" : "Tails"));
        Debug.Log("Result: " + (coinIsHeads ? "Heads" : "Tails"));
    }
}
