using UnityEditor;
using UnityEngine;

public class ItemDataBaseEditor : EditorWindow
{
    [MenuItem("Window/Item Database")]
    public static void ShowWindow()
    {
        GetWindow<ItemDataBaseEditor>("Item Database");

    }

    void OnGUI()
    {
        // Window Code

        GUILayout.Label("Item Database Tool", EditorStyles.boldLabel);
        string myString = "";

        int tab = 0;
        int test;

        test = GUILayout.Toolbar(tab, new string[] { "Weapon", "Armor", "Consumable" });
    }
}
