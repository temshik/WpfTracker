﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;

namespace WpfTracker.Models
{
    /// <summary>
    /// User information for the application table.
    /// </summary>
    public class User : BaseVM
    {
        /// <summary>
        /// User full name.
        /// </summary>
        [JsonPropertyName("User")]
        public string UserName { get; set; }

        /// <summary>
        /// Average number of steps taken over the entire period.
        /// </summary>
        public int AverageStepsNumber { get; set; }

        /// <summary>
        /// The best result for the entire period.
        /// </summary>
        public int TheBestResult { get; set; }

        /// <summary>
        /// The worst result for the entire period.
        /// </summary>
        public int TheWorstResult { get; set; }

        /// <summary>
        /// User data for the entire period ( <day, user information for a day> ).
        /// </summary>
        public Dictionary<int, UserInformationForADay> UserData { get; set; }
            = new Dictionary<int, UserInformationForADay>();
    }
}
