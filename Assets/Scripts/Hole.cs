using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;
public class Hole : MonoBehaviour
{
    public GameManager game;
    public GameObject lumpen;
    public bool cos;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", Random.Range(0.1f, 1.0f), Random.Range(5.0f, 10.0f));
    }

    // Update is called once per frame
    void Spawn()
    {
        if (game.IN >= 1)
        {
            Instantiate(lumpen, gameObject.transform.position, Quaternion.identity);
            game.LumIKM();
        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (cos)
        {
            if (col.gameObject.tag == "OurLumpen")
            {
                Destroy(col.gameObject);
                game.LumIKP();
            }
        }
    }
}
