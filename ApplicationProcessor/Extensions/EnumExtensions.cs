﻿using System;
using System.ComponentModel;

namespace Ulaw.ApplicationProcessor.Extensions
{
    static class EnumExtensions
    {
        public static string ToDescription(this Enum en)
        {
            var type = en.GetType();
            var memInfo = type.GetMember(en.ToString());

            if (memInfo != null && memInfo.Length > 0)
            {
                var attrs = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);

                if (attrs != null && attrs.Length > 0)
                    return ((DescriptionAttribute)attrs[0]).Description;

            }

            return en.ToString();
        }
    }

}
