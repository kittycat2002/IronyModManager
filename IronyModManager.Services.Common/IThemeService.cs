﻿// ***********************************************************************
// Assembly         : IronyModManager.Services.Common
// Author           : Mario
// Created          : 01-13-2020
//
// Last Modified By : Mario
// Last Modified On : 01-21-2020
// ***********************************************************************
// <copyright file="IThemeService.cs" company="Mario">
//     Mario
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Generic;
using IronyModManager.Models.Common;

namespace IronyModManager.Services
{
    /// <summary>
    /// Interface IThemeService
    /// </summary>
    public interface IThemeService
    {
        #region Methods

        /// <summary>
        /// Gets this instance.
        /// </summary>
        /// <returns>IEnumerable&lt;ITheme&gt;.</returns>
        IEnumerable<ITheme> Get();

        /// <summary>
        /// Gets the selected.
        /// </summary>
        /// <returns>ITheme.</returns>
        ITheme GetSelected();

        /// <summary>
        /// Saves the specified theme.
        /// </summary>
        /// <param name="theme">The theme.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        bool Save(ITheme theme);

        /// <summary>
        /// Sets the selected.
        /// </summary>
        /// <param name="themes">The themes.</param>
        /// <param name="selectedTheme">The selected theme.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        bool SetSelected(IEnumerable<ITheme> themes, ITheme selectedTheme);

        #endregion Methods
    }
}
