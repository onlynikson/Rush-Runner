using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    
    
    
   

    public void StartLevel()
    {
        SceneManager.LoadScene("Level");
        Debug.Log("Level Selected");
    }

    public void StartLevel2()
    {
        SceneManager.LoadScene("Level2");
        Debug.Log("Level2 Selected");
    }
}
