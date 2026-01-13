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
    private Randomreward randomreward;
    private Randompunishment randompunishment;
    private Buffs buffs;
    public void OnLand()
    {
        if (type == SpaceType.Reward)
        {
            randomreward.Drawreward();
        }
        else if (type == SpaceType.Punishment)
        {
            randompunishment.drawpunishment();
        }
        else if (type == SpaceType.Challenge)
        {
            Debug.Log("Challenge space (minigame later)");
        }
        else if (type == SpaceType.Buff)
        {
            buffs.Drawbuff();
        }
    }
}
