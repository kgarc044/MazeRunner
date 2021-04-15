using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGame : MonoBehaviour
{
    public GameObject EndGameUI;
    GameMechScript gamemechscript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void EndGameScreen()
    {
        Debug.Log("EndGame() was called");
        EndGameUI.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        //gamemechscript.checkIfWon();
    }
}
