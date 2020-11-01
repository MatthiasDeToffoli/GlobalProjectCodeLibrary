using Fr.Matthiasdetoffoli.GlobalProjectCode.Interfaces.Pooling.PoolElements;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Fr.Matthiasdetoffoli.GlobalProjectCode.Classes.Pooling
{
    /// <summary>
    /// Used for initialized the pool
    /// </summary>
    /// <seealso cref="APoolContainer"/>
    public abstract class APoolInitializerContainer : APoolContainer
    {
        #region Properties
        /// <summary>
        /// The list of pool elements
        /// </summary>
        public abstract List<IPoolElement> elements
        {
            get;
        }
        #endregion Fields

        #region Constructors
        /// <summary>
        /// Initialize an instance of the class <see cref="APoolInitializerContainer"/>
        /// </summary>
        public APoolInitializerContainer()
        {
        }
        #endregion Constructors

        #region Methods
        /// <summary>
        /// Get an item
        /// </summary>
        /// <typeparam name="T">the type of the item</typeparam>
        /// <param name="pRef">the id of the item</param>
        /// <returns>the item with the good type</returns>
        protected override T GetInternal<T>(string pRef)
        {
            return elements.FirstOrDefault(pElm => pElm is T && pElm.id == pRef) as T;
        }

        /// <summary>
        /// If the list contain the item
        /// </summary>
        /// <param name="pRef">the id of the item</param>
        /// <returns><c>true</c> if the list contain the item, <c>false</c> if not</returns>
        public override bool Contain(string pRef)
        {
            return elements.Any(pElm => pElm.id == pRef);
        }

        /// <summary>
        /// If the list contain the item
        /// </summary>
        /// <typeparam name="T">the type of the item</typeparam>
        /// <param name="pRef">the id of the item</param>
        /// <returns><c>true</c> if the list contain the item, <c>false</c> if not</returns>
        public override bool Contain<T>(string pRef)
        {
            return elements.Any( pElm => pElm is T && pElm.id == pRef);
        }

        /// <summary>
        /// Clear all elements
        /// </summary>
        public override void Clear()
        {
            elements.Clear();
        }
        #endregion Methods
    }
}
