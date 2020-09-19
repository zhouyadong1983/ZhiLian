using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breath : MonoBehaviour
{

    //public List<GameObject> list_BreathOBJ = new List<GameObject>();

    float value = 0.5f;

    bool isOne = false;

    float speed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //foreach(GameObject obj in list_BreathOBJ)
        //{
        if(!isOne)
            {

            value += Time.deltaTime * speed;

            transform.GetComponent<MeshRenderer>().materials[0].SetFloat("_AlphaScale", value); 

            if(value>=1)
            {
                isOne = true;
            }
        }

        else
            {

            value -= Time.deltaTime * speed;

            transform.GetComponent<MeshRenderer>().materials[0].SetFloat("_AlphaScale", value);

            if (value<=0.5)

            {
                isOne = false;

            }
        }
       // }
    }


}
