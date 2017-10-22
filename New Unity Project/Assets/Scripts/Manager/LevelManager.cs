using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    bool sceneWinner = false;

	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(this);
	}
	
	// Update is called once per frame
	void Update () {
        if (SceneManager.GetActiveScene().name == "MainMenu")
        {
            OnMainMenu();
        }        
    }

        
    public void LoadScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }  

    void OnMainMenu()
    {
        if (Input.GetKeyDown("k") || Input.GetKeyDown("l"))
        {
            gameObject.GetComponent<PlayerManager>().player1Ready = true;
        }

        if (Input.GetKeyDown("f") || Input.GetKeyDown("g"))
        {
            gameObject.GetComponent<PlayerManager>().player2Ready = true;
        }

        if (gameObject.GetComponent<PlayerManager>().player1Ready && gameObject.GetComponent<PlayerManager>().player2Ready)
        {
            gameObject.GetComponent<PlayerManager>().qntPlayer = 2;
            LoadScene("Game");
        }
    }

}
