using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour {

    public float hp = 100;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Death();
	}  

    void TakeDamage(float damage) {
        hp -= damage;        
    }

    void Death() {

        if(hp <= 0)
        {
            FindObjectOfType<PlayerManager>().qntPlayer--;
            DestroyImmediate(gameObject);
        }
        //Manda mensagem pro objeto que gerencia a vitória
    }
}
