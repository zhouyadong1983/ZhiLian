using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateRoundSelf : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.RotateAround(transform.position, transform.up, -32 * Time.deltaTime);
    }
}
