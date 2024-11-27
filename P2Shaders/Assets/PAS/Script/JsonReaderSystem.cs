using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class JsonReaderSystem : MonoBehaviour
{
    int loadedIndex;
    string loadedName;
    string loadedInfo;

    public void SaveToJson()
    {
        WeaponData data = new WeaponData();

        data.Index = 1;
        data.Name = "Cleber";
        data.Information = "Muito Legal - Interessante - Reprovado na materia";

        string json = JsonUtility.ToJson(data, false);
        File.WriteAllText(Application.dataPath + "/WeaponData.json", json);
    }
    public void LoadToJson()
    {
        string json = File.ReadAllText(Application.dataPath + "/WeaponData.json");
        WeaponData data = JsonUtility.FromJson<WeaponData>(json);

        loadedIndex = data.Index;
        loadedName = data.Name;
        loadedInfo = data.Information;
    }
}
