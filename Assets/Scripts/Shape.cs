using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class will be used to hold details for each individual candy.
/// Each candy GameObject on the screen will have a Shape component, the type of Shape, the Column and Row that the candy is placed.
/// </summary>
public class Shape : MonoBehaviour {

    public BonusType Bonus { get; set; }
    
    public int Column { get; set; }
    public int Row { get; set; }
    public string Type { get; set; }

    public Shape()
    {
        Bonus = BonusType.None;
    }

    //! Checks if the current shape is of the same time as the parameter
    public bool IsSameType(Shape otherShape)
    {
        if(otherShape == null || !(otherShape is Shape))
            throw new ArgumentException("otherShape");

        return string.Compare(this.Type, (otherShape as Shape).Type) == 0;
    }


    //! Constructor alternative, since using regular constructor is not possible on prefab attached scripts
    public void Assign(string type, int row, int column)
    {
        if (string.IsNullOrEmpty(type))
            throw new ArgumentException("type");

        Column = column;
        Row = row;
        Type = type;
    }

    //! Swaps properties of the two shapes
    public static void SwapColumnRow(Shape a, Shape b)
    {
        int temp = a.Row;
        a.Row = b.Row;
        b.Row = temp;

        temp = a.Column;
        a.Column = b.Column;
        b.Column = temp;
    }
}
