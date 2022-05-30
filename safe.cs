using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class safe : MonoBehaviour
{

    [SerializeField] GameObject safeIcon;
    [SerializeField]
    Collider2D col;

    void Start() 
    {
        var col = GetComponent<Collider2D>().enabled = true;
        safeIcon.SetActive(false);
    }


    void OnTriggerEnter2D() 
    {
        safeIcon.SetActive(true);
    }

    void OnTriggerExit2D()
    {
        safeIcon.SetActive(false);
    }

    public void removeCol() 
    {
        var col = GetComponent<Collider2D>().enabled = false;
    }




}
