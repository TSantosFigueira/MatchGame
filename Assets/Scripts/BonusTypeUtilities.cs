using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//! Info about the bonus that a shape/candy can carry.
[Flags]
public enum BonusType
{
    None,
    DestroyWholeRowColumn
}


//! Contains one method, to determine whether an enumeration variable contains the specified bonus type
public static class BonusTypeUtilities {
    
    public static bool ContainsDestroyWholeRowColumn(BonusType bt)
    {
        return (bt & BonusType.DestroyWholeRowColumn) == BonusType.DestroyWholeRowColumn;
    }
	
}


//! Contains the three states of our game
public enum GameState
{
    None,
    SelectionStarted,
    Animating
}