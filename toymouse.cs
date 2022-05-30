using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toymouse : MonoBehaviour
{
    icon_controller IC;
    inventory Inventory;
    public GameObject itemButton;
    panel_controller PC;
    player_movement PM;
    [SerializeField]
    GameObject tmouse;
    
    void Start()
    {
        PM = FindObjectOfType<player_movement>();
        PC = FindObjectOfType<panel_controller>();
        Inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<inventory>();
        IC = FindObjectOfType<icon_controller>();
        tmouse.SetActive(true);
    }


 //   void OnTriggerEnter2D() 
  //  {
 //       IC.activateIconToyMouse();
  //  }

 //   void OnTriggerExit2D()
 //   {
 //       IC.deactivateIconToyMouse();
 //   }

    public void getToyMouse() 
    
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
      
       
        PM.nowMove();
        PC.deactivateButteredMouse();
    }

    public void applyButter() 
    {
     //   IC.deactivateIconToyMouse();
        
        tmouse.SetActive(false);
      
    }



}
