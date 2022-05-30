using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class final_enemy : MonoBehaviour
{
    scene_manager SceneManager;
    [SerializeField]
    GameObject panel;
    void Start() 
    {
        panel.SetActive(false);
        SceneManager = FindObjectOfType<scene_manager>();
    }



    public void enemyGotHit() 
    {
        StartCoroutine(enemyHitSequence());
      
    }

    IEnumerator enemyHitSequence() 
    {
        panel.SetActive(true);
        yield return new WaitForSeconds(6f);
        SceneManager.LoadEnding3();
    }


}
