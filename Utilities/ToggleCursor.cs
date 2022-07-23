using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleCursor : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.C))
        {
            Cursor.visible = !Cursor.visible;
        }
    }
}