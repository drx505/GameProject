using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class caladrius : MonoBehaviour
{
    public GameManager game;
    public Rigidbody2D rb;
    public bool da;
    private SpriteRenderer sprite;
    public Sprite s1;
    public Sprite s2;
    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
    }
    void Start()
    {
        da = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (da)
        {
            if (sprite)
            {
                sprite.sortingOrder = -11;
            }
        }
        else
        {
            if (sprite)
            {
                sprite.sortingOrder = -6;
            }
        }
    }
    public void Activate()
    {
        if (game.icob == true)
        {
            if (game.IB >= 6)
            {
                game.icob = false;
                rb.AddForce(Vector2.up * 30);
                Invoke("Vzhiu", 5.0f);
                game.NPM6();
            }
        }
    }
    public void Vzhiu()
    {
        rb.AddForce(Vector2.left * 30);
    }
    public void Vzhiu2()
    {
        rb.AddForce(Vector2.right * 40);
        sprite.sprite = s2;
        Invoke("Vzhiu3", 3.0f);
    }
    public void Vzhiu3()
    {
        rb.AddForce(Vector2.down * 40);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Changeoil")
        {
            da = !da;
        }
        if (collision.gameObject.tag == "nidus")
        {
            rb.velocity = new Vector2(0, 0);
            game.IKP6();
            Invoke("Vzhiu2", 4.0f);
        }
        if (collision.gameObject.tag == "Barracks")
        {
            rb.velocity = new Vector2(0, 0);
            gameObject.transform.position = new Vector3(1.79f, 1.01f, 0f);
            sprite.sprite = s1;
            game.icob = true;
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
