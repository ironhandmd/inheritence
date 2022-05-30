using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eventcontrol_intro : MonoBehaviour
{
    [SerializeField]
    GameObject panel1,panel2,panel3;
    scene_manager SceneManager;
    void Start()
    {
        SceneManager = FindObjectOfType<scene_manager>();
        panel1.SetActive(false);
        panel2.SetActive(false);
        panel3.SetActive(false);
        StartCoroutine(startConvo());
    
    
    }


    IEnumerator startConvo() 
    {
        yield return new WaitForSeconds(1f);
        panel1.SetActive(true);
        yield return new WaitForSeconds(4f);
        panel1.SetActive(false);
        panel2.SetActive(true);
        yield return new WaitForSeconds(4f);
        panel2.SetActive(false);
        panel3.SetActive(true);
        yield return new WaitForSeconds(4f);
        SceneManager.LoadNextScene();
    }



}
