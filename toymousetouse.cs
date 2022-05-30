using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toymousetouse : MonoBehaviour
{
    
    private bool isDraggingToyMouse;
    private Vector2 initPos;
    panel_controller PC;

    void Start() 
    {
       
        PC = FindObjectOfType<panel_controller>();
    }
    public void OnMouseDown()
    {

        initPos = transform.position;
        isDraggingToyMouse = true;

    }

    public void OnMouseUp()
    {
        snapBack();
        isDraggingToyMouse = false;

    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {



        snake Snake = hitInfo.GetComponent<snake>();

        if (Snake != null)
        {
            PC.activatePanelFedSnake();
            Snake.feedSnake();
            Destroy(gameObject);
            

        }


    }






    void Update()
    {
        if (isDraggingToyMouse)
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
