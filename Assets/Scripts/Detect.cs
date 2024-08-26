using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;
public class Detect : MonoBehaviour
{
    public GameManager game;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "OurLumpen")
        {
            game.A(col.gameObject.transform.position);
            Debug.Log("im");
        }
    }
}
