using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chest : MonoBehaviour
{
    inventory Inventory;
    public GameObject itemButton;
    icon_controller IC;
    [SerializeField] SpriteRenderer spriteRenderer;
    [SerializeField] Sprite newsprite;
    [SerializeField]
    GameObject icon;
    [SerializeField]
    Collider2D col;
    panel_controller PC;
    // Start is called before the first frame update
    void Start()
    {
        icon.SetActive(false);
        PC = FindObjectOfType<panel_controller>();
        var col = GetComponent<Collider2D>().enabled = true;
        Inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<inventory>();
        IC = FindObjectOfType<icon_controller>();
    }
    public void changeOpen()
{
        spriteRenderer.sprite=newsprite;

}
    void OnTriggerEnter2D() 
    {
        icon.SetActive(true);
    }

    void OnTriggerExit2D()
    {
        icon.SetActive(false);
    }

    public void openTheChest()
    {
        PC.deactivatePanelOpenChest();
        changeOpen();
     for (int i = 0; i < Inventory.slots.Length; i++)
        {
            if (Inventory.isFull[i] == false)
            {
                Inventory.isFull[i] = true;
                Instantiate(itemButton, Inventory.slots[i].transform, false);
                var col = GetComponent<Collider2D>().enabled = false;
                break;

            }
        }
      //  PM.nowMove();
     
     Destroy(icon);
    }
    
    }








