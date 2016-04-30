using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StandaloneOptions : MonoBehaviour
{
    public Toggle hotseat;
    public Toggle computer;
    public InputField test;

    //    public InputF
    // Use this for initialization
    void Start()
    {
        test.text = PlayerPrefs.GetInt("GAMETYPE").ToString();
        if (PlayerPrefs.GetInt("GAMETYPE") == 2)
        {
            computer.isOn = true;
        }
        else
        {
            hotseat.isOn = true;
        }
    }
    
    public void SetGameType()
    {
        if (hotseat.isOn == true)
        {
            //test.text = "hotseat on";
            PlayerPrefs.SetInt("GAMETYPE", 1);
        }
        else if (computer.isOn == true)
        {
            //test.text = "hotseat off";
            PlayerPrefs.SetInt("GAMETYPE", 2);
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}