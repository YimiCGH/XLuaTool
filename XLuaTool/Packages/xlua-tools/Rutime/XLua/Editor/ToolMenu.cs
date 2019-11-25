using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;
public class ToolMenu 
{
    [MenuItem("XLua/生成脚本文件夹")]
    public static void CreateFold() {
        string path = Application.dataPath + "/LuaScripts";
        if (!Directory.Exists(path))
            Directory.CreateDirectory(path);

        AssetDatabase.Refresh();
    }
}
