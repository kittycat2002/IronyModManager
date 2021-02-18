﻿// ***********************************************************************
// Assembly         : IronyModManager
// Author           : Mario
// Created          : 02-17-2021
//
// Last Modified By : Mario
// Last Modified On : 02-18-2021
// ***********************************************************************
// <copyright file="IHotkeyManager.cs" company="Mario">
//     Mario
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IronyModManager.Common.Events;

namespace IronyModManager.Implementation.Hotkey
{
    /// <summary>
    /// Interface IHotkeyManager
    /// </summary>
    public interface IHotkeyManager
    {
        #region Methods

        /// <summary>
        /// Hots the key pressed asynchronous.
        /// </summary>
        /// <param name="navigationState">State of the navigation.</param>
        /// <param name="hotKey">The hot key.</param>
        /// <returns>Task.</returns>
        Task HotKeyPressedAsync(NavigationState navigationState, string hotKey);

        #endregion Methods
    }
}
