using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirror : MonoBehaviour {

    public AudioClip som;
    public float velocity = 2;
    public float direction;
    public float duration;
    float cont = 0f;

    public float positionInstante;

    // Use this for initialization
    void Start(){

        AudioSource.PlayClipAtPoint(som, transform.position);

        if (gameObject.transform.position.x > 0){
            
            transform.Translate(transform.position.x - positionInstante, 0, 0);
            direction = -1;
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
        else
        {
            transform.Translate(transform.position.x + positionInstante, 0, 0);
            direction = 1;
        }

    }

    // Update is called once per frame
    void Update(){
        if (cont <= duration)
        {
            cont += Time.deltaTime;
        }
        else {
            Destroy(this.gameObject);
        }

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Magic") {
            Debug.Log("Entrei aqui");
            collision.gameObject.SendMessage("mirror");
            Destroy(this.gameObject);
        }
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Magic")
        {
            Debug.Log("Entrei aqui");
            collision.gameObject.SendMessage("mirror");
            Destroy(this.gameObject);
        }
    }

}
