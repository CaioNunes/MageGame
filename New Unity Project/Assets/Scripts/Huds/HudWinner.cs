using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HudWinner : MonoBehaviour {
        
	// Use this for initialization
	public void Retry()
    { 
        LevelManager scene = FindObjectOfType<LevelManager>();
        scene.LoadScene("Game");
    }

    
}
