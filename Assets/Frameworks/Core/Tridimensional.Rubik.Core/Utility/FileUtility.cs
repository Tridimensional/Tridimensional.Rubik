using System;
using System.IO;
using UnityEngine;

namespace Tridimensional.Rubik.Core.Utility
{
    public class FileUtility
    {
        public static void Save(string path, byte[] bytes)
        {
            var fileName = GetFilename(path);
            File.WriteAllBytes(fileName, bytes);
        }

        public static string GetFilename(string path)
        {
            if(!path.StartsWith("~"))
            {
                throw new ArgumentException("path must starts with '~'", "path");
            }

            return string.Format("{0}{1}", Application.dataPath, path.TrimStart('~'));
        }

        public static void SaveScreenshot(string fileName)
        {
 
        }
    }
}
