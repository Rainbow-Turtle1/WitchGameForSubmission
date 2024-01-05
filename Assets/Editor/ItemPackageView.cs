// using UnityEngine;
// using UnityEditor;

// [CustomEditor(typeof(Item))]
// public class ItemPackageView : Editor
// {
//     SerializedProperty isPackageProp;
//     SerializedProperty packageSpriteProp;
//     SerializedProperty itemObjectsProp;
//     SerializedProperty quantitiesProp;

//     void OnEnable()
//     {
//         isPackageProp = serializedObject.FindProperty("isPackage");
//         packageSpriteProp = serializedObject.FindProperty("packageSprite");
//         itemObjectsProp = serializedObject.FindProperty("ItemObjects");
//         quantitiesProp = serializedObject.FindProperty("Quantities");
//     }

//     public override void OnInspectorGUI()
//     {
//         serializedObject.Update();

//         EditorGUILayout.PropertyField(isPackageProp);
//         EditorGUILayout.PropertyField(packageSpriteProp);

//         EditorGUILayout.Space();

//         DrawArrays();

//         serializedObject.ApplyModifiedProperties();
//     }

//     void DrawArrays()
//     {
//         int rows = itemObjectsProp.arraySize;
//         int cols = rows > 0 ? itemObjectsProp.GetArrayElementAtIndex(0).FindPropertyRelative("Array").arraySize : 0;

//         EditorGUILayout.LabelField("ItemObjects and Quantities", EditorStyles.boldLabel);

//         for (int row = 0; row < rows; row++)
//         {
//             SerializedProperty itemArray = itemObjectsProp.GetArrayElementAtIndex(row).FindPropertyRelative("Array");
//             SerializedProperty quantityArray = quantitiesProp.GetArrayElementAtIndex(row).FindPropertyRelative("Array");

//             EditorGUILayout.BeginHorizontal();

//             for (int col = 0; col < cols; col++)
//             {
//                 EditorGUILayout.BeginVertical();
//                 EditorGUILayout.PropertyField(itemArray.GetArrayElementAtIndex(col), GUIContent.none);
//                 EditorGUILayout.PropertyField(quantityArray.GetArrayElementAtIndex(col), GUIContent.none);
//                 EditorGUILayout.EndVertical();
//             }

//             EditorGUILayout.EndHorizontal();
//         }
//     }
// }
