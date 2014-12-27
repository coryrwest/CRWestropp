﻿using System.Text;

namespace CRWestropp.Utilities.Extensions
{
	public static class StringExtensions
    {
		#region Utilities
		/// <summary>
		/// Returns a string where a space is inserted between each uppercase character
		/// For example LookUp --> Look Up
		/// Multiple uppercase characters do not get spaces
		/// For example LookUpID --> Look Up ID
		/// </summary>
		/// <param name="source"></param>
		/// <returns></returns>
		public static string CreateSpaces(this string str)
		{
			// Construct the builder
			StringBuilder sb = new StringBuilder();
			char previous = (char)0;
			// Loop through each character
			foreach (char c in str)
			{
				// Add the first character automatically
				if (char.IsUpper(c) && !char.IsUpper(previous) && previous != (char)0)
					sb.Append(' ');
				sb.Append(c);
				// Update the previous
				previous = c;
			}

			// Return the string
			return sb.ToString();
		}

		/// <summary>
		/// Strips all non-alphanumeric values from the string and returns the resulting value
		/// Note: This does not update the current string
		/// </summary>
		/// <param name="str"></param>
		/// <returns></returns>
		public static string StripNonAlphaNumeric(this string str)
		{
			if (str == null)
				return null;
			StringBuilder builder = new StringBuilder();
			foreach (char c in str)
			{
				if (char.IsLetterOrDigit(c))
					builder.Append(c);
			}
			return builder.ToString();
		}
		#endregion

        #region IsNull
        /// <summary>
        /// Checks a string for null
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsNull(this string str) {
            return string.IsNullOrEmpty(str) || string.IsNullOrEmpty(str.Trim());
        }
        #endregion
    }
}
