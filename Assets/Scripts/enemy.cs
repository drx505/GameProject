using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class enemy : MonoBehaviour
{
    public GameManager game;
    public Rigidbody2D rb;
    Vector3 lup;
    public float speed = 4f;
    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (lup.y > gameObject.transform.position.y)
        {
            transform.Translate(0, 0.01f, 0);
            //rb.AddForce(Vector2.up * speed);
        }
        else if (lup.y < gameObject.transform.position.y)
        {
            transform.Translate(0, -0.01f, 0);
            //rb.AddForce(Vector2.down * speed);
        }
    }
    public void PA(Vector3 pos)
    {
        lup = pos;
        Debug.Log("im");
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "OurLumpen")
        {
            Destroy(col.gameObject);
            game.LumIPP();
        }
    }
}
