﻿using System.Collections;
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

    string lastMagic;

	// Use this for initialization
	void Start () {
        magicPanel = new string[2] { "A", "A"};
        magicElements = new string[3] { "A","F","T" };
    }
	
	// Update is called once per frame
	void Update () {
        playerPosition = gameObject.transform;

        if (Input.GetButtonDown(gameObject.GetComponent<Controls>().clearMagic))
        {
            ClearMagic();
        }

        if (Input.GetButtonDown(gameObject.GetComponent<Controls>().cast))
        {
            MagicCast();
        }

        if (Input.GetButtonDown(gameObject.GetComponent<Controls>().changeElementB))
        {
            ChangeElementB();
        }

        if (Input.GetButtonDown(gameObject.GetComponent<Controls>().changeElementA)){
            ChangeElementA();
        }
    }

    void MagicCast() {            
            for (int i = 0; i < 2; i++) {
                if (magicPanel[i] == "E") {
                    canCast = false;
                    Debug.Log("Sem Magia");
                }
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
                Debug.Log(magic);
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
