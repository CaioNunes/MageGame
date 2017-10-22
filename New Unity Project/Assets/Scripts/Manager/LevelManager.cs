using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public string cep1a = "ChangeElementsP1A";
    public string cep1b = "ChangeElementsP1B";

    public string cep2a = "ChangeElementsP2A";
    public string cep2b = "ChangeElementsP2B";

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
    }

        
    public void LoadScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }  

    void OnMainMenu()
    {
       if (Input.GetKeyDown("k") || Input.GetKeyDown("l") || Input.GetButtonDown(cep1a) || Input.GetButtonDown(cep1b))
       {
            gameObject.GetComponent<PlayerManager>().player1Ready = true;
       }

        if (Input.GetKeyDown("f") || Input.GetKeyDown("g") || Input.GetButtonDown(cep2a) || Input.GetButtonDown(cep2b))
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
