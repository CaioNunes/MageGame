using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HudManager : MonoBehaviour {

    public Sprite[] elements;
    public GameObject[] elementSlotsP1;
    public GameObject[] elementSlotsP2;
    public Slider lifeP1;
    public Slider lifeP2;

    int numberP1A;
    int numberP1B;
    int numberP2A;
    int numberP2B;

    GameObject player1;
    GameObject player2;
    // Use this for initialization
    void Start () {
        player1 = GameObject.FindGameObjectWithTag("Player1");
        player2 = GameObject.FindGameObjectWithTag("Player2");

        
    }
	
	// Update is called once per frame
	void Update () {

        if (FindObjectOfType<PlayerManager>().qntPlayer > 1)
        {

            //Player 1 panel elements
            numberP1A = player1.GetComponent<Cast>().position_elements_A;
            if (numberP1A != -1)
            {
                elementSlotsP1[0].GetComponentInChildren<SpriteRenderer>().enabled = true;
                elementSlotsP1[0].GetComponentInChildren<SpriteRenderer>().sprite = elements[numberP1A];
            }
            else
            {

                elementSlotsP1[0].GetComponentInChildren<SpriteRenderer>().enabled = false;
            }

            numberP1B = player1.GetComponent<Cast>().position_elements_B;
            if (numberP1B != -1)
            {
                elementSlotsP1[1].GetComponentInChildren<SpriteRenderer>().enabled = true;
                elementSlotsP1[1].GetComponentInChildren<SpriteRenderer>().sprite = elements[numberP1B];
            }
            else
            {
                elementSlotsP1[1].GetComponentInChildren<SpriteRenderer>().enabled = false;
            }


            //Player 2 panel elements
            numberP2A = player2.GetComponent<Cast>().position_elements_A;
            if (numberP2A != -1)
            {
                elementSlotsP2[0].GetComponentInChildren<SpriteRenderer>().enabled = true;
                elementSlotsP2[0].GetComponentInChildren<SpriteRenderer>().sprite = elements[numberP2A];
            }
            else
            {

                elementSlotsP2[0].GetComponentInChildren<SpriteRenderer>().enabled = false;
            }

            numberP2B = player2.GetComponent<Cast>().position_elements_B;
            if (numberP2B != -1)
            {
                elementSlotsP2[1].GetComponentInChildren<SpriteRenderer>().enabled = true;
                elementSlotsP2[1].GetComponentInChildren<SpriteRenderer>().sprite = elements[numberP2B];
            }
            else
            {
                elementSlotsP2[1].GetComponentInChildren<SpriteRenderer>().enabled = false;
            }

            lifeP1.value = player1.GetComponent<Life>().hp;
            lifeP2.value = player2.GetComponent<Life>().hp;

        }

    }



    

}
