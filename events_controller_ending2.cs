using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class events_controller_ending2 : MonoBehaviour
{
    [SerializeField] GameObject beginDialogue,dialogue2,dialogue3;
    player_movement PM;
   
    void Start()
    {
        
      
        PM = FindObjectOfType<player_movement>();
        beginDialogue.SetActive(false);
        dialogue2.SetActive(false);
        dialogue3.SetActive(false);
       

    }

    public void startEnemyTalk()
    
    {
      
        PM.dontMove();
        StartCoroutine(dialogueSequence());
    }
    IEnumerator dialogueSequence() 
    {

        yield return new WaitForSeconds(3f);
        beginDialogue.SetActive(true);
        yield return new WaitForSeconds(3f);
        beginDialogue.SetActive(false);
        dialogue2.SetActive(true);
        yield return new WaitForSeconds(3f);
        dialogue2.SetActive(false);
        dialogue3.SetActive(true);
        yield return new WaitForSeconds(3f);
        dialogue3.SetActive(false);
        PM.nowMove();
       
    }



}
