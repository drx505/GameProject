using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OuLumpen : MonoBehaviour
{
    Vector3 size;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        size = gameObject.transform.localScale;
        gameObject.transform.localScale = new Vector3(-size.x, size.y, size.z);
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = Vector2.left * 0.5f;
    }
}
