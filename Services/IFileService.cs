﻿using System.Collections.Generic;
using System.Threading.Tasks;
using WpfTracker.Models;

namespace WpfTracker.Services
{
    /// <summary>
    /// File service.
    /// </summary>
    public interface IFileService
    {
        /// <summary>
        /// Get all users statictic.
        /// </summary>
        /// <returns>A <see cref="Task{IList{User}}".</returns>
        public Task<IList<User>> GetUsersStatistic();

        /// <summary>
        /// Get all users statictic.
        /// </summary>
        /// <param name="files">Files.</param>
        /// <returns>A <see cref="Task{IList{User}}".</returns>
        public Task<IList<User>> GetUsersStatistic(string[] files);
    }
}
