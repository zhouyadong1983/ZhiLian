using UnityEngine;
using System.Collections;

public class LookatScipt : MonoBehaviour
{


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

      transform.LookAt(Camera.main.transform,Vector3.up);
    }
}