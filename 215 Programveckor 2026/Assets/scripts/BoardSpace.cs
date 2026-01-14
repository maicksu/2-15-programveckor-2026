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
    private Audiomanager audioManager;
    private Player player;
    public SpaceType type;
    private Randomreward randomreward;
    private Randompunishment randompunishment;
    private Buffs buffs;
    public bool turnover = false;
    public void OnLand()
    {
        if (type == SpaceType.Reward)
        {
            randomreward.Drawreward();
            audioManager.PlaySFX(audioManager.Reward);
            turnover = true;
        }
        else if (type == SpaceType.Punishment)
        {
            randompunishment.drawpunishment();
            audioManager.PlaySFX(audioManager.Losing);
            turnover = true;

        }
        else if (type == SpaceType.Coins)
        {
            player.coins += 1;
            audioManager.PlaySFX(audioManager.Coin);
            turnover = true;

        }
        else if (type == SpaceType.Buff)
        {
            buffs.Drawbuff();
            audioManager.PlaySFX(audioManager.Buff);
            turnover = true;

        }
    }
}
