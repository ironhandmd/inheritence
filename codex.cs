using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class codex : MonoBehaviour
{
    icon_controller IC;


    void Start() 
    {
        IC = FindObjectOfType<icon_controller>();
    }


    void OnTriggerEnter2D() 
    {
        IC.activateIconCdx();
    }
    void OnTriggerExit2D()
    {
        IC.deactivateIconCdx();
    }



}
