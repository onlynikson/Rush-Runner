using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOver : MonoBehaviour
{

    [SerializeField] private GameObject gameOverPanel;

    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") == null)
        {
            gameOverPanel.SetActive(true);

        }
    }


    




    public void Restart()
    {
        SceneManager.LoadScene("Level");
        
    }

    public void RestartLevel2()
    {
        SceneManager.LoadScene("Level2");
    }
}
