using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class event_manager : MonoBehaviour
{
    [SerializeField]
    GameObject lawyer;
    panel_controller PC;
    [SerializeField]
    GameObject playerActive;
    [SerializeField]
    GameObject playerFaceLeft;
    [SerializeField]
    GameObject codex;
    [SerializeField]
    GameObject thugObj;
    player_movement PM;
    thug Thug;
    [SerializeField]
    GameObject catacombs;
    
    void Start() 



        
    {
        PM = FindObjectOfType<player_movement>();
        Thug = FindObjectOfType<thug>();
        thugObj.SetActive(false);
        playerActive.SetActive(true);
        playerFaceLeft.SetActive(false);
        PC = FindObjectOfType<panel_controller>();
        lawyer.SetActive(false);
        codex.SetActive(true);
        catacombs.SetActive(false);
    
    }


    public void activateScene() 
    {
        PC.deactivatePanelCdx();
        lawyer.SetActive(true);
        PC.activateLawyerTalk();
        playerActive.SetActive(false);
        playerFaceLeft.SetActive(true);
        StartCoroutine(prisonerScene());
        catacombs.SetActive(true);
    
    }

    IEnumerator prisonerScene()
    {
        yield return new WaitForSeconds(2f);
        lawyer.SetActive(false);
        playerFaceLeft.SetActive(false);
        PC.deactivateLawyerTalk();
        codex.SetActive(false);
        playerActive.SetActive(true);
        PM.nowMove();
        thugObj.SetActive(true);
        
        Thug.swallowSnakeMan();
        
        yield return new WaitForSeconds(10f);
        PC.activateManSwallowed();
        thugObj.SetActive(false);
        yield return new WaitForSeconds(3f);
        PC.deactivateManSwallowed();
     
        
        
    }




}

   
  
   
     

      

      

