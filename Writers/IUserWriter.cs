﻿using System.Threading.Tasks;
using WpfTracker.Models;

namespace WpfTracker.Writers
{
    /// <summary>
    /// User writer.
    /// </summary>
    public interface IUserWriter
    {
        /// <summary>
        /// Writes the specified user data.
        /// </summary>
        /// <param name="user">The user informtion.</param>
        /// <returns>A <see cref="Task">.</returns>
        Task Write(User user);
    }
}