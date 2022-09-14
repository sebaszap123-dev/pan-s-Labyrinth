using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textoTiempo;
    [SerializeField] TextMeshProUGUI winsGame;
    private float tiempo = 60;
    // public string textValue;
    // public Text textElement;
    // Start is called before the first frame update
    void Start()
    {
        winsGame.text = "";
        // textValue = "Victoria!";
    }

    private void Update()
    {
        tiempo -= Time.deltaTime;
        textoTiempo.text = "" + (int)tiempo;
        if(tiempo <= 0){
            Muerto();
        }
    }
    
    private void Muerto(){
        SceneManager.LoadScene(0);
    }
    public void Wins(){
        winsGame.text = "Victoria";
        // textElement.text = textValue;
    }
    public void RestarPuntos(){
        tiempo--;
    }
}
