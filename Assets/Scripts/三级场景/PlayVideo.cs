using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PlayVideo : MonoBehaviour
{
    private GameObject videoObject;
    private VideoPlayer moviePlayerL;
    private VideoPlayer moviePlayerR;
    // Start is called before the first frame update
    void Start()
    {
        moviePlayerL = GameObject.Find("Canvas/银医通/ImageL").transform.GetComponent<VideoPlayer>();
        moviePlayerL.url = "file://"+Application.dataPath+ "/StreamingAssets/Video/L.mp4";

        moviePlayerR = GameObject.Find("Canvas/银医通/ImageR").transform.GetComponent<VideoPlayer>();
        moviePlayerR.url = "file://" + Application.dataPath + "/StreamingAssets/Video/R.mp4";
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void  PlayLVideo()
    {
        moviePlayerL.Play();
    }
    public void PlayRVideo()
    {
        moviePlayerR.Play();
    }
}
