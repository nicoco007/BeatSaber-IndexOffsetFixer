// <copyright file="Plugin.cs" company="nicoco007">
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
using IPA;

namespace IndexOffsetFixer;

[Plugin(RuntimeOptions.DynamicInit)]
public class Plugin
{
    private readonly Harmony _harmony = new("com.nicoco007.beat-saber.index-offset-fixer");

    [OnEnable]
    public void OnEnable()
    {
        _harmony.PatchAll();
    }

    [OnDisable]
    public void OnDisable()
    {
        _harmony.UnpatchSelf();
    }
}
