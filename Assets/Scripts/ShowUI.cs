using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowUI : MonoBehaviour
{

    public Camera cam;

    public Image yiLiao;
    public Image zhengFa;
    public Image jiaoYu;
    public Image minZheng;

    public GameObject yiLiaoOBJ;
    public GameObject zhengFaOBJ;
    public GameObject jiaoYuOBJ;
    public GameObject minZhengOBJ;

    Vector3 offset = new Vector3(0,50,0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        yiLiao.transform.position = cam.WorldToScreenPoint(yiLiaoOBJ.transform.position)+ offset;
        zhengFa.transform.position = cam.WorldToScreenPoint(zhengFaOBJ.transform.position)+ offset;
        jiaoYu.transform.position = cam.WorldToScreenPoint(jiaoYuOBJ.transform.position)+ offset;
        minZheng.transform.position = cam.WorldToScreenPoint(minZhengOBJ.transform.position)+ offset;

    }
}
