using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikeball : MonoBehaviour
{
    // Start is called before the first frame update
    public GameMechScript gamemechscript;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.name == "FPSController")
        {
            Debug.Log("OW ITS A SPIKE");
            gamemechscript.PlayerDeathReset();
        }
    }
}

