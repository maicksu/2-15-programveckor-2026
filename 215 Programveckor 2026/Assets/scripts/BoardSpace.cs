using UnityEngine;


public enum SpaceType
{
    Reward,
    Punishment,
    Coins,
    Buff
}
public class Player : MonoBehaviour
{
    public int coins = 0;
}

public class BoardSpace : MonoBehaviour
{
    private Player player;
    public SpaceType type;
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
        else if (type == SpaceType.Coins)
        {
            player.coins += 1;
        }
        else if (type == SpaceType.Buff)
        {
            buffs.Drawbuff();
        }
    }
}
