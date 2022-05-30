using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzle_controller : MonoBehaviour
{
    [SerializeField] private Transform[] pictures;
    camswitcher CamSwitcher;
    public static bool youWin;
    inventory Inventory;
    public GameObject itemButton;

    void Start()
    {
        Inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<inventory>();
        CamSwitcher = FindObjectOfType<camswitcher>();
        youWin = false;

    }

    void Update()
    {
        if (pictures[0].rotation.z == 0 &&
            pictures[1].rotation.z == 0 &&
            pictures[2].rotation.z == 0 &&
            pictures[3].rotation.z == 0 &&
            pictures[4].rotation.z == 0 &&
            pictures[5].rotation.z == 0 &&
            pictures[6].rotation.z == 0 &&
            pictures[7].rotation.z == 0 &&
            pictures[8].rotation.z == 0 &&
             pictures[9].rotation.z == 0 &&
             pictures[10].rotation.z == 0 &&
             pictures[11].rotation.z == 0 &&
             pictures[12].rotation.z == 0 &&
             pictures[13].rotation.z == 0 &&
             pictures[14].rotation.z == 0 &&
             pictures[15].rotation.z == 0 
            
            )
        
        {
            youWin = true;
            StartCoroutine(waitBeforeShow());
            

        }
    }

    IEnumerator waitBeforeShow() 
    {
        yield return new WaitForSeconds(2);
        Debug.Log("solved");
        yield return new WaitForSeconds(2);
        CamSwitcher.switchToCam1();
        keyAppears();


    }
    public void keyAppears() 
    {
     for (int i = 0; i < Inventory.slots.Length; i++)
        {
            if (Inventory.isFull[i] == false)
            {
                Inventory.isFull[i] = true;
                Instantiate(itemButton, Inventory.slots[i].transform, false);
                Destroy(gameObject);
                break;

            }
        }
     
      
     
    }
    
    
    }






