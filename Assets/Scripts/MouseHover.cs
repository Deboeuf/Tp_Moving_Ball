using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class MouseHover : MonoBehaviour
{

    void OnMouseEnter(){
        TextMeshPro textmeshPro = GetComponent<TextMeshPro>();
        textmeshPro.color = Color.red;
    }

    void OnMouseExit() {
        TextMeshPro textmeshPro = GetComponent<TextMeshPro>();
        textmeshPro.color = Color.white;
    }

    void OnMouseUp()
    {
        if(gameObject.name == "Play"){
            SceneManager.LoadScene (1);
        }
        if(gameObject.name == "Exit"){
            Application.Quit();
        }
    }
}
