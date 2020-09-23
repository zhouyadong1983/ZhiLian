using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickCounter : MonoBehaviour
{
    private int counter;

    public GameObject image;

    private bool isGo;
    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        isGo = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (counter == 2& isGo == true)
        {
            Debug.Log("counter ==2");
            image.transform.GetComponent<PlayPic>().enabled = true;
            image.transform.GetComponent<PlayPic>().go();
            isGo = false;
        }
        else if(counter !=2)
        {
            Debug.Log("conter!=2");
            image.transform.GetComponent<PlayPic>().Cancel();
            image.transform.GetComponent<PlayPic>().enabled = false;
            
        }
        if(counter !=2)
        {
            isGo = true;
        }
    }
    public void add()
    {
        counter++;
        if(counter == 3)
        {
            counter = 0;
        }
    }
    public void sub()
    {
        counter--;
        if(counter == -1)
        {
            counter = 2;
        }
    }

    public void First()
    {
        counter = 0;
    }
    public void Second()
    {
        counter = 1;
    }
    public void Third()
    {
        counter = 2;
    }

}
