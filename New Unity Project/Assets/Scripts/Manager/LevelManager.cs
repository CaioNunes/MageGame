using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    public string cep1a = "ChangeElementsP1A";
    public string cep1b = "ChangeElementsP1B";

    public string cep2a = "ChangeElementsP2A";
    public string cep2b = "ChangeElementsP2B";

    bool sceneWinner = false;
   // List<LevelManager> list = new List<LevelManager>();

    // Use this for initialization
    void Start()
    {
        Cursor.visible = false;
        Screen.fullScreen = true;
        DontDestroyOnLoad(this);

	}

    // Update is called once per frame
    void Update()
    {

        if(Input.GetButtonDown("Escape")){
            if (SceneManager.GetActiveScene().name == "MainMenu")
            {
                Application.Quit();
            }
            else {
                this.gameObject.GetComponent<PlayerManager>().player1Ready = false;
                this.gameObject.GetComponent<PlayerManager>().player2Ready = false;
            }

            SceneManager.LoadScene("MainMenu");
            Destroy(this);
        }

    }

    public void LoadScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
