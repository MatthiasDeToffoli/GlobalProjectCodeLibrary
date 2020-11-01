using Fr.Matthiasdetoffoli.GlobalProjectCode.Interfaces.Pooling.PoolElements;
using System.Collections.Generic;
using System.Linq;

namespace Fr.Matthiasdetoffoli.GlobalProjectCode.Classes.Pooling
{
    /// <summary>
    /// Dictionary contain all pool elements
    /// </summary>
    /// <seealso cref="APoolContainer"/>
    public class PoolContainer : APoolContainer
    {
        #region Constants
        /// <summary>
        /// Error throw when you try to add a null value in the pool dictionary
        /// </summary>
        private const string ERROR_TRY_TO_ADD_NULL_VALUE = "You try to add a null value in the pool dictionary";
        #endregion Constants

        #region Fields
        /// <summary>
        /// The list of pool elements
        /// </summary>
        private Dictionary<string,List<object>> mAllPools;

        /// <summary>
        /// The pool list
        /// </summary>
        private APoolInitializerContainer mPoolInitializerContainer;
        #endregion Fields

        #region Constructors
        /// <summary>
        /// Initialize an instance of the class <see cref="PoolContainer"/>
        /// </summary>
        /// <param name="pList">the pool list for init the pool dictionary</param>
        public PoolContainer(APoolInitializerContainer pList)
        {
            mPoolInitializerContainer = pList;
            mAllPools = new Dictionary<string, List<object>>();
        }
        #endregion Constructors

        #region Methods
        /// <summary>
        /// Init the pool dictionary and create all elements we need in pool
        /// </summary>
        public void Init()
        {
            foreach (IPoolElement lElement in mPoolInitializerContainer.elements)
                CreatePool(lElement);
        }

        /// <summary>
        /// Create all element we need at the init of the app
        /// </summary>
        /// <param name="pElement">the pool element contain datas we need for create what we want</param>
        private void CreatePool(IPoolElement pElement)
        {
            int i;

            if(pElement == null || pElement.value == null)
            {
                throw new System.Exception(ERROR_TRY_TO_ADD_NULL_VALUE);
            }

            //don't add the same value two time
            if (mAllPools.ContainsKey(pElement.id) == false)
            {
                //Create the list for contain all object
                mAllPools.Add(pElement.id, new List<object>());

                for(i = 0; i < pElement.nbToCreate; i++)
                {
                    mAllPools[pElement.id].Add(pElement.value);
                }
            }
        }
        /// <summary>
        /// Add item to the list
        /// </summary>
        /// <param name="pItem">the item to add</param>
        public override void Add(IPoolElement pItem)
        {
            if (pItem != null && Contain(pItem) == true)
                mAllPools[pItem.id].Add(pItem.value);
        }

        /// <summary>
        /// Add item to the list
        /// </summary>
        /// <param name="pKey">the key of the dictionary</param>
        /// <param name="pValue">the value of the dictionary</param>
        public void Add(string pKey, object pValue)
        {
            if(pValue != null && Contain(pKey) && mPoolInitializerContainer.elements.FirstOrDefault(pElm => pElm.id == pKey).IsEquivalent(pValue))
            {
                mAllPools[pKey].Add(pValue);
            }
        }
        /// <summary>
        /// Get an item
        /// </summary>
        /// <typeparam name="T">the type of the item</typeparam>
        /// <param name="pRef">the id of the item</param>
        /// <returns>the item with the good type</returns>
        protected override T GetInternal<T>(string pRef)
        {
            if (Contain(pRef))
            {
                List<object> lItems = mAllPools[pRef];
                object lItem = lItems.LastOrDefault(pElm => pElm is T);

                if(lItem == null)
                {
                    lItem = mPoolInitializerContainer.Get<T>(pRef);
                }
                else
                {
                    mAllPools[pRef].Remove(lItem);
                }

                return lItem as T;
            }
            return null;
        }

        /// <summary>
        /// If the list contain the item
        /// </summary>
        /// <param name="pRef">the id of the item</param>
        /// <returns><c>true</c> if the list contain the item, <c>false</c> if not</returns>
        public override bool Contain(string pRef)
        {
            return mAllPools.ContainsKey(pRef);
        }

        /// <summary>
        /// If the list contain the item
        /// </summary>
        /// <typeparam name="T">the type of the item</typeparam>
        /// <param name="pRef">the id of the item</param>
        /// <returns><c>true</c> if the list contain the item, <c>false</c> if not</returns>
        public override bool Contain<T>(string pRef)
        {
            return Contain(pRef) && mAllPools[pRef].FirstOrDefault(pElm => mPoolInitializerContainer.elements.FirstOrDefault(pElmList => pElmList is T).IsEquivalent(pElm)) != null;
        }

        /// <summary>
        /// Clear intern dictionnary
        /// </summary>
        public override void Clear()
        {
            mAllPools.Clear();
        }
        #endregion Methods
    }
}
