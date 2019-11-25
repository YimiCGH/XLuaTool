using System.IO;
using NUnit.Framework;
using UnityEngine.TestTools;

namespace Tests
{
    public class xluaTest
    {
        // A Test behaves as an ordinary method
        [Test]
        public void IsHaveLuaScriptsFolder()
        {
            // Use the Assert class to test conditions
            
            bool dirExist = Directory.Exists(UnityEngine.Application.dataPath + "/LuaScripts/");
            Assert.IsTrue(dirExist, "需要在Assets目录下创建LuaScripts文件夹用来存放Lua脚本");
        }

    }
}
