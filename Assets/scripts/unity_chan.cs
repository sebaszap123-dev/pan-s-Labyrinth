using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unity_chan : MonoBehaviour
{
    private Rigidbody rig;
    private float velocidad = 600;
    private GameManager gameManager;
    private void Awake()
    {
        rig = GetComponent<Rigidbody>();
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 orientation = Input.acceleration;
        orientation = Quaternion.Euler(90,0,0) * orientation;
        rig.AddForce(orientation * velocidad * Time.deltaTime);
    }
    // private void OnCollision(Collision collision){
    //     if(collision.gameObject.CompareTag("Salida")){
    //         gameManager.Wins();
    //     } else if(collision.gameObject.CompareTag("Pared")){
    //         gameManager.RestarPuntos();
    //     }
    // }
}
