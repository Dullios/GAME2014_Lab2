using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    //public TMP_Text SceneLabel;
    public TMP_Text LivesLabel;
    public TMP_Text ScoreLabel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (Input.deviceOrientation)
        {
            case DeviceOrientation.Portrait:
                //SceneLabel.text = "Portrait";

                LivesLabel.rectTransform.anchoredPosition = new Vector2(250, -220);
                ScoreLabel.rectTransform.anchoredPosition = new Vector2(-350, -220);
                break;
            case DeviceOrientation.LandscapeLeft:
                //SceneLabel.text = "Landscape Left";

                LivesLabel.rectTransform.anchoredPosition = new Vector2(370, -80);
                ScoreLabel.rectTransform.anchoredPosition = new Vector2(-350, -80);
                break;
            case DeviceOrientation.LandscapeRight:
                //SceneLabel.text = "Landscape Right";

                LivesLabel.rectTransform.anchoredPosition = new Vector2(250, -80);
                ScoreLabel.rectTransform.anchoredPosition = new Vector2(-480, -80);
                break;
            case DeviceOrientation.Unknown:
                //SceneLabel.text = "Unknown";
                break;
        }
    }
}
