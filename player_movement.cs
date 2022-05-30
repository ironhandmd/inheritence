using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    [SerializeField] float movespeed;
    [SerializeField] Rigidbody2D rb;
    Vector2 movement;
    [SerializeField]
    Animator animator;
    [SerializeField]
    GameObject plyer;
    [SerializeField]
    GameObject electrecuted;


    void Start() 
    {
        electrecuted.SetActive(false);
    
    }
    void Update()
    {
        
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");
        animator.SetFloat("horizontal", movement.x);
        animator.SetFloat("vertical", movement.y);
        animator.SetFloat("speed", movement.sqrMagnitude);


    }

    void FixedUpdate() 
    {
        rb.MovePosition(rb.position + movement * movespeed * Time.deltaTime);
    }

    public void playerElectrecuted() 
    {
        electrecuted.SetActive(true);
        plyer.SetActive(false);
    }

    public void dontMove() 
    {
        var m = GetComponent<player_movement>().enabled = false;
    }
    public void nowMove()
    {
        var m = GetComponent<player_movement>().enabled = true;
    }

}
