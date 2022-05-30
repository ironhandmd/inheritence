using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class events_controller_ending1 : MonoBehaviour
{
    [SerializeField]
    GameObject dialog1, dialog2, dialog3, dialog4;
    scene_manager SceneManager;
  

    void Start() 
    {
       
        
        SceneManager = FindObjectOfType<scene_manager>();
        dialog1.SetActive(false);
        dialog2.SetActive(false);
        dialog3.SetActive(false);
        dialog4.SetActive(false);
        StartCoroutine(dialogSequence());
   
    
    }

    IEnumerator dialogSequence() 
    {
        
        yield return new WaitForSeconds(4f);
        dialog1.SetActive(true);
        yield return new WaitForSeconds(4f);
        dialog1.SetActive(false);
        dialog2.SetActive(true);
        yield return new WaitForSeconds(4f);
        dialog2.SetActive(false);
        dialog3.SetActive(true);
        yield return new WaitForSeconds(4f);
        dialog3.SetActive(false);
        dialog4.SetActive(true);
        yield return new WaitForSeconds(5f);
        dialog4.SetActive(false);
        SceneManager.LoadNextScene();
    }




}
