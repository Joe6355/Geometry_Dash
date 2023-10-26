using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class _SceneSettings : MonoBehaviour
{
    public GameObject PausePanel, Inventory, tapEffect;
    public int level;

    public void PauseButtonPressed()
    {
        PausePanel.SetActive(true); // активирует панель
        Time.timeScale = 0f;//отсанавливает время
    }

    public void ContinueButtonPressed()
    {
        PausePanel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void RestartButtonPressed()
    {
        SceneManager.LoadScene(2);//загружает нашу 2 сцену
        Time.timeScale = 1f;
    }

    public void MenuButtonPressed()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }
}
