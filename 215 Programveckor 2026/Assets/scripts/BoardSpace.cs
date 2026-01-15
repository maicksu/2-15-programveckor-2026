using UnityEngine;


public enum SpaceType
{
    Reward,
    Punishment,
    Coins,
    Buff
}

public class BoardSpace : MonoBehaviour
{
    private Audiomanager audioManager;
    public SpaceType type;
    private Randomreward randomreward;
    private Randompunishment randompunishment;
    private Buffs buffs;
    public int coins = 0;
    public bool turnover = false;

    private void Awake()
    {
        randomreward = GetComponent<Randomreward>();
        randompunishment = GetComponent<Randompunishment>();
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<Audiomanager>();
    }
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
            coins += 1;
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
