using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    public float maxSpeed;
    public float minHeight;
    public float maxHeight;

    private bool canMoveUp;
    private bool canMoveDown;

    void Start(){

    }

    void Update(){
        handleMoveUp(); 
    }

    //Handles Horizontal input and moves player
    public void handleMoveUp(){

        float moveUp = Input.GetAxisRaw(gameObject.GetComponent<Controles>().moveUp);
        canMove();

        if (moveUp > 0 && canMoveUp){
            transform.Translate(0, maxSpeed * Time.deltaTime, 0);
        }

        if (moveUp < 0 && canMoveDown){
            transform.Translate(0, -maxSpeed * Time.deltaTime, 0);
        }

    }

    void canMove() {
        if (gameObject.transform.position.y >= maxHeight)
        {
            canMoveUp = false;
        }
        else
        {
            canMoveUp = true;
        }

        if (gameObject.transform.position.y <= minHeight)
        {
            canMoveDown = false;
        }
        else
        {
            canMoveDown = true;
        }
    }
}
