using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class MovementNew : MonoBehaviour
{
    private Dicerandom dicerandom;
    private Turnsystem turnsystem;
    private Audiomanager audioManager;
    private BoardSpace boardSpace;
    public List<int> Players = new List<int>();
    public string state = "rolling";
    private int playerturn = 0;
    public List<Vector2Int> playerposition = new List<Vector2Int>();
    public List<Vector2Int> TilePosition = new List<Vector2Int>();
    private int currentPosition = 0;
    private int movement;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<Audiomanager>();
        turnsystem = GetComponent<Turnsystem>();
        boardSpace = FindFirstObjectByType<BoardSpace>();
        dicerandom = FindFirstObjectByType<Dicerandom>();
    }
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
         int player1 = PlayerPrefs.GetInt("player1");
         int player2 = PlayerPrefs.GetInt("player2");
         int player3 = PlayerPrefs.GetInt("player3");
         int player4 = PlayerPrefs.GetInt("player4");
        print("p1:" + player1);
        print("p2:" + player2);
        print("p3:" + player3);
        print("p4:" + player4);
         Players.Add(player1);
         Players.Add(player2);
         Players.Add(player3);
         Players.Add(player4);



        playerposition.Add(new Vector2Int(0, 0));
        playerposition.Add(new Vector2Int(0, 0));
        playerposition.Add(new Vector2Int(0, 0));
        playerposition.Add(new Vector2Int(0, 0));

        print("Player turn: " + playerturn);
        print("Player pos x : " + playerposition[playerturn].x);
        print("Player pos y : " + playerposition[playerturn].y);

        TilePosition.Add(new Vector2Int(0, 0)); //[0] också vidare
        TilePosition.Add(new Vector2Int(1, 0)); //[1]
        TilePosition.Add(new Vector2Int(2, 0));
        TilePosition.Add(new Vector2Int(3, 0));
        TilePosition.Add(new Vector2Int(4, 0));
        TilePosition.Add(new Vector2Int(5, 0));
        TilePosition.Add(new Vector2Int(6, 0));
        TilePosition.Add(new Vector2Int(7, 0));
        TilePosition.Add(new Vector2Int(8, 0));
        TilePosition.Add(new Vector2Int(9, 0));
        TilePosition.Add(new Vector2Int(10, 0));
        TilePosition.Add(new Vector2Int(11, 0));
        TilePosition.Add(new Vector2Int(12, 0));
        TilePosition.Add(new Vector2Int(13, 0));
        TilePosition.Add(new Vector2Int(14, 0)); //[14]

        TilePosition.Add(new Vector2Int(14, -1));
        TilePosition.Add(new Vector2Int(14, -2));
        TilePosition.Add(new Vector2Int(14, -3));
        TilePosition.Add(new Vector2Int(14, -4));
        TilePosition.Add(new Vector2Int(14, -5));
        TilePosition.Add(new Vector2Int(14, -6));
        TilePosition.Add(new Vector2Int(14, -7));
        TilePosition.Add(new Vector2Int(14, -8));
        TilePosition.Add(new Vector2Int(14, -9));
        TilePosition.Add(new Vector2Int(14, -10));
        TilePosition.Add(new Vector2Int(14, -11));
        TilePosition.Add(new Vector2Int(14, -12));
        TilePosition.Add(new Vector2Int(14, -13));
        TilePosition.Add(new Vector2Int(14, -14)); //[28]

        TilePosition.Add(new Vector2Int(13, -14));
        TilePosition.Add(new Vector2Int(12, -14));
        TilePosition.Add(new Vector2Int(11, -14));
        TilePosition.Add(new Vector2Int(10, -14));
        TilePosition.Add(new Vector2Int(9, -14));
        TilePosition.Add(new Vector2Int(8, -14));
        TilePosition.Add(new Vector2Int(7, -14));
        TilePosition.Add(new Vector2Int(6, -14));
        TilePosition.Add(new Vector2Int(5, -14));
        TilePosition.Add(new Vector2Int(4, -14));
        TilePosition.Add(new Vector2Int(3, -14));
        TilePosition.Add(new Vector2Int(2, -14));
        TilePosition.Add(new Vector2Int(1, -14));
        TilePosition.Add(new Vector2Int(0, -14)); //[42]

        TilePosition.Add(new Vector2Int(0, -13));
        TilePosition.Add(new Vector2Int(0, -12));
        TilePosition.Add(new Vector2Int(0, -11));
        TilePosition.Add(new Vector2Int(0, -10));
        TilePosition.Add(new Vector2Int(0, -9));
        TilePosition.Add(new Vector2Int(0, -8));
        TilePosition.Add(new Vector2Int(0, -7));
        TilePosition.Add(new Vector2Int(0, -6));
        TilePosition.Add(new Vector2Int(0, -5));
        TilePosition.Add(new Vector2Int(0, -4));
        TilePosition.Add(new Vector2Int(0, -3));
        TilePosition.Add(new Vector2Int(0, -2));
        TilePosition.Add(new Vector2Int(0, -1)); //[55] inte hörn btw det är [0] som är det

         transform.position = (Vector2)TilePosition[0];
    }

    private List<Vector2Int> GetPlayerposition()
    {
        return playerposition;
    }

    // Update is called once per frame
    void Update()
    {
        if (state == "rolling")
        {
            switchplayer();
            Debug.Log(state);
        }

        if (state == "moving") 
        {
                
                Debug.Log("in i movemet");
            print("Player turn: " +playerturn);
            print("Player pos x : " + playerposition[playerturn].x);
            print("Player pos y : " + playerposition[playerturn].y);



            if ((playerposition[playerturn].y == -14 && playerposition[playerturn].x != 14 && Input.GetKeyDown(KeyCode.D)) || (playerposition[playerturn].y == 0 && playerposition[playerturn].x != 14 && Input.GetKeyDown(KeyCode.D)))
                {
                Debug.Log("fucking hell");

                playerposition[playerturn] = new Vector2Int(playerposition[playerturn].x + movement, playerposition[playerturn].y);
                    transform.position = (Vector2)playerposition[playerturn];
                    boardSpace.OnLand();
                }
                if (playerposition[playerturn].x == 0 && playerposition[playerturn].y != -14 && Input.GetKeyDown(KeyCode.S) || playerposition[playerturn].x == 14 && playerposition[playerturn].y != -14 && Input.GetKeyDown(KeyCode.S))
                {
                    playerposition[playerturn] = new Vector2Int(playerposition[playerturn].x, playerposition[playerturn].y - movement);
                    transform.position = (Vector2)playerposition[playerturn];
                    boardSpace.OnLand();
                }
                if (playerposition[playerturn].y == -14 && playerposition[playerturn].x != 0 && Input.GetKeyDown(KeyCode.A) || playerposition[playerturn].y == 0 && playerposition[playerturn].x != 0 && Input.GetKeyDown(KeyCode.A))
                {
                    playerposition[playerturn] = new Vector2Int(playerposition[playerturn].x - movement, playerposition[playerturn].y);
                    transform.position = (Vector2)playerposition[playerturn];
                    boardSpace.OnLand();

                }
                if (playerposition[playerturn].x == 0 && playerposition[playerturn].y != 0 && Input.GetKeyDown(KeyCode.W) || playerposition[playerturn].x == 14 && playerposition[playerturn].y != 0 && Input.GetKeyDown(KeyCode.W))
                {
                    playerposition[playerturn] = new Vector2Int(playerposition[playerturn].x, playerposition[playerturn].y + movement);
                    transform.position = (Vector2)playerposition[playerturn];
                    boardSpace.OnLand();
                }
            
        }
    }
    private void switchplayer()
    {
        
        if (Players[playerturn] == 0)
        {
            
            Debug.Log("player1");
            if (Input.GetKeyUp(KeyCode.Space))
            {
                movement = dicerandom.rolldice();
                state = "moving";
                Debug.Log(state);
                //Moving();
                audioManager.PlaySFX(audioManager.Alien);
            }

        }
        if (Players[playerturn] == 1)
        {
            Debug.Log("player2");
            if (Input.GetKeyUp(KeyCode.Space))
            {
                movement = dicerandom.rolldice();
                state = "moving";
                //Moving();
                audioManager.PlaySFX(audioManager.Astronout);
            }
        }
        if (Players[playerturn] == 2)
        {
            Debug.Log("player3");
            if (Input.GetKeyUp(KeyCode.Space))
            {
                movement = dicerandom.rolldice();
                state = "moving";
               // Moving();
                audioManager.PlaySFX(audioManager.Cat);
            }
        }
        if (Players[playerturn] == 3)
        {

            Debug.Log("player4");
            if (Input.GetKeyUp(KeyCode.Space))
            {
                movement = dicerandom.rolldice();
                state = "moving";
                //Moving();
                audioManager.PlaySFX(audioManager.Pirate);
            }
        }
        if (boardSpace.turnover == true)
        {
            playerturn++;
            if (Players[playerturn] == 5|| Players[playerturn] == 0)
            {
                Players[playerturn] = 1;
            }
        }
    }

   /* private void Moving()
    {
        
        if (Input.GetKeyUp(KeyCode.Space))
        {

            state = "moving";

        }

    }
   */
}

