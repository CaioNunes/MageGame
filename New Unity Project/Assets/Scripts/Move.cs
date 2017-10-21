using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

   public float maxSpeed;

    void Start(){

    }

    void Update(){
        handleMoveUp();
    }

    //Handles Horizontal input and moves player
    public void handleMoveUp(){

        float moveUp = Input.GetAxisRaw(gameObject.GetComponent<Controles>().moveUp);

        if (moveUp > 0){
            transform.Translate(0, maxSpeed * Time.deltaTime, 0);
        }

        if (moveUp < 0){
            transform.Translate(0, -maxSpeed * Time.deltaTime, 0);
        }

    }
}
