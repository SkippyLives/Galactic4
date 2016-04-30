using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InitialLoad : MonoBehaviour {
    public InputField iField;

    private string playerName;
//    public InputF
	// Use this for initialization
	void Start () {
        playerName = PlayerPrefs.GetString("PNAME");

        iField.text = playerName;
	}
	
    public void SetName()
    {
        PlayerPrefs.SetString("PNAME", iField.text);
    }
	// Update is called once per frame
	void Update () {
	
	}
}
