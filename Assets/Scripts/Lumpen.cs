using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lumpen : MonoBehaviour
{
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = Vector2.right*0.5f;
    }
}
