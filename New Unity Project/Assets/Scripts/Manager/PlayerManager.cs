using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour {

    public int qntPlayer;
    public bool player1Ready = false;
    public bool player2Ready = false;   
	
	// Update is called once per frame
	void Update () {

        if (FindObjectsOfType<LevelManager>().Length > 1)
        {
            Debug.Log("desytoi fdp!!");
            Destroy(FindObjectsOfType<LevelManager>()[0]);
        }

        if (SceneManager.GetActiveScene().name == "Game")
        {
            Winner();
        }

        Debug.Log(qntPlayer);
    }    

    void Winner()
    {
        if (qntPlayer == 1){

            MovePlayer winnerPlayer = FindObjectOfType<MovePlayer>();            
            gameObject.GetComponent<LevelManager>().LoadScene("Winner" + winnerPlayer.gameObject.name);
        }else
            if(qntPlayer == 0)
            {
                gameObject.GetComponent<LevelManager>().LoadScene("Draw");
            }
    }  


}
