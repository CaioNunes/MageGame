using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rockwall : MonoBehaviour {
    public AudioClip som;

    public float velocity = 2;
    public float direction;
    public float duration;

    public float positionInstante;

    float cont = 0f;


    // Use this for initialization
    void Start()
    {
        AudioSource.PlayClipAtPoint(som, transform.position);

        if (gameObject.transform.position.x > 0)
        {
            transform.Translate(transform.position.x - positionInstante, 0, 0);
            direction = -1;
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
        else
        {
            direction = 1;
            transform.Translate(transform.position.x + positionInstante, 0, 0);
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (cont <= duration)
        {
            cont += Time.deltaTime;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}
