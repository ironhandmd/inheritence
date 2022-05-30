using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camswitcher : MonoBehaviour
{

    [SerializeField]
    GameObject cam1,cam2;
    player_movement PM;
    
    void Start()
    {
        PM = FindObjectOfType<player_movement>();
        cam1.SetActive(true);
        cam2.SetActive(false);
    }

    public void switchToCam1()
    {
        PM.nowMove();
        cam1.SetActive(true);
        cam2.SetActive(false);
    }

    public void switchToCam2()
    {
        PM.dontMove();
        cam1.SetActive(false);
        cam2.SetActive(true);
    }



}
