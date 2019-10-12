using System;
using System.Collections.Generic;
using System.Linq;

namespace ExploringTheCore.Utils.Extensions
{
    public static class LinqExtensions
    {
        public static T? FirstOrNull<T>(this IEnumerable<T> data) where T : class
        {
            return data.Any() ? data.First() : null;
        }

        public static T? FirstOrNull<T>(this IEnumerable<T> data, Func<T, bool> predicate) where T : class
        {
            return data.Any() ? data.First(predicate) : null;
        }
    }
}
