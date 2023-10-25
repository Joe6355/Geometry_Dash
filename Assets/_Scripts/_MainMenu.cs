using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class _MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("ScrollMenu");
    }

    public void ExitGame()
    {
        
    }
}
