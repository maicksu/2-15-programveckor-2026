using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Transform[] spaces;   // board spaces in order
    public int currentIndex = 0;
    public Dicerandom dice;      // reference to your dice script

    void Update()
    {
        // press M to move after rolling dice
        if (Input.GetKeyDown(KeyCode.M))
        {
            MovePlayer();
        }
    }

    void MovePlayer()
    {
        currentIndex += dice.Diceamount;

        if (currentIndex >= spaces.Length)
            currentIndex = spaces.Length - 1;

        transform.position = spaces[currentIndex].position;

        // trigger board space logic
        BoardSpace space = spaces[currentIndex].GetComponent<BoardSpace>();
        if (space != null)
        {
            space.OnLand(GetComponent<Player>());
        }
    }
}
