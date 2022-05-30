using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bottle : MonoBehaviour
{
    [SerializeField]
    GameObject Bottle;
    icon_controller IC;
    inventory Inventory;
    public GameObject itemButton;
    player_movement PM;
    panel_controller PC;

    void Start()
    {
        PM = FindObjectOfType<player_movement>();
        PC = FindObjectOfType<panel_controller>();
        Bottle.SetActive(true);
        IC = FindObjectOfType<icon_controller>();
        Inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<inventory>();
    }


    void OnTriggerEnter2D()
    {
        IC.activateIconBottle();
    }

    void OnTriggerExit2D()
    {
        IC.deactivateIconBottle();
    }

    public void removeBottle()
    {
        Bottle.SetActive(false);
    }


    public void getBottle()
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
        PC.deactivatePanelBottle();
        removeBottle();
    }
}
