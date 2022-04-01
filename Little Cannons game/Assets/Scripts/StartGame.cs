using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public GameObject Canvas, game;

    void Awake()
    {
        game.SetActive(false);
    }

    public void Startgame(){
        Canvas.SetActive(false);
        game.SetActive(true);

    }
}
