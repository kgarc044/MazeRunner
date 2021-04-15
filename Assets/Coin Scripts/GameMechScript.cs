using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;


public class GameMechScript : MonoBehaviour
{
    /*public GameObject[] Lights;
    public GameObject[] Colliders;
    private float timer;
    private float waitTime;
    public int currentLight;*/
    public int currentscore;
    public int level;
    public Text displayScore;
    public Text displayLevel;
    public EndGame endgameobject;
    public StartGame startgameobject;
    public Death deathobject;
    public GameObject barrier;
    public GameObject controller;
    

    void Start()
    {
        //bool endofLevel = false;
        level = 1;
        currentscore = 0;
        displayScore.text = currentscore.ToString();
        displayLevel.text = level.ToString();
        barrier.SetActive(true);
        startgameobject.StartGameScreenOn();
        Debug.Log("We are in level" + level);
    }

    public void UpdateScore()
    {
        currentscore++;
        //score.text = currentscore.ToString();
        displayScore.text = currentscore.ToString();
        Debug.Log("GET! SCORECOUNT: " + currentscore);
    }

    public void UpdateLevel()
    {
        displayLevel.text = level.ToString();
        Debug.Log("We are in level" + level);
    }

    /*public void checkIfWon()
    {
        if (currentscore == 3)
        {

        }
    }*/
    void Update()
    {
        if (Input.GetKeyDown("q"))
        {
            barrier.SetActive(false);
            startgameobject.StartGameScreenOff();
        }
        if (currentscore == 2 )
        {
            level += 1;

            ResetLevelPosition(level);
            if (level == 4)
            {
                endgameobject.EndGameScreen();
                Time.timeScale = 0;
            }
        }

    }
    public void ResetLevelPosition(int level)
    {
        currentscore = 0;
        
        displayScore.text = currentscore.ToString();
        if (level == 1)
        {
            controller.transform.position = new Vector3(95, 2, 24);
            UpdateLevel();
        }
        else if (level == 2)
        {
            controller.transform.position = new Vector3(21, 3, 23);
            UpdateLevel();
        }
        else if (level == 3)
        {
            controller.transform.position = new Vector3(-45, 2, 20);
            UpdateLevel();
        }

    }
    
    public void PlayerDeathReset()
    {
        deathobject.DeathScreen();
        Time.timeScale = 0;
    }
}
