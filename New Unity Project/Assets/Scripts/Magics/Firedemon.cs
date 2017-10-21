using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firedemon : MonoBehaviour {

    public float velocity = 2;
    public float direction;

    // Use this for initialization
    void Start()
    {
        if (gameObject.transform.position.x > 0)
        {
            direction = -1;
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
        else
        {
            direction = 1;
        }



    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * velocity * Time.deltaTime, 0, 0);
    }
}
