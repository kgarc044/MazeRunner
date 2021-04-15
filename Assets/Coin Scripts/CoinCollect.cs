using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollect : MonoBehaviour
{
    
    //public Text displayScore;
    public AudioClip coinSound;
    // Start is called before the first frame update
    public GameMechScript gamemechscript;
    void Start()
    {
 
        //displayScore.text = currentscore.ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(90 * Time.deltaTime, 90 * Time.deltaTime, 0);
        
    }
    /*
    public void UpdateScore()
    {
        currentscore++;
        //score.text = currentscore.ToString();
        displayScore.text = currentscore.ToString();
        Debug.Log("GET! SCORECOUNT: " + currentscore);
    }*/
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "FPSController")
        {
            gamemechscript.UpdateScore();
            AudioSource.PlayClipAtPoint(coinSound, transform.position);
            Destroy(gameObject);
        }
    }
}
