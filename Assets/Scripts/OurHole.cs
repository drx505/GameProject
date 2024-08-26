using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;
public class OurHole : MonoBehaviour
{
    public GameManager game;
    public GameObject lumpen;
    public bool cos;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", Random.Range(0.1f, 3.0f), Random.Range(2.0f, 20.0f));
    }

    // Update is called once per frame
    void Spawn()
    {
        if (game.IK >= 1)
        {
            Instantiate(lumpen, gameObject.transform.position, Quaternion.identity);
            game.LumNKM();
        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (cos)
        {
            if (col.gameObject.tag == "Lumpen")
            {
                Destroy(col.gameObject);
                game.LumNKP();
            }
        }
    }
}