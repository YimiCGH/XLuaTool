using System.IO;
using UnityEngine;
namespace XLua {
    public class LuaManager
    {
        static LuaManager m_instance;
        public static LuaManager Instance {
            get {
                if (m_instance == null)
                    m_instance = new LuaManager();
                return m_instance;
            }
        }

        LuaManager()
        {
            luaEnv = new LuaEnv();

            luaEnv.AddBuildin("rapidjson", XLua.LuaDLL.Lua.LoadRapidJson);
        }
        public void Destory() {
            luaEnv.Dispose();
        }

        public void Update() {
            if(luaEnv != null)
                luaEnv.Tick();
        }
        #region Private
        internal static LuaEnv luaEnv ;
        #endregion

        #region Loader
        public void AddLoader(string _LuaScriptsPath= "/LuaScripts/") {
            //工作目录
            luaEnv.AddLoader(
                //项目内路径
                (ref string _fileName) => {
                    string path = Application.dataPath + _LuaScriptsPath + _fileName;
                    //Debug.Log(path);
                    //path = path.Replace("/","\\");
                    bool exist = File.Exists(path );
                    Debug.Log(exist+"： " +path);
                    if (!exist) {
                        return null;
                    }
                    //string context = File.ReadAllText(path, System.Text.Encoding.UTF8);
                    //return System.Text.Encoding.UTF8.GetBytes(context);
                    return File.ReadAllBytes(path);
                }
                );
            luaEnv.AddLoader(
               //用户机器路径
               (ref string _fileName) => {
                   string path = Application.persistentDataPath + _LuaScriptsPath;
                   bool exist = File.Exists(path + _fileName);
                   if (!exist)
                   {
                       return null;
                   }
                    //string context = File.ReadAllText(path, System.Text.Encoding.UTF8);
                    //return System.Text.Encoding.UTF8.GetBytes(context);
                    return File.ReadAllBytes(path);
               }
               );
        }

        public void DoFile(string _fileName) {
            luaEnv.DoString(string.Format("require '{0}'",_fileName));
        }
        public void DoFile_FullDataPath(string _filePath)
        {
            //Debug.Log(path);
            string context = File.ReadAllText(_filePath, System.Text.Encoding.UTF8);
            //Debug.Log(context);

            luaEnv.DoString(context);
        }
        #endregion
    }

}
