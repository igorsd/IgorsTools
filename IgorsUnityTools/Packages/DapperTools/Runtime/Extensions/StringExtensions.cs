using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DapperDino.Examples
{
    public static class StringExtensions {
        public static string WithColor(this string val, Color clr)
        {
            return $"<color=#{ColorUtility.ToHtmlStringRGBA(clr)}>{val}</color>";
        }
    }
}


