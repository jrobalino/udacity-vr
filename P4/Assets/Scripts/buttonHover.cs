using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonHover : MonoBehaviour {

    public Button button;
    public Color startColor;
    public Color newColor;

    public void highlight()
    {
        ColorBlock cb = button.colors;
        cb.normalColor = newColor;
        button.colors = cb;

    }

    public void unhighlight()
    {
        ColorBlock cb = button.colors;
        cb.normalColor = startColor;
        button.colors = cb;
    }
}
