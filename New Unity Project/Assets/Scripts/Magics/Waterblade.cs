﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waterblade : MonoBehaviour {
    public AudioClip som;

    public float velocity;
    public float direction;
    float damage = 0.15f;

    // Use this for initialization
    void Start()
    {
        AudioSource.PlayClipAtPoint(som, transform.position);

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
        transform.Translate(direction * velocity * Time.deltaTime, 0, 0);
        if (Mathf.Abs(transform.position.x) > 10f)
        {
            Destroy(this.gameObject);
        }
    }

    void mirror()
    {
        direction *= -1;
        this.gameObject.GetComponent<SpriteRenderer>().flipX = !this.gameObject.GetComponent<SpriteRenderer>().flipX;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Mirror")
        {
            Vector3 scale = transform.localScale;
            scale.x *= -1;
            transform.localScale = scale;
            direction *= -1;
        }

        if (collision.gameObject.tag == "Player1" || collision.gameObject.tag == "Player2")
        {
            collision.gameObject.SendMessage("TakeDamage", damage);
            Destroy(this.gameObject);
        }
    }

    void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player1" || collision.gameObject.tag == "Player2")
        {
            collision.gameObject.SendMessage("TakeDamage", damage);
            Destroy(this.gameObject);
        }


    }
}
