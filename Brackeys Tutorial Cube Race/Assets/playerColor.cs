using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerColor : MonoBehaviour
{
    public Color[] colors = new Color[5];

    // Start is called before the first frame update
    private void Start()
    {
        //setPlayerColor(0);
    }

    public void setPlayerColor(int colInd)
    {
        //Fetch the Renderer from the GameObject
        Renderer rend = GetComponent<Renderer>();

        //Set player color to new color
        rend.material.color = colors[colInd];
    }
}
