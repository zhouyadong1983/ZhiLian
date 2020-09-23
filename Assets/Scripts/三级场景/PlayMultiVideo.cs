using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PlayMultiVideo : MonoBehaviour
{
    private VideoPlayer multiVideoPlayer;
    private VideoPlayer introduceVideoPlayer;
    // Start is called before the first frame update
    void Start()
    {
        multiVideoPlayer = GameObject.Find("Canvas/MultiVideo").transform.GetComponent<VideoPlayer>();
        introduceVideoPlayer = GameObject.Find("Canvas/IntroduceVideo").transform.GetComponent<VideoPlayer>();
        multiVideoPlayer.url = "file://" + Application.dataPath + "/StreamingAssets/Video/三码融合.mp4";
        introduceVideoPlayer.url = "file://" + Application.dataPath + "/StreamingAssets/Video/三码融合简介.mp4";

        GameObject.Find("Canvas/MultiVideo").SetActive(false);
        GameObject.Find("Canvas/IntroduceVideo").SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
