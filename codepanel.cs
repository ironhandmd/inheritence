using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
public class codepanel : MonoBehaviour
{
    safe_controller safeController;
    [SerializeField]
    Text codeText;
    string codeTextValue = "";
    panel_controller PC;
    iconsafe Iconsafe;
    inventory Inventory;
    public GameObject itemButton;
    safe Safe;

    void Start()
    {
        Safe = FindObjectOfType<safe>();
        Inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<inventory>();
        Iconsafe = FindObjectOfType<iconsafe>();

        PC = FindObjectOfType<panel_controller>();
    }

    void Update()
    {
        codeText.text = codeTextValue;

        if (codeTextValue == "3184")
        {
          //  safeController = FindObjectOfType<safe_controller>();
          //  safeController.openTheSafe();
            Iconsafe.safeOut();
            safeOpened();
            
        }
        if (codeTextValue.Length >= 4)
        {
            codeTextValue = "";

        }

    }
    public void AddDigit(string digit)
    {
        codeTextValue += digit;

    }

    public void safeOpened() 
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
     //   PM.nowMove();
     //   PC.deactivatePanelPprWill();
     //   removeWill();
        Safe.removeCol();



        PC.activateOpenedSafe();
      
    
    }



}
