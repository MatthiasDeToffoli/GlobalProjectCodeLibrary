using System;

namespace Fr.Matthiasdetoffoli.GlobalProjectCode.Interfaces.Pooling.PoolElements
{
    /// <summary>
    /// Element used for init and create pool items
    /// </summary>
    public interface IPoolElement
    {
        #region Properties
        /// <summary>
        /// the id of the element
        /// </summary>
        string id
        {
            get;
        }

        /// <summary>
        /// The number of elements to create
        /// </summary>
        uint nbToCreate
        {
            get;
            set;
        }

        /// <summary>
        /// The value of the element
        /// </summary>
        object value
        {
            get;
        }
        #endregion Properties

        #region Methods
        /// <summary>
        /// If an object is equivalent to the value of the element
        /// </summary>
        /// <param name="pObject">the object to test</param>
        /// <returns></returns>
        bool IsEquivalent(object pObject);

        /// <summary>
        /// reset the properties of the object with the elements value
        /// </summary>
        /// <param name="pObject">the object to reset</param>
        /// <returns>the object reset</returns>
        object Reset(object pObject);
        #endregion Methods

    }
}
