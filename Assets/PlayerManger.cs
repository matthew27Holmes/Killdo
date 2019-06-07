using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManger : MonoBehaviour {

    //set up controls for number of players in the game 
    public int PlayerNum;
    private List<GameObject> Players = new List<GameObject>();
    public GameObject playerPrefab;
    public CameraManger camMan;
	// Use this for initialization
	void Start () {
        createPlayers();
        camMan.cerateCamears(PlayerNum);
    }
	
    void createPlayers()
    {
        for(int i = 0; i <PlayerNum; i++)
        {
            GameObject newPlayer = Instantiate(playerPrefab, transform.position, Quaternion.identity);
            newPlayer.transform.parent = transform;

            PlayerControler PC = newPlayer.GetComponent<PlayerControler>();
            PC.PlayerID = "P" + i.ToString();
            PC.murderer = false;

            Players.Add(newPlayer);
        }
    }
}
