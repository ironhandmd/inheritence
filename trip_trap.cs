using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trip_trap : MonoBehaviour
{

    scene_manager SceneManager;

    void OnTriggerEnter2D(Collider2D hitInfo)
    {



        player_movement PlayerMovement = hitInfo.GetComponent<player_movement>();

        if (PlayerMovement != null)
        {
            PlayerMovement.playerElectrecuted();
            StartCoroutine(electrecutedEnding());

        }





    }

    IEnumerator electrecutedEnding() 
   {
        yield return new WaitForSeconds(2f);
        SceneManager = FindObjectOfType<scene_manager>();
        SceneManager.LoadElectrecute();
    }



}
