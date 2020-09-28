using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageFillAnimation : MonoBehaviour
{
    public Image image;
    public float speed = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        image = transform.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        image.fillAmount += Time.deltaTime * speed;
    }
}
