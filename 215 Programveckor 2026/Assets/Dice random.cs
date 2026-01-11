using UnityEngine;
using TMPro;

public class DiceRoller : MonoBehaviour
{
    public TMP_Text diceText;

    void Start()
    {
        diceText.text = "You Rolled: -";
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("click");
            RollDice();
        }
    }

    public void RollDice()
    {
        int rolled = Random.Range(1, 7);
        diceText.text = "You Rolled: " + rolled;
        Debug.Log("Dice rolled: " + rolled);
    }
}
