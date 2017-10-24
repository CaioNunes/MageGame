using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour{

    void Start()
    {
        Cursor.visible = false;
        Screen.SetResolution(1920, 1080, true);
        Screen.fullScreen = true;
        DontDestroyOnLoad(this);

	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Escape")){
            if (SceneManager.GetActiveScene().name == "MainMenu")
            {
                Application.Quit();
            }
            
            SceneManager.LoadScene("MainMenu");
            Destroy(gameObject);
        }

    }

    public void LoadScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
