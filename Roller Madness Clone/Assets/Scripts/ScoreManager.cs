using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateScoreText();   // scoretext fonksiyonunu �a��rd�k
    }
    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();  // score verisini textin i�ine atad�k.
    }
}
