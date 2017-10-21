using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour {

    private float hp = 100;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}  

    void takeDamage(float damage) {
        hp -= damage;
        Debug.Log(hp);
    }

    void death() {
        //Manda mensagem pro objeto que gerencia a vitória
    }
}
