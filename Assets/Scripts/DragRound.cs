using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragRound : MonoBehaviour
{
    public List<Transform> trasfList = new List<Transform>();
   

    public float speed = 20;

    private bool _mouseDown = false;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            _mouseDown = true;
        else if (Input.GetMouseButtonUp(0))
            _mouseDown = false;

        if (_mouseDown)
        {
            float fMouseX = Input.GetAxis("Mouse X");
            //float fMouseY = Input.GetAxis("Mouse Y");
            for(int i = 0;i<trasfList.Count;i++)
            {
                trasfList[i].Rotate(Vector3.up, -fMouseX * speed, Space.World);
            }
            //obj.Rotate(Vector3.right, fMouseY * speed, Space.World);
        }
    }
}