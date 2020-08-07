
using System.IO;

namespace Tiny_Injector
{
    public static class SaveFile
    {
        public static string name = "Tiny Man Injector Save Data.txt";

        public static void saveFile()
        {
            if (!File.Exists(name))
            {
                File.Create(name).Close();
            }                       

                File.WriteAllText(name, DataHolder.getData());
        }

        public static void loadFile()
        {
            if (!File.Exists(name))
            {
                File.Create(name).Close();
                return;
            }

            if (DataHolder.setData(File.ReadAllLines(name)) == 0)
                Imports.kernelErrMsg("Save file has no valid content");
        }

    }
}
