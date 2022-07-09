using UnityEngine;
using UnityEditor;

public class FolderManager
{
    [MenuItem("Frog/Create BaseFolder")]
    static void CreateFolder()
    {
        AssetDatabase.CreateFolder("Assets", "Scripts");
        AssetDatabase.CreateFolder("Assets", "Prefab");
        AssetDatabase.CreateFolder("Assets", "Material");
        AssetDatabase.CreateFolder("Assets", "PhysicMaterial");
        AssetDatabase.CreateFolder("Assets", "Images");
        AssetDatabase.CreateFolder("Assets", "Sounds");
 
    }
}