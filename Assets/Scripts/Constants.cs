using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//! Useful variables for the game, regarding animation durations, score, rows and columns for the array that will contain our candy and more.
public static class Constants  {

    public static readonly int Rows = 12;
    public static readonly int Columns = 8;
    public static readonly float AnimationDuration = 0.8f;

    public static readonly float MoveAnimationMinDuration = 0.05f;

    public static readonly float ExplosionDuration = 0.3f;

    public static readonly float WaitBeforePotentialMatchesCheck = 2f;
    public static readonly float OpacityAnimationFrameDelay = 0.05f;

    public static readonly int MinimumMatches = 3;
    public static readonly int MinimumMatchesForBonus = 4;

    public static readonly int Match3Score = 60;
    public static readonly int SubsequentMatchScore = 1000;
	
}
