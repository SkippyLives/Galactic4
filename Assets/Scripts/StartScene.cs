using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartScene : MonoBehaviour {

    public void StartStandalone()
    {
        PlayerPrefs.SetInt("GAMETYPE", 1);
        SceneManager.LoadScene("Standalone");
    }
    public void StartMultiplayer()
    {
        PlayerPrefs.SetInt("GAMETYPE", 3);
        SceneManager.LoadScene("NetworkManager");
    }
    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
