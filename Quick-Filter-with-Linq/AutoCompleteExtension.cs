using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Quick_Filter_with_Linq
{
    public static class EnumerableExtensionsEx
    {
        /// <summary>
        /// Stolen from http://stackoverflow.com/a/4678230/1766716
        /// </summary>
        /// <param name="enumerable"></param>
        /// <returns></returns>
        public static AutoCompleteStringCollection ToAutoCompleteStringCollection(
            this IEnumerable<string> enumerable)
        {
            if (enumerable == null) throw new ArgumentNullException("enumerable");
            var autoComplete = new AutoCompleteStringCollection();
            foreach (var item in enumerable) autoComplete.Add(item);
            return autoComplete;
        }
    }
}
