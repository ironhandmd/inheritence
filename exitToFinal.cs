using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitToFinal : MonoBehaviour
{
    [SerializeField]
    Transform warpTarget;
    camera_movement CM;
    events_controller_ending2 evc2;
    void Start()
    {
        evc2 = FindObjectOfType<events_controller_ending2>();
        CM = FindObjectOfType<camera_movement>();
    }




    void OnTriggerEnter2D(Collider2D other)
    {
        CM.moveToFinal();
        other.gameObject.transform.position = warpTarget.transform.position;
        evc2.startEnemyTalk();
    }
}
