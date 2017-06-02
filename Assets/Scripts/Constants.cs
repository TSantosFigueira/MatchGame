using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public static class Constants
{
    public static int Rows = GameObject.FindGameObjectWithTag("GameProperties").GetComponent<GameProperties>().rows;
    public static int Columns = GameObject.FindGameObjectWithTag("GameProperties").GetComponent<GameProperties>().columns;
    public static int prefabCount = GameObject.FindGameObjectWithTag("GameProperties").GetComponent<GameProperties>().coloursArraySize;

    public static readonly float AnimationDuration = 0.2f;

    public static readonly float MoveAnimationMinDuration = 0.05f;

    public static readonly float ExplosionDuration = 0.3f;

    public static readonly float WaitBeforePotentialMatchesCheck = 2f;
    public static readonly float OpacityAnimationFrameDelay = 0.05f;

    public static int MinimumMatches = GameObject.FindGameObjectWithTag("GameProperties").GetComponent<GameProperties>().minimumMatches;
    public static readonly int MinimumMatchesForBonus = 4;

    public static int Match3Score = 60;
    public static readonly int SubsequentMatchScore = 1000;

    public static Color[] colours = GameObject.FindGameObjectWithTag("GameProperties").GetComponent<GameProperties>().colours;
}



