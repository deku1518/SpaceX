using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidDestroy : MonoBehaviour
{

    public int scoreValue;
    private GameController gameController;


    void Start()
    {
        GameObject gameControllerObject = GameObject.FindWithTag ("GameController");

        if(gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<GameController>();
        }
    }



    
    void OnTriggerEnter(Collider other)
    
    {
        if(other.tag == "Boundary" || other.tag == "Enemy")
        {
            return;
        }
        if (other.tag == "Player")
        {
            scoreValue -= 5;
            gameController.GameOver();

        }
        gameController.AddScore(scoreValue);
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
