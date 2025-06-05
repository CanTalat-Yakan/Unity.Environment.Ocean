using UnityEditor;
using UnityEngine;

namespace UnityEssentials
{
    public class OceanPrefabSpawner : MonoBehaviour
    {
        [MenuItem("GameObject/Essentials/Ocean", false, priority = 102)]
        private static void InstantiateTimeOfDay(MenuCommand menuCommand)
        {
            var prefab = ResourceLoaderEditor.InstantiatePrefab("UnityEssentials_Prefab_Ocean", "Ocean");
            if (prefab != null)
            {
            }

            GameObjectUtility.SetParentAndAlign(prefab, menuCommand.context as GameObject);
            Undo.RegisterCreatedObjectUndo(prefab, "Create Ocean");
            Selection.activeObject = prefab;
        }
    }
}
