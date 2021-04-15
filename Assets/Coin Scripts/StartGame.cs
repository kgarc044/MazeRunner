using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    public GameObject StartGameUI;
    GameMechScript gamemechscript;
    // Start is called before the first frame update
    void Start()
    {
        StartGameScreenOn();
    }

    public void StartGameScreenOn()
    {
        Debug.Log("StartGameScreenOn called");
        StartGameUI.SetActive(true);
    }

    public void StartGameScreenOff()
    {
        Debug.Log("StartGameScreenOff called");
        StartGameUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //gamemechscript.checkIfWon();
    }
}
