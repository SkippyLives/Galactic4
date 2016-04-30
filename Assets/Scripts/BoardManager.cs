using UnityEngine;
using System;
using System.Collections.Generic;

public class BoardManager : MonoBehaviour {
    //Setup Row and Collum Count
    public int boardRows = 7;
    public int boardColumns = 7;

    // Setup enum for the states the game can be in
    private int gameStatePlaying = 0;
    private int gameStateMoving = 1;
    private int gameStateOptions = 2;
    private int gameStateP1Win = 3;
    private int gameStateP2Win = 4;
    private int gameStateStaleMate = 5;
    private int gameState;
   

    // setup the potential turns "enum"
    private int gameTurnPlayer1 = 0; // red
    private int gameTurnPlayer2 = 1; // yellow
    private int gameTurn;

    // Setup the board states "enum"
    private int boardStateNoResult = 0;
    private int boardStateStalemate = 1;
    private int boardStateWinner = 2;

    // Setup the Player 2 type
    private int playerTypeAI = 0;
    private int playerTypeHuman = 1;
    private int playerType;

    // Sprites
    public GameObject floorTiles;
    public GameObject[] playerTokens;
    public GameObject cage;

    private Transform boardHolder;
    private Transform background;
    private List<Vector3> gridPositions = new List<Vector3>();


    void InitializeList()
    {
        //playerTokens[0].
        gridPositions.Clear();
        for (int x = 0; x < boardColumns; x++)
        {
            for (int y = 0; y < boardRows; y++)
            {
                gridPositions.Add(new Vector3(x, y, 0f));
            }
        }
    }

    void BoardSetup()
    {
        background = new GameObject("Background").transform;

        float floorSize = (float)floorTiles.GetComponent<SpriteRenderer>().bounds.size.x;
        float cageWSize = (float)cage.GetComponent<SpriteRenderer>().bounds.size.x;
        float cageHSize = (float)cage.GetComponent<SpriteRenderer>().bounds.size.y;

        //float x = 10;
        //float y = (480 - cageSize) / 2;
        float cellWidth = cageWSize / boardColumns;
        float cellHeight = cageHSize / boardRows;
        float widthOffset = -(Screen.width/60) / 2;
        float heightOffset = -(Screen.height/60) / 2;

        GameObject toInstantiate;
        GameObject instance;

        for (int x = 0; x < 14; x++)
        {
            for (int y = 0; y < 12; y++)
            {
                toInstantiate = floorTiles;
                instance = Instantiate(toInstantiate, new Vector3(widthOffset+(x * floorSize), heightOffset+(y*floorSize), 0f), Quaternion.identity) as GameObject;

                instance.transform.SetParent(background);
            
            }
        }
        toInstantiate = cage;
        instance = Instantiate(toInstantiate, new Vector3(widthOffset+(cageWSize/2), heightOffset+(cageHSize/2), 0f), Quaternion.identity) as GameObject;
        instance.transform.SetParent(boardHolder);

        //toInstantiate = playerTokens[0];
        //instance = Instantiate(toInstantiate, new Vector3(widthOffset + (cellWidth / 2), heightOffset + (cellHeight / 2), 0f), Quaternion.identity) as GameObject;
        //instance.transform.SetParent(boardHolder);
    }

    public void SetupScene()
    {

        BoardSetup();
        InitializeList();
    }

    // Use this for initialization
    void Start () {
        gameState = gameStateOptions;
        gameTurn = gameTurnPlayer1;
        playerType = playerTypeAI;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
