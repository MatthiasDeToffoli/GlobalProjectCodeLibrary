using System;

namespace fr.matthiasdetoffoli.GlobalProjectCode.Interfaces
{
    /// <summary>
    /// Singleton Interface
    /// </summary>
    public interface ISingleton
    {
        #region Properties
        /// <summary>
        /// The unique id of the singleton
        /// </summary>
        string uniqueId { get; }
        #endregion //Properties

        #region Methods
        /// <summary>
        /// Remove the current instance of the singleton and Replace it by another one
        /// </summary>
        /// <param name="pNewInstance"></param>
        void Replace(ISingleton pNewInstance);

        /// <summary>
        /// remove the current instance of the singleton
        /// </summary>
        void Remove();
        #endregion //Methods
    }
}
