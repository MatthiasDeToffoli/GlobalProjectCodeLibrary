using fr.matthiasdetoffoli.GlobalProjectCode.Interfaces;
using System;

namespace fr.matthiasdetoffoli.GlobalProjectCode.Classes
{
    /// <summary>
    /// Abstract class preparing the instance of the singleton
    /// </summary>
    /// <typeparam name="T">The new singleton</typeparam>
    /// <remarks>see also <seealso cref="ISingleton"/></remarks>
    public abstract class ASingleton<T> : ISingleton where T : class, ISingleton, new()
    {
        #region Fields
        /// <summary>
        /// Private instance of the singleton
        /// </summary>
        private static T mInstance;
        #endregion //Fields

        #region Properties
        /// <summary>
        /// public instance of the singleton
        /// </summary>
        /// <remarks>it return the private instance mIntance</remarks>
        public static T instance
        {
            get
            {
                if (mInstance == null)
                {
                    mInstance = new T();
                }

                return mInstance;
            }
        }

        /// <summary>
        /// The unique id of the singleton
        /// </summary>
        public string uniqueId
        {
            get;
            private set;
        }
        #endregion //Properties

        #region Constructors
        /// <summary>
        /// Initialize an instance of the class <see cref="ASingleton{T}"/>
        /// </summary>
        public ASingleton()
        {
            uniqueId = new Guid().ToString();
        }
        #endregion //Constructors

        #region Methods
        /// <summary>
        /// Remove the current instance of the singleton and Replace it by another one
        /// </summary>
        /// <param name="pNewInstance">the new isntance to set</param>
        public void Replace(ISingleton pNewInstance)
        {
            if(pNewInstance is T)
            {
                Remove();
                SetInstance(pNewInstance as T);
            }
        }

        /// <summary>
        /// remove the current instance of the singleton
        /// </summary>
        public virtual void Remove()
        {

            //Remove the instance in the static class
            RemoveInstance(uniqueId);
            
            uniqueId = string.Empty;
        }

        /// <summary>
        /// set the instance of the singleton if it not have another instance
        /// </summary>
        /// <param name="pInstance">the instance to set</param>
        private static void SetInstance(T pInstance)
        {
            if(mInstance == null && pInstance != null)
            {
                mInstance = pInstance;
            }
        }

        /// <summary>
        /// Remove the current instance of the singleton
        /// </summary>
        private static void RemoveInstance(string pRef)
        {
            if(pRef == mInstance.uniqueId.ToString())
            {
                mInstance = null;
            }
        }
        #endregion //Methods
    }
}
