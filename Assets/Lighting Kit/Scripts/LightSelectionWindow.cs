using UnityEditor;
using UnityEngine;

public class LightSelectionWindow : EditorWindow
{
    [MenuItem("Window/Lighting Kit")]
    public static void ShowWindow()
    {
        GetWindow<LightSelectionWindow>("Light Prefab Selector");
    }

    void OnGUI()
    {
        EditorGUILayout.Space(3);
        if (GUILayout.Button("Candle"))
        {
            UnityEngine.Object prefab = AssetDatabase.LoadAssetAtPath("Assets/Lighting Kit/Prefabs/Candle Light.prefab", typeof(GameObject));
            var spawnPos = PrefabUtility.InstantiatePrefab(prefab) as GameObject;
            Camera view = UnityEditor.SceneView.lastActiveSceneView.camera;
            Vector3 editorPos = view.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0f));
            spawnPos.transform.position = editorPos;
            Selection.activeObject = spawnPos;
        }
        EditorGUILayout.Space(3);
        if (GUILayout.Button("Fire"))
        {
            UnityEngine.Object prefab = AssetDatabase.LoadAssetAtPath("Assets/Lighting Kit/Prefabs/Fire.prefab", typeof(GameObject));
            var spawnPos = PrefabUtility.InstantiatePrefab(prefab) as GameObject;
            Camera view = UnityEditor.SceneView.lastActiveSceneView.camera;
            Vector3 editorPos = view.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0f));
            spawnPos.transform.position = editorPos;
            Selection.activeObject = spawnPos;
        }
        EditorGUILayout.Space(3);
        if (GUILayout.Button("Lamp"))
        {
            UnityEngine.Object prefab = AssetDatabase.LoadAssetAtPath("Assets/Lighting Kit/Prefabs/Lamp.prefab", typeof(GameObject));
            var spawnPos = PrefabUtility.InstantiatePrefab(prefab) as GameObject;
            Camera view = UnityEditor.SceneView.lastActiveSceneView.camera;
            Vector3 editorPos = view.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0f));
            spawnPos.transform.position = editorPos;
            Selection.activeObject = spawnPos;
        }
        EditorGUILayout.Space(3);
        if (GUILayout.Button("Incandescent Light"))
        {
            UnityEngine.Object prefab = AssetDatabase.LoadAssetAtPath("Assets/Lighting Kit/Prefabs/Incandescent Light.prefab", typeof(GameObject));
            var spawnPos = PrefabUtility.InstantiatePrefab(prefab) as GameObject;
            Camera view = UnityEditor.SceneView.lastActiveSceneView.camera;
            Vector3 editorPos = view.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0f));
            spawnPos.transform.position = editorPos;
            Selection.activeObject = spawnPos;
        }
        EditorGUILayout.Space(3);
        if (GUILayout.Button("Halogen Light"))
        {
            UnityEngine.Object prefab = AssetDatabase.LoadAssetAtPath("Assets/Lighting Kit/Prefabs/Halogen Light.prefab", typeof(GameObject));
            var spawnPos = PrefabUtility.InstantiatePrefab(prefab) as GameObject;
            Camera view = UnityEditor.SceneView.lastActiveSceneView.camera;
            Vector3 editorPos = view.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0f));
            spawnPos.transform.position = editorPos;
            Selection.activeObject = spawnPos;
        }
        EditorGUILayout.Space(3);
        if (GUILayout.Button("3000K LED"))
        {
            UnityEngine.Object prefab = AssetDatabase.LoadAssetAtPath("Assets/Lighting Kit/Prefabs/3000K LED.prefab", typeof(GameObject));
            var spawnPos = PrefabUtility.InstantiatePrefab(prefab) as GameObject;
            Camera view = UnityEditor.SceneView.lastActiveSceneView.camera;
            Vector3 editorPos = view.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0f));
            spawnPos.transform.position = editorPos;
            Selection.activeObject = spawnPos;
        }
        EditorGUILayout.Space(3);
        if (GUILayout.Button("5500K LED"))
        {
            UnityEngine.Object prefab = AssetDatabase.LoadAssetAtPath("Assets/Lighting Kit/Prefabs/5500K LED.prefab", typeof(GameObject));
            var spawnPos = PrefabUtility.InstantiatePrefab(prefab) as GameObject;
            Camera view = UnityEditor.SceneView.lastActiveSceneView.camera;
            Vector3 editorPos = view.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0f));
            spawnPos.transform.position = editorPos;
            Selection.activeObject = spawnPos;
        }
        EditorGUILayout.Space(3);
        if (GUILayout.Button("7000K LED"))
        {
            UnityEngine.Object prefab = AssetDatabase.LoadAssetAtPath("Assets/Lighting Kit/Prefabs/7000K LED.prefab", typeof(GameObject));
            var spawnPos = PrefabUtility.InstantiatePrefab(prefab) as GameObject;
            Camera view = UnityEditor.SceneView.lastActiveSceneView.camera;
            Vector3 editorPos = view.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0f));
            spawnPos.transform.position = editorPos;
            Selection.activeObject = spawnPos;
        }
        EditorGUILayout.Space(3);
        if (GUILayout.Button("10000K LED"))
        {
            UnityEngine.Object prefab = AssetDatabase.LoadAssetAtPath("Assets/Lighting Kit/Prefabs/10000K LED.prefab", typeof(GameObject));
            var spawnPos = PrefabUtility.InstantiatePrefab(prefab) as GameObject;
            Camera view = UnityEditor.SceneView.lastActiveSceneView.camera;
            Vector3 editorPos = view.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0f));
            spawnPos.transform.position = editorPos;
            Selection.activeObject = spawnPos;
        }
        EditorGUILayout.Space(3);
        if (GUILayout.Button("Warning Light"))
        {
            UnityEngine.Object prefab = AssetDatabase.LoadAssetAtPath("Assets/Lighting Kit/Prefabs/Warning Light.prefab", typeof(GameObject));
            var spawnPos = PrefabUtility.InstantiatePrefab(prefab) as GameObject;
            Camera view = UnityEditor.SceneView.lastActiveSceneView.camera;
            Vector3 editorPos = view.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0f));
            spawnPos.transform.position = editorPos;
            Selection.activeObject = spawnPos;
        }
        EditorGUILayout.Space(3);
        if (GUILayout.Button("Floodlight"))
        {
            UnityEngine.Object prefab = AssetDatabase.LoadAssetAtPath("Assets/Lighting Kit/Prefabs/Floodlight.prefab", typeof(GameObject));
            var spawnPos = PrefabUtility.InstantiatePrefab(prefab) as GameObject;
            Camera view = UnityEditor.SceneView.lastActiveSceneView.camera;
            Vector3 editorPos = view.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0f));
            spawnPos.transform.position = editorPos;
            Selection.activeObject = spawnPos;
        }
        EditorGUILayout.Space(3);
        if (GUILayout.Button("Destroyable Light"))
        {
            UnityEngine.Object prefab = AssetDatabase.LoadAssetAtPath("Assets/Lighting Kit/Prefabs/Destroyable Light.prefab", typeof(GameObject));
            var spawnPos = PrefabUtility.InstantiatePrefab(prefab) as GameObject;
            Camera view = UnityEditor.SceneView.lastActiveSceneView.camera;
            Vector3 editorPos = view.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0f));
            spawnPos.transform.position = editorPos;
            Selection.activeObject = spawnPos;
        }
        EditorGUILayout.Space(3);
        if (GUILayout.Button("Overcast Light"))
        {
            UnityEngine.Object prefab = AssetDatabase.LoadAssetAtPath("Assets/Lighting Kit/Prefabs/Overcast Light.prefab", typeof(GameObject));
            var spawnPos = PrefabUtility.InstantiatePrefab(prefab) as GameObject;
            Camera view = UnityEditor.SceneView.lastActiveSceneView.camera;
            Vector3 editorPos = view.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0f));
            spawnPos.transform.position = editorPos;
            Selection.activeObject = spawnPos;
        }
        EditorGUILayout.Space(3);
    }
}