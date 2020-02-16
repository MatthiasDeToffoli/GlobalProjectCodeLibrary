using fr.matthiasdetoffoli.GlobalProjectCode.Interfaces;

namespace fr.matthiasdetoffoli.GlobalProjectCode.Classes
{
    /// <summary>
    /// Abstract class preparing the instance of the singleton
    /// </summary>
    /// <typeparam name="T">The new singleton</typeparam>
    public abstract class ASingleton<T> : ISingleton where T : ISingleton, new()
    {
        #region Fields
        /// <summary>
        /// Private instance of the singleton
        /// </summary>
        protected static T mInstance;
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
                if(mInstance == null)
                {
                    mInstance = new T();
                }

                return mInstance;
            }
        }
        #endregion //Properties
    }
}
