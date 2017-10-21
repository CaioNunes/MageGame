using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour {

    public int qntPlayer = 0;
    bool player1Ready = false;
    bool Player2Ready = false;   
	
	// Update is called once per frame
	void Update () {
        if (SceneManager.GetActiveScene().name == "MainMenu")
        {
            OnMainMenu();
        }

        if (SceneManager.GetActiveScene().name == "Game")
        {
            Winner();
        }        		
	}

    void OnMainMenu()
    {
        if(Input.GetKeyDown("k") || Input.GetKeyDown("l")){
            player1Ready = true;
        }

        if (Input.GetKeyDown("f") || Input.GetKeyDown("g")){
            player1Ready = true;
        }

        if (player1Ready && Player2Ready){
            qntPlayer = 2;
            LoadScene("Game");
        }
    }

    void Winner()
    {
        if (qntPlayer < 2 && qntPlayer > 0){
            MovePlayer winnerPlayer = FindObjectOfType<MovePlayer>();
            DontDestroyOnLoad(winnerPlayer.gameObject);
            LoadScene(winnerPlayer.gameObject.name);
        }
        else
            if (qntPlayer == 0){
            LoadScene("PlayerEmpate");
            }
    }

    public void LoadScene(string scene)
    {        
        SceneManager.LoadScene(scene);
    }


}
