using fr.matthiasdetoffoli.GlobalProjectCode.Classes.Pooling;

namespace fr.matthiasdetoffoli.GlobalProjectCode.Interfaces.Pooling
{
    /// <summary>
    /// Interface of the Manager used for interact with the pool
    /// </summary>
    public interface IPoolManager : IManager
    {
        #region Methods
        /// <summary>
        /// Create and Init the pool
        /// </summary>
        void CreatePool();

        /// <summary>
        /// Get a pool element
        /// </summary>
        /// <typeparam name="T">the type of the element</typeparam>
        /// <param name="pRef">the id of the element</param>
        /// <returns>the pool element</returns>
        T GetElement<T>(string pRef) where T : class;

        /// <summary>
        /// Stock an element in the pool
        /// </summary>
        /// <param name="pRef">the id of the element</param>
        /// <param name="pElm">the element to stock</param>
        void StockElement(string pRef, object pElm);
        #endregion Methods
    }
}
