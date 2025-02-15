#if XUNIT_NULLABLE
#nullable enable
#endif

namespace Xunit.Sdk
{
	/// <summary>
	/// Exception thrown when a collection unexpectedly does not contain the expected value.
	/// </summary>
#if XUNIT_VISIBILITY_INTERNAL
	internal
#else
	public
#endif
	class ContainsException : AssertActualExpectedException
	{
		/// <summary>
		/// Creates a new instance of the <see cref="ContainsException"/> class.
		/// </summary>
		/// <param name="expected">The expected object value</param>
		/// <param name="actual">The actual value</param>
		public ContainsException(
#if XUNIT_NULLABLE
			object? expected,
			object? actual) :
#else
			object expected,
			object actual) :
#endif
				base(expected, actual, "Assert.Contains() Failure", "Not found", "In value")
		{ }
	}
}
