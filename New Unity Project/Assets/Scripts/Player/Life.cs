using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour {

    public float hp;
    public float maxHP = 1;

    private void Awake()
    {
        hp = maxHP;
    }

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



