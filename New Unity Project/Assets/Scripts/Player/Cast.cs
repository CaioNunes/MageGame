using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class Cast : MonoBehaviour {

    string[] magicElements;
    string [] magicPanel;
    string magic;

    Transform playerPosition;
    
    int position_panel = 0;
    public int position_elements_A = 0;
    public int position_elements_B = 0;

    bool canCast = true;

    public float cooldown;
    float cont;

    string lastMagic;

	// Use this for initialization
	void Start () {
        magicPanel = new string[2] { "A", "A"};
        magicElements = new string[3] { "A","F","T" };
    }
	
	// Update is called once per frame
	void Update () {
        playerPosition = this.gameObject.transform;

        if (cont <= cooldown) {
            cont += Time.deltaTime;
        }        

        float move = Input.GetAxisRaw(this.gameObject.GetComponent<Controls>().cast);
        if (move > 0 && this.gameObject.transform.position.x < 0)
        {
            MagicCast();
        }

        if (move < 0 && this.gameObject.transform.position.x > 0)
        {
            MagicCast();
        }        

        if (Input.GetButtonDown(this.gameObject.GetComponent<Controls>().changeElementB))
        {
            ChangeElementB();
        }

        if (Input.GetButtonDown(this.gameObject.GetComponent<Controls>().changeElementA)){
            ChangeElementA();
        }
    }

    void MagicCast() {            
            for (int i = 0; i < 2; i++) {
                if (magicPanel[i] == "E" ) {
                    canCast = false;                    
                }
            }

            if (cont < cooldown) {
                canCast = false;    
            }

            if (canCast) {                
                Array.Sort(magicPanel);                
                magic = magicPanel[0] + magicPanel[1];
                if (magic == lastMagic)
                {
                    //audio de falha
                    lastMagic = "";
                }
                else {           
                    if(playerPosition.position.x > 0)
                        Instantiate(FindObjectOfType<MagicManager>().magics[magic] as GameObject, new Vector2(playerPosition.position.x - 2.67f, playerPosition.position.y), Quaternion.identity);
                    else
                        Instantiate(FindObjectOfType<MagicManager>().magics[magic] as GameObject, new Vector2(playerPosition.position.x + 2.67f, playerPosition.position.y), Quaternion.identity);

                lastMagic = magic;
                cont = 0;                
                }
                ClearMagic();
            }        
        canCast = true;
    }

    void ChangeElementB() {

        position_elements_B++;

        if (position_elements_B > 2)
        {
            position_elements_B = 0;
        }
        magicPanel[1] = magicElements[position_elements_B];
    }

    void ChangeElementA(){

        position_elements_A++;

        if (position_elements_A > 2)
        {
            position_elements_A = 0;
        }
        magicPanel[0] = magicElements[position_elements_A];
    }

    void ClearMagic(){
        for (int i = 0; i < 2; i++)
        {
            magicPanel[i] = "E";            
       }
        position_panel = -1;
        position_elements_A = -1;
        position_elements_B = -1;
    }
}
