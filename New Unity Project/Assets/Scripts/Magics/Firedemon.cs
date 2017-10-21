using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firedemon : MonoBehaviour {

    public float velocity = 2;
    public float direction;
    public float duration;
    public float fireRate;
    public GameObject firebalinhas;

    float contRate = 0f;

    float cont = 0f;

    public float positionInstante;


    // Use this for initialization
    void Start()
    {
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
            attack();
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    void attack() {
        contRate += Time.deltaTime;
        if (contRate >= fireRate) {
            Instantiate(firebalinhas, new Vector2(transform.position.x + (1f * direction), transform.position.y), Quaternion.identity);
            contRate = 0;
        }
    }
}
