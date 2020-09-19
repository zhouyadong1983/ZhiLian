using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public List<Sprite> backgroundList = new List<Sprite>();

    public List<Sprite> yiLiaoList = new List<Sprite>();

    public List<Sprite> minZhengList = new List<Sprite>();

    public List<Sprite> zhengFaList = new List<Sprite>();

    public List<Sprite> jiaoYuList = new List<Sprite>();

    GameObject toggleFather;

    //下方四个单选按钮
    GameObject yiLiao;
    GameObject jiaoYu;
    GameObject zhengFa;
    GameObject minZheng;

    //中间的四个转盘
    GameObject zhuanPanYiLiao;
    GameObject zhuanPanJiaoYu;
    GameObject zhuanPanZhengFa;
    GameObject zhuanPanMinZheng;

    //四个背景
    GameObject beiJingYiLiao;
    GameObject beiJingJiaoYu;
    GameObject beiJingZhengFa;
    GameObject beiJingMinZheng;

    //四个按钮被选中的动画按钮
    GameObject dongHua_Image_YiLiao;
    GameObject dongHua_Image_JiaoYu;
    GameObject dongHua_Image_ZhengFa;
    GameObject dongHua_Image_MinZheng;

    //四个未选中的按钮图片
    GameObject image_YiLiao;
    GameObject image_JiaoYu;
    GameObject image_ZhengFa;
    GameObject image_MinZheng;
    // Start is called before the first frame update
    void Start()
    {
        toggleFather = GameObject.Find("Canvas/下方按钮");
        yiLiao = GameObject.Find("Canvas/下方按钮/医疗");
        jiaoYu = GameObject.Find("Canvas/下方按钮/教育");
        zhengFa = GameObject.Find("Canvas/下方按钮/政法");
        minZheng = GameObject.Find("Canvas/下方按钮/民政");

        zhuanPanYiLiao = GameObject.Find("转盘医疗");
        zhuanPanJiaoYu = GameObject.Find("转盘教育");
        zhuanPanZhengFa = GameObject.Find("转盘政法");
        zhuanPanMinZheng = GameObject.Find("转盘民政");

        beiJingYiLiao = GameObject.Find("Canvas/医疗标题");
        beiJingJiaoYu = GameObject.Find("Canvas/教育标题");
        beiJingZhengFa = GameObject.Find("Canvas/政法标题");
        beiJingMinZheng = GameObject.Find("Canvas/民政标题");

        dongHua_Image_YiLiao = GameObject.Find("Canvas/下方按钮/医疗/六边形");
        dongHua_Image_JiaoYu = GameObject.Find("Canvas/下方按钮/教育/六边形");
        dongHua_Image_ZhengFa = GameObject.Find("Canvas/下方按钮/政法/六边形");
        dongHua_Image_MinZheng = GameObject.Find("Canvas/下方按钮/民政/六边形");

        image_YiLiao = GameObject.Find("Canvas/下方按钮/医疗/Background");
        image_JiaoYu = GameObject.Find("Canvas/下方按钮/教育/Background");
        image_ZhengFa = GameObject.Find("Canvas/下方按钮/政法/Background");
        image_MinZheng = GameObject.Find("Canvas/下方按钮/民政/Background");

        toggleFather.transform.GetComponent<ToggleGroup>().allowSwitchOff = true;

        switch (StaticString.curruntScene)
        {
            case "医疗":
                //设置医疗按钮为选中状态，其余三个按钮为未选中状态
                minZheng.transform.GetComponent<Toggle>().isOn = false;
                zhengFa.transform.GetComponent<Toggle>().isOn = false;
                jiaoYu.transform.GetComponent<Toggle>().isOn = false;
                yiLiao.transform.GetComponent<Toggle>().isOn = true;
                //设置背景中医疗面板可见，其余面板不可见
                zhuanPanYiLiao.SetActive(true);
                zhuanPanJiaoYu.SetActive(false);
                zhuanPanZhengFa.SetActive(false);
                zhuanPanMinZheng.SetActive(false);
                //设置医疗背景可见，其余背景不可见
                beiJingYiLiao.SetActive(true);
                beiJingJiaoYu.SetActive(false);
                beiJingZhengFa.SetActive(false);
                beiJingMinZheng.SetActive(false);
                //设置医疗动画按钮可见，其余动画按钮不可见
                dongHua_Image_YiLiao.SetActive(true);
                dongHua_Image_JiaoYu.SetActive(false);
                dongHua_Image_ZhengFa.SetActive(false);
                dongHua_Image_MinZheng.SetActive(false);
                //医疗按钮未选中状态下的图片不可见
                image_YiLiao.transform.GetComponent<Image>().enabled = false;
                image_JiaoYu.transform.GetComponent<Image>().enabled = true;
                image_ZhengFa.transform.GetComponent<Image>().enabled = true;
                image_MinZheng.transform.GetComponent<Image>().enabled = true;
                break;

            case "教育":
                minZheng.transform.GetComponent<Toggle>().isOn = false;
                zhengFa.transform.GetComponent<Toggle>().isOn = false;
                jiaoYu.transform.GetComponent<Toggle>().isOn = true;
                yiLiao.transform.GetComponent<Toggle>().isOn = false;

                zhuanPanYiLiao.SetActive(false);
                zhuanPanJiaoYu.SetActive(true);
                zhuanPanZhengFa.SetActive(false);
                zhuanPanMinZheng.SetActive(false);


                beiJingYiLiao.SetActive(false);
                beiJingJiaoYu.SetActive(true);
                beiJingZhengFa.SetActive(false);
                beiJingMinZheng.SetActive(false);

                dongHua_Image_YiLiao.SetActive(false);
                dongHua_Image_JiaoYu.SetActive(true);
                dongHua_Image_ZhengFa.SetActive(false);
                dongHua_Image_MinZheng.SetActive(false);

                image_YiLiao.transform.GetComponent<Image>().enabled = true;
                image_JiaoYu.transform.GetComponent<Image>().enabled = false;
                image_ZhengFa.transform.GetComponent<Image>().enabled = true;
                image_MinZheng.transform.GetComponent<Image>().enabled = true;
                break;

            case "政法":
                minZheng.transform.GetComponent<Toggle>().isOn = false;
                zhengFa.transform.GetComponent<Toggle>().isOn = true;
                jiaoYu.transform.GetComponent<Toggle>().isOn = false;
                yiLiao.transform.GetComponent<Toggle>().isOn = false;

                zhuanPanYiLiao.SetActive(false);
                zhuanPanJiaoYu.SetActive(false);
                zhuanPanZhengFa.SetActive(true);
                zhuanPanMinZheng.SetActive(false);


                beiJingJiaoYu.SetActive(false);
                beiJingYiLiao.SetActive(false);
                beiJingZhengFa.SetActive(true);
                beiJingMinZheng.SetActive(false);

                dongHua_Image_YiLiao.SetActive(false);
                dongHua_Image_JiaoYu.SetActive(false);
                dongHua_Image_ZhengFa.SetActive(true);
                dongHua_Image_MinZheng.SetActive(false);

                image_YiLiao.transform.GetComponent<Image>().enabled = true;
                image_JiaoYu.transform.GetComponent<Image>().enabled = true;
                image_ZhengFa.transform.GetComponent<Image>().enabled = false;
                image_MinZheng.transform.GetComponent<Image>().enabled = true;
                break;

            case "民政":
                minZheng.transform.GetComponent<Toggle>().isOn = true;
                zhengFa.transform.GetComponent<Toggle>().isOn = false;
                jiaoYu.transform.GetComponent<Toggle>().isOn = false;
                yiLiao.transform.GetComponent<Toggle>().isOn = false;

                zhuanPanYiLiao.SetActive(false);
                zhuanPanJiaoYu.SetActive(false);
                zhuanPanZhengFa.SetActive(false);
                zhuanPanMinZheng.SetActive(true);


                beiJingJiaoYu.SetActive(false);
                beiJingYiLiao.SetActive(false);
                beiJingZhengFa.SetActive(false);
                beiJingMinZheng.SetActive(true);

                dongHua_Image_YiLiao.SetActive(false);
                dongHua_Image_JiaoYu.SetActive(false);
                dongHua_Image_ZhengFa.SetActive(false);
                dongHua_Image_MinZheng.SetActive(true);

                image_YiLiao.transform.GetComponent<Image>().enabled = true;
                image_JiaoYu.transform.GetComponent<Image>().enabled = true;
                image_ZhengFa.transform.GetComponent<Image>().enabled = true;
                image_MinZheng.transform.GetComponent<Image>().enabled = false;
                break;
        }

        toggleFather.transform.GetComponent<ToggleGroup>().allowSwitchOff = false;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
