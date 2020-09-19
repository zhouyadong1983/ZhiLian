using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RecordColliderObjName : MonoBehaviour
{

    public Camera cam;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;

            if (Physics.Raycast(ray, out hitInfo))
            {
                GameObject gameObj = hitInfo.collider.gameObject;


                switch (gameObj.name)
                {
                    case "医疗银医通":
                        StaticString.curruntSelect = "first";
                        SceneManager.LoadScene("三级医疗");
                        break;
                    case "医疗智医":
                        StaticString.curruntSelect = "second";
                        SceneManager.LoadScene("三级医疗");
                        break;
                    case "教育融合":
                        StaticString.curruntSelect = "third";
                        SceneManager.LoadScene("三级医疗");
                        break;

                    case "教育短片":
                        StaticString.curruntSelect = "first";
                        SceneManager.LoadScene("三级教育");
                        break;
                    case "教育场景":
                        StaticString.curruntSelect = "second";
                        SceneManager.LoadScene("三级教育");
                        break;
                    case "教育体验":
                        StaticString.curruntSelect = "third";
                        SceneManager.LoadScene("三级教育");
                        break;

                    case "政法智慧":
                        StaticString.curruntSelect = "first";
                        SceneManager.LoadScene("三级政法");
                        break;
                    case "政法对比":
                        StaticString.curruntSelect = "second";
                        SceneManager.LoadScene("三级政法");
                        break;
                    case "政法资源":
                        StaticString.curruntSelect = "third";
                        SceneManager.LoadScene("三级政法");
                        break;

                    case "民政e线通":
                        StaticString.curruntSelect = "first";
                        SceneManager.LoadScene("三级民政");
                        break;
                    case "民政慈善":
                        StaticString.curruntSelect = "second";
                        SceneManager.LoadScene("三级民政");
                        break;
                    case "民政养老":
                        StaticString.curruntSelect = "third";
                        SceneManager.LoadScene("三级民政");
                        break;
                }
            }
        }

    }



}
