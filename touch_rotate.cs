using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touch_rotate : MonoBehaviour
{

    private void OnMouseDown()
    {
        if (!puzzle_controller.youWin)
        {
            transform.Rotate(0f, 0f, 90f);

        }

    }
}
