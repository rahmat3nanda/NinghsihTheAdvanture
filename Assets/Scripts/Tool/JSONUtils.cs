using UnityEngine;

namespace Tool
{
    public class JSONUtils
    {
        public static string ToJson<T>(T model)
        {
            return JsonUtility.ToJson(model);
        }

        public static T FromJson<T>(string json)
        {
            return JsonUtility.FromJson<T>(json);
        }
    }
}