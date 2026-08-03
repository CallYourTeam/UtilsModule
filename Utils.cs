using System.Text;

namespace UtilsModule
{
    public static class Utils
    {
        public static string ListToString<T>(List<T> list)
        {
            var sb = new StringBuilder();

            foreach (var item in list)
            {
                sb.Append(item);
                sb.Append(';');
            }

            return sb.ToString();
        }

        public static List<T> StringToList<T>(string str, Func<string, T> strToItemFunc)
        {
            var list = new List<T>();

            if (str.Length != 0)
            {
                var strList = str.Split(';');

                foreach (var item in strList)
                {
                    list.Add(strToItemFunc(item));
                }
            }

            return list;
        }
    }
}
