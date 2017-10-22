using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour {

    public float maxSpeed;
    public float minHeight;
    public float maxHeight;
    

    private bool canMoveUp;
    private bool canMoveDown;

    Animator anim;

    void Start(){
        anim = GetComponent<Animator>();
    }

    void Update(){
        HandleMoveUp();       
    }

    //Handles Horizontal input and moves player
    public void HandleMoveUp(){

        float move = Input.GetAxisRaw(gameObject.GetComponent<Controls>().verticalMove);
        canMove();

        if (move > 0 && canMoveUp){
            anim.Play("moveUp");
            transform.Translate(0, maxSpeed * Time.deltaTime, 0);
        }

        if (move < 0 && canMoveDown){
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
