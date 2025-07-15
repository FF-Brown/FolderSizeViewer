
using System;
using System.IO;

namespace FolderSizeViewer
{
    public static class FolderScanner
    {
        public static long GetSize(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    return new FileInfo(path).Length;
                }
                else if (Directory.Exists(path))
                {
                    return GetDirectorySize(new DirectoryInfo(path));
                }
            }
            catch {}
            return 0;
        }

        private static long GetDirectorySize(DirectoryInfo dir)
        {
            long size = 0;
            try
            {
                foreach (FileInfo fi in dir.GetFiles())
                {
                    size += fi.Length;
                }
                foreach (DirectoryInfo di in dir.GetDirectories())
                {
                    size += GetDirectorySize(di);
                }
            }
            catch {}
            return size;
        }
    }
}
