// <copyright file="UnityXRHelper.cs" company="nicoco007">
// This file is part of IndexOffsetFixer.
//
// IndexOffsetFixer is free software: you can redistribute it and/or modify it under the terms
// of the GNU General Public License as published by the Free Software Foundation,
// either version 3 of the License, or (at your option) any later version.
//
// IndexOffsetFixer is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY;
// without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
// See the GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License along with IndexOffsetFixer.
// If not, see https://www.gnu.org/licenses/.
// </copyright>

using HarmonyLib;
using UnityEngine;

namespace IndexOffsetFixer.Patches
{
    /// <summary>
    /// Sets <see cref="UnityXRHelper._valveIndexPoseOffset"/> to a more reasonable value when <see cref="UnityXRHelper.Start"/> is called.
    /// </summary>
    [HarmonyPatch(typeof(UnityXRHelper), nameof(UnityXRHelper.Start))]
    internal static class UnityXRHelper_Start
    {
        private static void Prefix(UnityXRHelper __instance)
        {
            __instance._valveIndexPoseOffset = new EulerPose(new Vector3(0, -0.01f, 0.105f), new Vector3(5, 0, 0));
        }
    }
}
