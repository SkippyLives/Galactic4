using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartScene : MonoBehaviour {

    public void StartSinglePlayer()
    {
        SceneManager.LoadScene("Game");
    }
    public void StartMultiplayer()
    {
        SceneManager.LoadScene("NetworkManager");
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
