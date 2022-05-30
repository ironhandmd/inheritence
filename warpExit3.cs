using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class warpExit3 : MonoBehaviour
{
    [SerializeField]
    Transform warpTarget;
    camera_movement CM;

    void Start()
    {
        CM = FindObjectOfType<camera_movement>();
    }




    void OnTriggerEnter2D(Collider2D other)
    {
        CM.moveToArea3();
        other.gameObject.transform.position = warpTarget.transform.position;
    }
}
