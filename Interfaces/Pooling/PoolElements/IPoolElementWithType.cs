namespace Fr.Matthiasdetoffoli.GlobalProjectCode.Interfaces.Pooling.PoolElements
{
    /// <summary>
    /// a  IPoolElement with a specific type
    /// </summary>
    /// <typeparam name="T">type of the value</typeparam>
    /// <seealso cref="IPoolElement"/>
    public interface IPoolElementWithType<T> : IPoolElement
    {
        #region Properties
        /// <summary>
        /// The typed value of the pool element
        /// </summary>
        T typedValue
        {
            get;
        }
        #endregion Properties

    }
}
