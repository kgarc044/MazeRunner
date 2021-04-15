using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject DeathUI;
    GameMechScript gamemechscript;
    // Start is called before the first frame update
    void Start()
    {
       // DeathUI.SetActive(false);
    }

    public void DeathScreen()
    {
        Debug.Log("DeathSccreen() was called");
        DeathUI.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        //gamemechscript.checkIfWon();
    }
}
