using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HudWinner : MonoBehaviour {
        
	// Use this for initialization
	public void Retry()
    {
        FindObjectOfType<PlayerManager>().qntPlayer = 2;
        foreach(Life hp in FindObjectsOfType<Life>())
        {
            hp.hp = 1;
        }

        LevelManager scene = FindObjectOfType<LevelManager>();
        scene.LoadScene("Game");
    }

    
}
