using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour {

    public float hp = 1;
    

    // Update is called once per frame
    void Update () {
        Death();
	}

    void TakeDamage(float damage)
    {
        StartCoroutine(Piscando());
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
    

    IEnumerator Piscando()
    {
        for(int i = 0 ;i < 3; i++)
        {
            GetComponent<Renderer>().enabled = true;
            yield return new WaitForSeconds(0.1f);
            GetComponent<Renderer>().enabled = false;
            yield return new WaitForSeconds(0.1f);
        }
        GetComponent<Renderer>().enabled = true;
    }


}



