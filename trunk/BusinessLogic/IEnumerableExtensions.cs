using System;
using System.Collections.Generic;

namespace BusinessLogic
{
    public static class IEnumerableExtensions
    {
        /// <summary>
        /// Helper that visits each node in the list invoking the action
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">The source.</param>
        /// <param name="action">The action.</param>
        /// <remarks>
        /// This method is bound to be attached to the next release of the
        /// framework.
        /// </remarks>
        public static void Each<T>(this IEnumerable<T> source, Action<T> action)
        {
            foreach (T item in source)
            {
                action(item);
            }
        }
    }
}
