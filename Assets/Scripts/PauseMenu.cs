using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenu;
    [SerializeField] private AudioSource source;

    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        source.Pause();
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        source.Play();
    }
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
