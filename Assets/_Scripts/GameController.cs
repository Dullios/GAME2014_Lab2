using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    //public TMP_Text SceneLabel;
    public TMP_Text LivesLabel;
    public TMP_Text ScoreLabel;

    private bool hasSafeArea;

    // Start is called before the first frame update
    void Start()
    {
        hasSafeArea = (Screen.width == Screen.safeArea.width && Screen.height == Screen.safeArea.height) ? false : true;
    }

    // Update is called once per frame
    void Update()
    {
        // Setup with Samsung Galaxy S10+ spacing
        switch (Screen.orientation)
        {
            case ScreenOrientation.Portrait:
                //SceneLabel.text = "Portrait";

                if (hasSafeArea)
                {
                    LivesLabel.rectTransform.anchoredPosition = new Vector2(250, -200);
                    ScoreLabel.rectTransform.anchoredPosition = new Vector2(-350, -200);
                }
                else
                {
                    LivesLabel.rectTransform.anchoredPosition = new Vector2(250, -80);
                    ScoreLabel.rectTransform.anchoredPosition = new Vector2(-350, -80);
                }
                break;
            case ScreenOrientation.LandscapeLeft:
                //SceneLabel.text = "Landscape Left";

                if (hasSafeArea)
                {
                    LivesLabel.rectTransform.anchoredPosition = new Vector2(370, -80);
                    ScoreLabel.rectTransform.anchoredPosition = new Vector2(-350, -80);
                }
                else
                {
                    LivesLabel.rectTransform.anchoredPosition = new Vector2(250, -80);
                    ScoreLabel.rectTransform.anchoredPosition = new Vector2(-350, -80);
                }
                break;
            case ScreenOrientation.LandscapeRight:
                //SceneLabel.text = "Landscape Right";

                if (hasSafeArea)
                {
                    LivesLabel.rectTransform.anchoredPosition = new Vector2(250, -80);
                    ScoreLabel.rectTransform.anchoredPosition = new Vector2(-480, -80);
                }
                else
                {
                    LivesLabel.rectTransform.anchoredPosition = new Vector2(250, -80);
                    ScoreLabel.rectTransform.anchoredPosition = new Vector2(-350, -80);
                }
                break;
        }
    }
}
