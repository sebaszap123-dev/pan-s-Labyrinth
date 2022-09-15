// using System.Diagnostics;
using System.Collections;
using UnityEngine;

public class CollisionTester : MonoBehaviour
{
    private GameManager gameManager;
    private void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "BadObject")
        {
            gameManager.RestarPuntos();
        }
        if (other.gameObject.tag == "Salida")
        {
            gameManager.Wins();
        }
        // Debug.Log(gameObject.name + "collided with");
    }
    // void OnTriggerEnter(Collider other)
    // {
    //     Debug.Log(gameObject.name + "trigger enter");
    // }
}
