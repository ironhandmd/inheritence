using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttertouse : MonoBehaviour
{
    private bool isDraggingButter;
    private Vector2 initPos;
    panel_controller PC;
    void Start() 
    {
        PC = FindObjectOfType<panel_controller>();
    
    }
    public void OnMouseDown()
    {

        initPos = transform.position;
        isDraggingButter = true;

    }

    public void OnMouseUp()
    {
        snapBack();
        isDraggingButter = false;

    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {



        toymouse SNR = hitInfo.GetComponent<toymouse>();

        if (SNR != null)
        {
            PC.activateButteredMouse();
           
            Destroy(gameObject);
          
           

        }


    }
    



    void Update()
    {
        if (isDraggingButter)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(mousePosition);

        }


    }

    private void snapBack()
    {
        transform.position = initPos;
    }



}
