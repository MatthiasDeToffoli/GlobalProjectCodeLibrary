namespace fr.matthiasdetoffoli.GlobalProjectCode.Interfaces
{
    /// <summary>
    /// Interface used for all Managers
    /// </summary>
    public interface IManager
    {
        /// <summary>
        /// Call after the Start in a chosen order for init elements
        /// </summary>
        void Init();
    }
}

