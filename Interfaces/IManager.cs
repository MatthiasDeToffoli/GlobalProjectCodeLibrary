namespace fr.matthiasdetoffoli.GlobalProjectCode.Interfaces
{
    /// <summary>
    /// Interface used for all Managers
    /// </summary>
    public interface IManager
    {
        #region Methods
        /// <summary>
        /// Call in a chosen order for init elements
        /// </summary>
        void Init();

        /// <summary>
        /// Clear the Manager properties
        /// </summary>
        void Clear();
        #endregion Methods
    }
}

