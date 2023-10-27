using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class _Ship : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // проверка, является ли сталкивающий объект _Player
        if (collision.gameObject.GetComponent<_Player>() != null)
        {
            // если да то перезагрузка сцены
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            Debug.Log("GG");
        }
    }
    
}
