using UnityEngine;
public enum SpaceType
{
    Reward,
    Punishment,
    Challenge,
    Buff
}
public class Player : MonoBehaviour
{
    public int coins = 0;
}

public class BoardSpace : MonoBehaviour
{
    public SpaceType type;
    public int value = 3; // used for coins or movement, etc.

    public void OnLand(Player player)
    {
        if (type == SpaceType.Reward)
        {
            player.coins += value;
            Debug.Log("Reward: +" + value + " coins");
        }
        else if (type == SpaceType.Punishment)
        {
            player.coins -= value;
            Debug.Log("Punishment: -" + value + " coins");
        }
        else if (type == SpaceType.Challenge)
        {
            Debug.Log("Challenge space (minigame later)");
        }
        else if (type == SpaceType.Buff)
        {
            Debug.Log("Buff space (effect later)");
        }
    }
}
