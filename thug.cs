using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thug : MonoBehaviour
{

    [SerializeField]
    Animator anim;



    void Start() 
    {
       
        
    }

    public void swallowSnakeMan() 
    {

        StartCoroutine(swallowSnake());
    }

    IEnumerator swallowSnake() 
    {
        yield return new WaitForSeconds(2f);
        anim.SetBool("swallow", true);
        
    }

}
