using System;

namespace EVL
{
	/// <summary>
	/// EVL library.
	/// </summary>
	public static class EVLLibrary
	{
		/// <summary>
		/// Return the value from fallback function if main function throws exception.
		/// </summary>
		/// <typeparam name="T">Value type</typeparam>
		/// <param name="func">Main function</param>
		/// <param name="fallbackFunc">Fallback function</param>
		/// <returns>Actual value from successful function</returns>
		public static T EVL<T>(Func<T> func, Func<T> fallbackFunc)
		{
			try
			{
				return func();
			}
			catch (Exception)
			{
				return fallbackFunc();
			}
		}

		/// <summary>
		/// Return the value from fallback function if main function throws exception.
		/// </summary>
		/// <typeparam name="T">Value type</typeparam>
		/// <param name="func">Main function</param>
		/// <param name="fallbackValue">Fallback value</param>
		/// <returns>Actual value from successful function</returns>
		public static T EVL<T>(Func<T> func, T fallbackValue)
		{
			try
			{
				return func();
			}
			catch (Exception)
			{
				return fallbackValue;
			}
		}
	}
}
