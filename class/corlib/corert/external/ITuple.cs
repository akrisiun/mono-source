// https://source.dot.net/#System.Private.CoreLib/shared/System/Runtime/CompilerServices/ITuple.cs
// https://github.com/dotnet/coreclr/blob/master/src/mscorlib/shared/System/Runtime/CompilerServices/ITuple.cs

namespace System.Runtime.CompilerServices
{
    /// <summary>
    /// This interface is required for types that want to be indexed into by dynamic patterns.
    /// </summary>
    public interface ITuple
    {
        /// <summary>
        /// The number of positions in this data structure.
        /// </summary>
        int Length { get; }

        /// <summary>
        /// Get the element at position <param name="index"/>.
        /// </summary>
        object this[int index] { get; }
    }
}

