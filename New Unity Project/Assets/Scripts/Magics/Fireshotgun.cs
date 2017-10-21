using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireshotgun : MonoBehaviour {

    public float velocity = 2;
    public float direction;

    // Use this for initialization
    void Start()
    {
        if (gameObject.transform.position.x > 0)
            direction = -1;
        else
            direction = 1;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * velocity * Time.deltaTime, 0, 0);
    }
}
