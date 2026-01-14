using UnityEngine;
using UnityEngine.SceneManagement;

public class Audiomanager : MonoBehaviour
{
    [Header("Audio source")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("sounds")]
    public AudioClip Lobbymusic;
    public AudioClip Gamemusic;
    public AudioClip Losing;
    public AudioClip Pirate;
    public AudioClip Cat;
    public AudioClip Alien;
    public AudioClip Astronout;
    public AudioClip Winning;
    public AudioClip Reward;
    public AudioClip Diceshaking;
    public AudioClip DiceRolling;

     Audiomanager audioManager;
    public bool isInCurrentScene;
    public string lastScene;
    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<Audiomanager>();
    }


    // Update is called once per frame
    void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        if (lastScene == currentScene.name) return;

        if (currentScene.name == "Lobby" )
        {
            musicSource.clip = Lobbymusic;
            musicSource.Play();
            lastScene = currentScene.name;
        }
        if (currentScene.name == "Game")
        {
            musicSource.clip = Gamemusic;
            musicSource.Play();
            lastScene = currentScene.name;
        }
    }
    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }
}
