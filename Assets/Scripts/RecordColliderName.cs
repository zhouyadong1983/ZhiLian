using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RecordColliderName : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;

            if (Physics.Raycast(ray, out hitInfo))
            {
                GameObject gameObj = hitInfo.collider.gameObject;
                StaticString.curruntScene = gameObj.name;
                

                switch (StaticString.curruntScene)
                {
                    case "医疗":
                        SceneManager.LoadScene("二级页面");
                        break;
                    case "教育":
                        SceneManager.LoadScene("二级页面");
                        break;
                    case "政法":
                        SceneManager.LoadScene("二级页面");
                        break;
                    case "民政":
                        SceneManager.LoadScene("二级页面");
                        break;
                }
            }
        }

    }



}
