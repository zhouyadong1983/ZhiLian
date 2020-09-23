using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayPic : MonoBehaviour
{
    public List<Sprite> picList = new List<Sprite>();
    int i = 1;
    public GameObject image;
    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("ChangePic", 5, 5);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ChangePic()
    {
        image.transform.GetComponent<Image>().sprite = picList[i];

        i++;

        if(i==5)
        {
            i = 0;
        }
    }

    public void Cancel()
    {
        CancelInvoke();
        image.transform.GetComponent<Image>().sprite = picList[0];
    }

    public void go()
    {
        InvokeRepeating("ChangePic", 5, 5);
    }

}
