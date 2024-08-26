using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    public GameManager game;
    public Vector2 direction;
    public float speed = 8;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            direction = Vector2.up;
        }
        else if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            direction = Vector2.down;
        }
        else
        {
            direction = Vector2.zero;
        }
        if (direction.x * direction.x + direction.y * direction.y != 0)
        {
            rb.AddForce(direction * speed);
        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Lumpen")
        {
            Destroy(col.gameObject);
            game.LumNPP();
        }
    }
}
