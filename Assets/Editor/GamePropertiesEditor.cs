using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(GameProperties))]
public class GamePropertiesEditor : Editor {
   
    public void OnEnable()
    {
        //GameProperties game = (GameProperties)target;
        //game.coloursArraySize = 3;
        //game.colours = new Color[game.coloursArraySize];
    }

    public override void OnInspectorGUI()
    {
        GameProperties game = (GameProperties)target;

        GUILayout.Label("Game Matrix", EditorStyles.boldLabel);

        EditorGUI.BeginChangeCheck();
        game.rows = EditorGUILayout.IntSlider("Rows", game.rows, 6, 12);
        game.columns = EditorGUILayout.IntSlider("Columns", game.columns, 6, 12);

        if (EditorGUI.EndChangeCheck())
        {
            Undo.RecordObject(target, "matrix size");
        }

        GUILayout.Label("Game Logic", EditorStyles.boldLabel);

        EditorGUI.BeginChangeCheck();
        game.minimumMatches = EditorGUILayout.IntSlider("Minimum Matches", game.minimumMatches, 3, 5);
        game.coloursArraySize = EditorGUILayout.IntSlider("Game match colors", game.coloursArraySize, 4, 5);

        if (EditorGUI.EndChangeCheck())
        {
            Undo.RecordObject(target, "game logic");
        }

        var temp = serializedObject.FindProperty("colours");
        serializedObject.Update();
        EditorGUILayout.PropertyField(temp, true);

        // Reescales the array according to the desired size
        if (game.coloursArraySize != game.colours.Length)
            game.CreateColorArray(game.coloursArraySize);

        EditorGUI.indentLevel = 2;
        for (int i = 0; i < game.colours.Length; i++)
        {
            game.colours[i] = EditorGUILayout.ColorField("Color " + (i + 1), game.colours[i]);
        }           
    }
}
