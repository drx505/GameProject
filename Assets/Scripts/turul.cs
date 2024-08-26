using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class turul : MonoBehaviour
{
    public GameManager game;
    public Rigidbody2D rb;
    private SpriteRenderer sprite;
    public Sprite s1;
    public Sprite s2;
    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (game.itol == true)
        {
            if (game.IL >= 8)
            {
                game.itol = false;
                rb.AddForce(Vector2.up * 30);
                Invoke("Vzhiu", 5.0f);
                game.IPM8();
            }
        }
    }
    public void Vzhiu()
    {
        rb.AddForce(Vector2.right * 40);
    }
    public void Vzhiu2()
    {
        rb.AddForce(Vector2.left * 40);
        sprite.sprite = s2;
        Invoke("Vzhiu3", 3.0f);
    }
    public void Vzhiu3()
    {
        rb.AddForce(Vector2.down * 40);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "kublo")
        {
            rb.velocity = new Vector2(0, 0);
            game.NKP8();
            Invoke("Vzhiu2", 4.0f);
        }
        if (collision.gameObject.tag == "Barracks")
        {
            rb.velocity = new Vector2(0, 0);
            gameObject.transform.position = new Vector3(-15.56f, 1.17f, 0f);
            sprite.sprite = s1;
            game.itol = true;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Stop")
        {
            rb.velocity = new Vector2(rb.velocity.x, 0);
        }
    }
}
