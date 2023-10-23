using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    [SerializeField] Text scoreText;
    [SerializeField] Text highScoreText;
    private float score;
    private float highScore;

     void Start()
    {
        highScore = PlayerPrefs.GetFloat("HighScore");
    }

    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            score += 1 * Time.deltaTime;
            scoreText.text = ((int)score).ToString();
            highScoreText.text = ((int)highScore).ToString();
        }

        

        if(score > highScore)
        {
            PlayerPrefs.SetFloat("HighScore", score);
        }
        
        
    }

    
    
}
