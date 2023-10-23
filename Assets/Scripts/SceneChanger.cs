using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChanger : MonoBehaviour
{
    
   

    
   

    public void Menu()
    {
        SceneManager.LoadScene("Level Selector");
        Debug.Log("Scene Loaded");
        Time.timeScale = 1f;
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Application Quited");
    }
}
