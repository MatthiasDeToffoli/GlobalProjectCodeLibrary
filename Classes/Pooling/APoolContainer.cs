using Fr.Matthiasdetoffoli.GlobalProjectCode.Interfaces.Pooling.PoolElements;

namespace Fr.Matthiasdetoffoli.GlobalProjectCode.Classes.Pooling
{
    /// <summary>
    /// Parent of all pool Container
    /// </summary>
    public abstract class APoolContainer
    {
        #region Constants
        /// <summary>
        /// Error show when the user try to get a value which not exist
        /// </summary>
        private const string ERROR_GET_NULL_EXCEPTION = "Try to get an item which not exist in the pool list";
        #endregion Constants

        #region Methods
        /// <summary>
        /// Add item to the list
        /// </summary>
        /// <param name="pItem">the item to add</param>
        public abstract void Add(IPoolElement pItem);

        /// <summary>
        /// Get an item
        /// </summary>
        /// <typeparam name="T">the type of the item</typeparam>
        /// <param name="pRef">the id of the item</param>
        /// <returns>the item with the good type</returns>
        public T Get<T>(string pRef) where T : class
        {
            T lItem = GetInternal<T>(pRef);

            if (lItem == null)
            {
                throw new System.Exception(ERROR_GET_NULL_EXCEPTION);
            }

            return lItem;
        }

        /// <summary>
        /// Get an item intern to the class
        /// </summary>
        /// <typeparam name="T">the type of the item</typeparam>
        /// <param name="pRef">the id of the item</param>
        /// <returns>the item with the good type</returns>
        protected abstract T GetInternal<T>(string pRef) where T : class;

        /// <summary>
        /// If the list contain the item
        /// </summary>
        /// <param name="pRef">the id of the item</param>
        /// <returns><c>true</c> if the list contain the item, <c>false</c> if not</returns>
        public abstract bool Contain(string pRef);

        /// <summary>
        /// If the list contain the item
        /// </summary>
        /// <typeparam name="T">the type of the item</typeparam>
        /// <param name="pRef">the id of the item</param>
        /// <returns><c>true</c> if the list contain the item, <c>false</c> if not</returns>
        public abstract bool Contain<T>(string pRef) where T : IPoolElement;

        /// <summary>
        /// If the list contain the item
        /// </summary>
        /// <typeparam name="T">the type of the item</typeparam>
        /// <param name="pItem">The item</param>
        /// <returns><c>true</c> if the list contain the item, <c>false</c> if not</returns>
        public bool Contain<T>(T pItem) where T : IPoolElement
        {
            if (pItem == null)
            {
                return false;
            }

            return Contain<T>(pItem.id);
        }

        /// <summary>
        /// Clear all elements
        /// </summary>
        public abstract void Clear();
        #endregion Methods
    }
}
