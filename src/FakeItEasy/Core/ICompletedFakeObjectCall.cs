namespace FakeItEasy.Core
{
    /// <summary>
    /// Represents a completed call to a fake object.
    /// </summary>
    public interface ICompletedFakeObjectCall : IFakeObjectCall
    {
        /// <summary>
        /// Gets the value set to be returned from the call.
        /// </summary>
        object ReturnValue { get; }

        /// <summary>
        /// Gets the sequence number of the call.
        /// </summary>
        int SequenceNumber { get; }
    }
}
