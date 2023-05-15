using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Enemy),true)]
public class EnemyEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        Enemy myEnemy = target as Enemy;
        EditorGUILayout.Space();
        EditorGUILayout.LabelField("RUNTIME DEBUG");
        if (GUILayout.Button("Damage 1")){
            myEnemy.Damage(1);
        }
        
    }
}
