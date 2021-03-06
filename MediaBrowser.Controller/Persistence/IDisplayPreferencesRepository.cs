﻿using MediaBrowser.Model.Entities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MediaBrowser.Controller.Persistence
{
    /// <summary>
    /// Interface IDisplayPreferencesRepository
    /// </summary>
    public interface IDisplayPreferencesRepository : IRepository
    {
        /// <summary>
        /// Opens the connection to the repository
        /// </summary>
        /// <returns>Task.</returns>
        Task Initialize();

        /// <summary>
        /// Saves display preferences for an item
        /// </summary>
        /// <param name="displayPreferences">The display preferences.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Task.</returns>
        Task SaveDisplayPreferences(DisplayPreferences displayPreferences,
                                    CancellationToken cancellationToken);

        /// <summary>
        /// Gets the display preferences.
        /// </summary>
        /// <param name="displayPreferencesId">The display preferences id.</param>
        /// <returns>Task{DisplayPreferences}.</returns>
        DisplayPreferences GetDisplayPreferences(Guid displayPreferencesId);
    }
}
