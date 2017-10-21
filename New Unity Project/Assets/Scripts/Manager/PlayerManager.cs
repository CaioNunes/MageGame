﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour {

    public int qntPlayer = 0;
    public bool player1Ready = false;
    public bool player2Ready = false;   
	
	// Update is called once per frame
	void Update () {
        if (SceneManager.GetActiveScene().name == "Game")
        {
            Winner();
        }
    }    

    void Winner()
    {
        if (qntPlayer < 2 && qntPlayer > 0){
            MovePlayer winnerPlayer = FindObjectOfType<MovePlayer>();
            DontDestroyOnLoad(winnerPlayer.gameObject);
            gameObject.GetComponent<LevelManager>().LoadScene(winnerPlayer.gameObject.name);
        }
        else
            if (qntPlayer == 0){
            gameObject.GetComponent<LevelManager>().LoadScene("Empate");
        }
    }

    


}