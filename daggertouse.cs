using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class daggertouse : MonoBehaviour
{
  
    private bool isDraggingDagger;
    private Vector2 initPos;
    orbtarget OrbTarget;
    [SerializeField]
    Collider2D col;

    void Start()
    {
        var col = GetComponent<Collider2D>().enabled = true;
        OrbTarget = FindObjectOfType<orbtarget>();
    }
    public void OnMouseDown()
    {

        initPos = transform.position;
        isDraggingDagger = true;

    }

    public void OnMouseUp()
    {

        isDraggingDagger = false;
        snapBack();
    }

 //   private void OnTriggerEnter2D(Collider2D other)  // rigidbody 2d as static, collider 2d as trigger
    // chest rigidbody 2d as kinematic collider 2d as trigger
  //  {

  //      if (other.gameObject == crystal)
  //      {
   //         Destroy(other.gameObject);
   //         Destroy(gameObject);
    //    }
  //  }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {



        orbtarget OrbTG = hitInfo.GetComponent<orbtarget>();

        if (OrbTG != null)
        {
            OrbTarget.orbHit();
            Destroy(gameObject);

        }

        final_enemy FinalEnemy = hitInfo.GetComponent<final_enemy>();

        if (FinalEnemy != null)
        {
            FinalEnemy.enemyGotHit();
            Destroy(gameObject);

        }

        

    }



    void Update()
    {
        if (isDraggingDagger)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(mousePosition);

        }


    }
    void snapBack()
    {
        transform.position = initPos;

    }

    public void disableDagger() 
    {
        var col = GetComponent<Collider2D>().enabled = false;
    }
    public void enableDagger()
    {
        var col = GetComponent<Collider2D>().enabled = true;
    }
}
