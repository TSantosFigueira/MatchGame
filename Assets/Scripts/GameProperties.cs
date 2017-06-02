using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameProperties : MonoBehaviour {

    public int rows;
    public int columns;
    public int minimumMatches;
    public int coloursArraySize;
    public Color[] colours;

    public void CreateColorArray(int size)
    {
        colours = new Color[size];
    }
}
