using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _SkinsPanels : MonoBehaviour
{
    [SerializeField] SpriteRenderer playerCore;//Заливка ядра
    [SerializeField] SpriteRenderer playerShell;//заливка рамки(оболочки)

    [SerializeField] GameObject Shell;
    [SerializeField] GameObject Core;

    public void RedColor()
    {
        playerShell.color = new Color(255f, 0f, 0f);
    }

    public void GreenColir()
    {
        playerShell.color = new Color(0f, 255f, 0f);
    }

    public void BlueColir()
    {
        playerShell.color = new Color(0f, 0f, 255f);
    }

    public void PurpleColor()
    {
        playerShell.color = new Color(255f, 0f, 255f);
    }

    public void AquaColor()
    {
        playerShell.color = new Color(0f, 255f, 255f);
    }

    public void YellowColor()
    {
        playerShell.color = new Color(255f, 255f, 0f);
    }

    public void BlackColor()
    {
        playerShell.color = new Color(0f, 0f, 0f);
    }

    public void GrayColor()
    {
        playerShell.color = new Color(0.5f, 0.5f, 0.5f);
    }

    public void WhiteColor()
    {
        playerShell.color = new Color(255f, 255f, 255f);
    }

    public void OrangeColor()
    {
        playerShell.color = new Color(1f, 0.647f, 0f);
    }


    public void RedColor1()
    {
        playerCore.color = new Color(255f, 0f, 0f);
    }

    public void GreenColir1()
    {
        playerCore.color = new Color(0f, 255f, 0f);
    }

    public void BlueColir1()
    {
        playerCore.color = new Color(0f, 0f, 255f);
    }

    public void PurpleColor1()
    {
        playerCore.color = new Color(255f, 0f, 255f);
    }

    public void AquaColor1()
    {
        playerCore.color = new Color(0f, 255f, 255f);
    }

    public void YellowColor1()
    {
        playerCore.color = new Color(255f, 255f, 0f);
    }

    public void BlackColor1()
    {
        playerCore.color = new Color(0f, 0f, 0f);
    }

    public void GrayColor1()
    {
        playerCore.color = new Color(0.5f, 0.5f, 0.5f);
    }

    public void WhiteColor1()
    {
        playerCore.color = new Color(255f, 255f, 255f);
    }

    public void OrangeColor1()
    {
        playerCore.color = new Color(1f, 0.647f, 0f);
    }
}
