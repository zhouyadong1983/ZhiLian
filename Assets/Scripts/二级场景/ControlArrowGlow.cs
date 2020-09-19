using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// 按下鼠标左键左右拖动时根据拖动方向，让左或者右箭头高亮
/// </summary>

public class ControlArrowGlow : MonoBehaviour
{
    private float mousePosX;
    private float mouseCurruntPosX;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mouseCurruntPosX = Input.GetAxis("Mouse X");

        if (Input.GetMouseButtonDown(0))
        {
            mousePosX = Input.GetAxis("Mouse X");
        }

        //按下左键向左右拖动时闪烁对应图标
        if(Input.GetMouseButton(0))
        {
            if (mouseCurruntPosX > mousePosX)
            {

                GameObject.Find("Canvas/左旋图标").transform.GetComponent<Image>().color = new Color(1, 1, 1);
                GameObject.Find("Canvas/左旋图标").transform.GetComponent<Animator>().enabled = false;
                GameObject.Find("Canvas/右旋图标").transform.GetComponent<Animator>().enabled = true;
            }
            if (mouseCurruntPosX < mousePosX)
            {
                GameObject.Find("Canvas/右旋图标").transform.GetComponent<Image>().color = new Color(1, 1, 1);
                GameObject.Find("Canvas/左旋图标").transform.GetComponent<Animator>().enabled = true;
                GameObject.Find("Canvas/右旋图标").transform.GetComponent<Animator>().enabled = false;
            }
        }

        //抬起左键时停止闪烁
        if(Input.GetMouseButtonUp(0))
        {

            GameObject.Find("Canvas/左旋图标").transform.GetComponent<Animator>().enabled = false;
            GameObject.Find("Canvas/右旋图标").transform.GetComponent<Animator>().enabled = false;
            GameObject.Find("Canvas/左旋图标").transform.GetComponent<Image>().color = new Color(1, 1, 1);
            GameObject.Find("Canvas/右旋图标").transform.GetComponent<Image>().color = new Color(1, 1, 1);
        }
    }
}
