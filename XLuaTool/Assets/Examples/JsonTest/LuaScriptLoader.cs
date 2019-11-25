using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using XLua;
public class LuaScriptLoader : MonoBehaviour
{
    public string m_relative_path = "/LuaScripts/";


    public string m_fileName;
    // Start is called before the first frame update
    void Start()
    {

        //bool exist = Directory.Exists(m_full_pathe);
        //Debug.LogFormat("{0}",exist);
        //
        /*
        Debug.Log("Application.dataPath = " + Application.dataPath);
        Debug.Log("Application.persistentDataPath = " + Application.persistentDataPath);
        Debug.Log("Application.streamingAssetsPath = " + Application.streamingAssetsPath);
        */
        //luaEnv.AddBuildin("rapidjson", XLua.LuaDLL.Lua.LoadRapidJson);

        //string path = Application.dataPath;
        //path  = path .Substring(0, path.Length - 6) + m_luafile_path;
        //Debug.Log(path);
        //string context = File.ReadAllText(path,System.Text.Encoding.UTF8);
        //Debug.Log(context);

        //RunSrcipt(context);

        LuaManager.Instance.AddLoader(m_relative_path);

        LuaManager.Instance.DoFile(m_fileName);
    }
    private void OnDestroy()
    {
        LuaManager.Instance.Destory();
    }

    //internal static LuaEnv luaEnv = new LuaEnv();
    //public void RunSrcipt(string _context) {

    //    luaEnv.DoString(_context);
    //}
}
