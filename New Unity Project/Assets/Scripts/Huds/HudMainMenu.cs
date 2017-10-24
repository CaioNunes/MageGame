using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HudMainMenu : MonoBehaviour {

    public string buttonAP1;
    public string buttonAP2;

    public GameObject player1;
    public GameObject player2;   

    Animator animControllerP1;
    Animator animControllerP2;
    public AudioClip p1;    

    // Use this for initialization
    void Start () {
        animControllerP1 = player1.GetComponent<Animator>();
        animControllerP2 = player2.GetComponent<Animator>();

        animControllerP1.Play("idle");
        animControllerP2.Play("idle");

        FindObjectOfType<PlayerManager>().player1Ready = false;
        FindObjectOfType<PlayerManager>().player2Ready = false;

    }
	
	// Update is called once per frame
	void Update () {        

        if (Input.GetButtonDown(buttonAP1))//seleção player1
        {
            AudioSource.PlayClipAtPoint(p1, transform.position);
            animControllerP1.Play("attack");
            FindObjectOfType<PlayerManager>().player1Ready = true;            
        }

        if (Input.GetButtonDown(buttonAP2))//seleção player2
        {
            AudioSource.PlayClipAtPoint(p1, transform.position);
            animControllerP2.Play("attack");
            FindObjectOfType<PlayerManager>().player2Ready = true;            
        }

       if (FindObjectOfType<PlayerManager>().player1Ready && FindObjectOfType<PlayerManager>().player2Ready)
       {
            FindObjectOfType<LevelManager>().LoadScene("Tutorial");
       }
    }



}
