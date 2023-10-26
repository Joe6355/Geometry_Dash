using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class _Ship : _Sounds
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // ��������, �������� �� ������������ ������ _Player
        if (collision.gameObject.GetComponent<_Player>() != null)
        {
            // ���� �� �� ������������ �����
            PlaySound(sounds[0], destroyed: true);
            Destroy(collision.gameObject);
            Invoke("Restart", 0.3f);
        }
    }

    private void Restart()  // ������ Resetart
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Debug.Log("GG");
    }

}
