using System.Collections.Generic;

namespace Fr.Matthiasdetoffoli.GlobalProjectCode.Classes.Utils
{
    /// <summary>
    /// Extension for array
    /// </summary>
    public static class ArrayExtension
    {
        /// <summary>
        /// Try to get a value from an array
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="pArray">the array</param>
        /// <param name="pIndex">the index we try to get the value of</param>
        /// <param name="pItem">the item will have the value </param>
        /// <returns><c>true</c> if we find the value, <c>false</c> if not</returns>
        /// <remarks>don't do it on IEnumerable because of dictionary class</remarks>
        public static bool TryToGetValue<T>(this T[] pArray, int pIndex, out T pItem)
        {
            pItem = default(T);

            if (pArray.Length > 0 && pArray.Length - 1 >= pIndex)
            {
                pItem = pArray[pIndex];
                return true;
            }

            return false;
        }
    }

    /// <summary>
    /// Extension for list
    /// </summary>
    public static class ListExtension
    {
        /// <summary>
        /// Try to get a value from a list
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="pList">the list</param>
        /// <param name="pIndex">the index we try to get the value of</param>
        /// <param name="pItem">the item will have the value </param>
        /// <returns><c>true</c> if we find the value, <c>false</c> if not</returns>
        /// <remarks>don't do it on IEnumerable because of dictionary class</remarks>
        public static bool TryToGetValue<T>(this List<T> pList, int pIndex, out T pItem)
        {
            pItem = default(T);

            if(pList.Count > 0 && pList.Count - 1 >= pIndex)
            {
                pItem = pList[pIndex];
                return true;
            }

            return false;
        }
    }
}
