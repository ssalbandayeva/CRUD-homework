namespace Pronia.Utils
{
    public static class Extension
    {

        //public static bool CheckFileSize(this IFormFile file, int size)
        //    => file.Length / 1024 < size;  ve ya

        public static bool CheckFileSize(this IFormFile file, int size)
        {
            return file.Length / 1024 < size;
        }

        public static bool CheckFileType(this IFormFile file, string fileType)
        {
            return file.ContentType.Contains($"{fileType}/");
        }
    }
}
