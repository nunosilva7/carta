using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerarCarta : MonoBehaviour {
    string[] naipe = new string[] { "Espadas", "Copas", "Paus", "Ouros" };
    string[] valor = new string[] { "o 2", "o 3", "o 4", "o 5", "o 6", "o 7", "o 8", "o 9", "o 10", "a Dama", "o Valete", "o Rei", "o Ás" };
    // Start is called before the first frame update
    void Start () {

        Debug.Log ("Clica na barra de espaço para gerar uma carta aleatoriamente");

    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown (KeyCode.Space)) {

            CartaAleatoria ();
        }

    }

    void CartaAleatoria () {
        string naipeAleatorio = naipe[Random.Range (0, naipe.Length)];
        string valorAleatorio = valor[Random.Range (0, valor.Length)];
        Debug.Log ("Saiu" + " " + valorAleatorio + " " + "de" + " " + naipeAleatorio);

    }
}