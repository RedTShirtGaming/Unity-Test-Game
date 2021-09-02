using UnityEngine;
using UnityEditor;

public class CustomMenu : EditorWindow
{
    Color colour;
    
    [MenuItem("RedTShirtGaming Studios/Colourizer")]
    public static void ShowWindow ()
    {
        GetWindow<CustomMenu>("Colourizer");
    }
    
    void OnGUI ()
    {
        GUILayout.Label("Colour the selected objects!", EditorStyles.boldLabel);

        colour = EditorGUILayout.ColorField("Colour", colour);

        if (GUILayout.Button("COLOURIZE!"))
        {
            foreach (GameObject obj in Selection.gameObjects)
            {
                Renderer renderer = obj.GetComponent<Renderer>();
                if (renderer != null)
                {
                    renderer.sharedMaterial.color = colour;
                }
            }
        }
    }
}