using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Explosion))]
public class ExplosionEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        Explosion myScript = (Explosion) target;
        if(GUILayout.Button("Explode")) myScript.Explode();
    }
}
