using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventory_slot : MonoBehaviour
{
    private inventory Inventory;
    public int i;
    private void Start()
    {
        Inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<inventory>();
    }

    private void Update()
    {
        if (transform.childCount <= 0)
        {
            Inventory.isFull[i] = false;

        }
    }
}
