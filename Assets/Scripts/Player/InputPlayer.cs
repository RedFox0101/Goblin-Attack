using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputPlayer :MonoBehaviour, IInput
{
    public Vector2 GetDirection()
    {
        return new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }   

    public bool GetMouseInput()
    {
        if (Input.GetMouseButton(0))
        {
            return true;
        }
        return false;
    }
}
