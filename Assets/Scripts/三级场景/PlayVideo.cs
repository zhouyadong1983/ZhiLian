using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PlayVideo : MonoBehaviour
{
    private GameObject videoObject;
    private VideoPlayer moviePlayerL;
    private VideoPlayer moviePlayerR;

    private GameObject imageL;
    private GameObject imageR;

    float curruntFrameL;
    float curruntFrameR;
    // Start is called before the first frame update
    void Start()
    {
        imageL = GameObject.Find("Canvas/银医通/ImageL/RawImage");
        imageR = GameObject.Find("Canvas/银医通/ImageR/RawImage");

        moviePlayerL = GameObject.Find("Canvas/银医通/ImageL").transform.GetComponent<VideoPlayer>();
        moviePlayerL.url = "file://" + Application.dataPath + "/StreamingAssets/Video/L.mp4";

        moviePlayerR = GameObject.Find("Canvas/银医通/ImageR").transform.GetComponent<VideoPlayer>();
        moviePlayerR.url = "file://" + Application.dataPath + "/StreamingAssets/Video/R.mp4";
    }

    // Update is called once per frame
    void Update()
    {
        curruntFrameL = moviePlayerL.frame;
        curruntFrameR = moviePlayerR.frame;
        
        if (curruntFrameL >= moviePlayerL.frameCount-1)
        {
            ExitFullScreenLPlayLVideo();
            ExitFullScreenPlayRVideo();

            GameObject.Find("Canvas/银医通/ImageL").SetActive(true);
            GameObject.Find("Canvas/银医通/ImageR").SetActive(true);
            GameObject.Find("Canvas/银医通/ImageR/Button").SetActive(true);
            GameObject.Find("Canvas/银医通/ImageL/Button").SetActive(true);

        }
        if(curruntFrameR >= moviePlayerR.frameCount-1)
        {
            ExitFullScreenLPlayLVideo();
            ExitFullScreenPlayRVideo();

            GameObject.Find("Canvas/银医通/ImageL").SetActive(true);
            GameObject.Find("Canvas/银医通/ImageR").SetActive(true);
            GameObject.Find("Canvas/银医通/ImageR/Button").SetActive(true);
            GameObject.Find("Canvas/银医通/ImageL/Button").SetActive(true);

        }
              
    }

    public void FullScreenLPlayLVideo()
    {
        
        moviePlayerL.enabled = false;
        moviePlayerL.enabled = true;
        moviePlayerL.SetDirectAudioVolume(0,1.0f);
        moviePlayerR.SetDirectAudioVolume(0, 0.0f);

        imageL.transform.GetComponent<RectTransform>().sizeDelta = new Vector2(3840,2160);
        imageL.transform.GetComponent<RectTransform>().position = new Vector3(1920, 1080, 0);
    }

    public void FullScreenPlayRVideo()
    {
        moviePlayerR.enabled = false;
        moviePlayerR.enabled = true;
        moviePlayerR.SetDirectAudioVolume(0, 1.0f);
        moviePlayerL.SetDirectAudioVolume(0, 0.0f);

        imageR.transform.GetComponent<RectTransform>().sizeDelta = new Vector2(3840, 2160);
        imageR.transform.GetComponent<RectTransform>().position = new Vector3(1920, 1080, 0);
    }

    public void ExitFullScreenLPlayLVideo()
    {
        
        moviePlayerL.SetDirectAudioVolume(0, 0.0f);
        moviePlayerR.SetDirectAudioVolume(0, 0.0f);

        imageL.transform.GetComponent<RectTransform>().sizeDelta = new Vector2(1076f, 606.6f);
        imageL.transform.GetComponent<RectTransform>().localPosition = new Vector3(0, -57, 0);
    }

    public void ExitFullScreenPlayRVideo()
    {
        moviePlayerR.SetDirectAudioVolume(0, 0.0f);
        moviePlayerL.SetDirectAudioVolume(0, 0.0f);

        imageR.transform.GetComponent<RectTransform>().sizeDelta = new Vector2(1076f, 606.6f);
        imageR.transform.GetComponent<RectTransform>().localPosition = new Vector3(0, -57, 0);
    }
}
