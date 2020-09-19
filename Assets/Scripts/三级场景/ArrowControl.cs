using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// 控制页面中间图片和下放单选按钮变化
/// </summary>
public class ArrowControl : MonoBehaviour
{
    int counter = 0;

    //public List<GameObject> bgList = new List<GameObject>();

    //public List<GameObject> toggleList = new List<GameObject>();

    GameObject bgFst;
    GameObject bgScd;
    GameObject bgThd;

    GameObject bgScdSon;

    GameObject toggleFst;
    GameObject toggleScd;
    GameObject toggleThd;

    GameObject hexagonFst;
    GameObject hexagonScd;
    GameObject hexagonThd;

    // Start is called before the first frame update
    void Start()
    {
        //为每个面板初始化，默认设置第一个“银医通”面板可见
        bgFst = GameObject.Find("Canvas/银医通");
        bgScdSon = GameObject.Find("Canvas/智医/智医展开");
        bgScdSon.SetActive(false);
        bgScd = GameObject.Find("Canvas/智医");
        bgScd.SetActive(false);
        bgThd = GameObject.Find("Canvas/融合");
        bgThd.SetActive(false);
        //单选按钮
        toggleFst = GameObject.Find("Canvas/下方单选按钮/ToggleFst");
        toggleScd = GameObject.Find("Canvas/下方单选按钮/ToggleScd");
        toggleThd = GameObject.Find("Canvas/下方单选按钮/ToggleThd");
        //每一个单选按钮的六边形
        hexagonFst = GameObject.Find("Canvas/下方单选按钮/ToggleFst/正六边形");
        hexagonScd = GameObject.Find("Canvas/下方单选按钮/ToggleScd/正六边形"); ;
        hexagonThd = GameObject.Find("Canvas/下方单选按钮/ToggleThd/正六边形"); ;

        //根据二级界面的选择，控制当前场景需要显示的界面
        switch (StaticString.curruntSelect)
        {
            case "first":
                counter = 0;
                UIControl();
                break;
            case "second":
                counter = 1;
                UIControl();
                break;
            case "third":
                counter = 2;
                UIControl();
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //点击向右箭头调用此函数
    public void Add()
    {
        counter++;
        if(counter == 3)
            {
            counter = 0;
        }
    }

    //点击向左箭头调用此函数
    public void Subtract()
    {
        counter--;
        if (counter == -1)
        {
            counter = 2;
        }
    }

    //点击第一个单选按钮调用此函数
    public void FstToggle()
    {
        counter = 0;
    }
    //点击第二个单选按钮调用此函数
    public void ScdToggle()
    {
        counter = 1;
    }
    //点击第三个单选按钮调用此函数
    public void ThdToggle()
    {
        counter = 2;
    }


    //点击单选按钮和左右箭头都会调用此函数
    public void UIControl()
    {
        switch(counter)
        {
            //第一个面板被选中
            case 0:
                //显隐背景
                bgFst.SetActive(true);
                bgScd.SetActive(false);
                bgThd.SetActive(false);

                bgScdSon.SetActive(false);

                //设置单选框的选中状态
                toggleFst.transform.GetComponent<Toggle>().isOn = true;
                toggleScd.transform.GetComponent<Toggle>().isOn = false;
                toggleThd.transform.GetComponent<Toggle>().isOn = false;

                //控制单选框六边形显隐
                hexagonFst.SetActive(true);
                hexagonScd.SetActive(false);
                hexagonThd.SetActive(false);
                break;

            //第二个面板被选中
            case 1:
                bgFst.SetActive(false);
                bgScd.SetActive(true);
                bgThd.SetActive(false);

                bgScdSon.SetActive(false);

                toggleFst.transform.GetComponent<Toggle>().isOn = false;
                toggleScd.transform.GetComponent<Toggle>().isOn = true; 
                toggleThd.transform.GetComponent<Toggle>().isOn = false;

                hexagonFst.SetActive(false);
                hexagonScd.SetActive(true);
                hexagonThd.SetActive(false);
                break;

            //第三个面板被选中
            case 2:
                bgFst.SetActive(false);
                bgScd.SetActive(false);
                bgThd.SetActive(true);

                bgScdSon.SetActive(false);

                toggleFst.transform.GetComponent<Toggle>().isOn = false;
                toggleScd.transform.GetComponent<Toggle>().isOn = false;
                toggleThd.transform.GetComponent<Toggle>().isOn = true;

                hexagonFst.SetActive(false);
                hexagonScd.SetActive(false);
                hexagonThd.SetActive(true);
                break;
        }
    }

}
