using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class butter : MonoBehaviour
{

    [SerializeField]
    GameObject Butter;
    icon_controller IC;
    inventory Inventory;
    public GameObject itemButton;
    player_movement PM;
    panel_controller PC;

    void Start()
    {
        PM = FindObjectOfType<player_movement>();
        PC = FindObjectOfType<panel_controller>();
        Butter.SetActive(true);
        IC = FindObjectOfType<icon_controller>();
        Inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<inventory>();
    }


    void OnTriggerEnter2D()
    {
        IC.activateIconButter();
    }

    void OnTriggerExit2D()
    {
        IC.deactivateIconButter();
    }

    public void removeButter()
    {
        Butter.SetActive(false);
    }


    public void getButter()
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
        PC.deactivateButterPanel();
        removeButter();
    }




}
