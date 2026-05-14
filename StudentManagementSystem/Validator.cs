using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagementSystem
{
    /// <summary>
    /// Helper class to validate Windows Forms Controls and data.
    /// </summary>
    static class Validator
    {
        /// <summary>
        /// This method checks if the text box is empty or not.
        /// </summary>
        /// <param name="box">The text box to check.</param>
        /// <returns>true if the text box is not empty; otherwise, false.</returns>
        public static bool IsPresent(TextBox box)
        {
            if (string.IsNullOrWhiteSpace(box.Text))
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Checks string to ensure it is in a valid date format.
        /// </summary>
        /// <param name="dateString">the string to check</param>
        /// <returns>true if <paramref name="dateString"/> is a valid date; otherwise, false.</returns>
        public static bool IsValidDate(string dateString)
        {

            // the "_" is the discard operator, intentionally ignored.
            if (DateTime.TryParse(dateString, out _))
            {
                return true;
            }

            return false;
        }
    }
}
