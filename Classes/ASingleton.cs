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
        protected static T mInstance;
        #endregion //Fields

        #region Properties
        /// <summary>
        /// Unic instance of the singleton
        /// </summary>
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
