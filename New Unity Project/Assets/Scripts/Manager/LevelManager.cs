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

    // Use this for initialization
    void Start()
    {
        DontDestroyOnLoad(this);

	}

    // Update is called once per frame
    void Update()
    {

    }

    public void LoadScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
