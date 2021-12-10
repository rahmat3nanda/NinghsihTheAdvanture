using System;
using UnityEngine;
using Object = System.Object;

namespace Tool
{
    public class JSONUtils
    {
        public static String ToJson<T>(T model)
        {
            return JsonUtility.ToJson(model);
        }

        public static T FromJson<T>(String json)
        {
            return JsonUtility.FromJson<T>(json);
        }
    }
}