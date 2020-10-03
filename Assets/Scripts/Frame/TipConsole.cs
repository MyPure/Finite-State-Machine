using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TipConsole : MonoBehaviour
{
    public static TipConsole instance;
    public Text text;

    private void Awake()
    {
        if (instance)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }

    public void Tip(string message)
    {
        if((text.text + message).Length > 400)
        {
            text.text = "";
        }

        text.text += message + "\n";
    }
}
