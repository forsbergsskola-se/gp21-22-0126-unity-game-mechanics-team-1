using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Explosion_1_Timer))]
public class Explosion_1_TimerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        Explosion_1_Timer myScript = (Explosion_1_Timer) target;
        if(GUILayout.Button("Trigger Bomb")) myScript.Trigger();
    }
}
