using System;
using System.Collections.Generic;
using System.IO;

namespace SoundSwap.Core
{
    public class StorageManager(string fileName)
    {
        private readonly string fileName = fileName;

        public void Save(List<string> lines)
        {
            try
            {
                File.WriteAllLines(fileName, lines);
            }
            catch (Exception /*ex*/)
            {
                // Log error
            }
        }

        public List<string> Load()
        {
            try
            {
                if (File.Exists(fileName))
                {
                    return new(File.ReadAllLines(fileName));
                }
                else
                {
                    return [];
                }
            }
            catch (Exception ex)
            {
                return [];
            }
        }
    }
}
