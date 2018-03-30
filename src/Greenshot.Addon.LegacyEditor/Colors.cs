﻿#region Greenshot GNU General Public License

// Greenshot - a free and open source screenshot tool
// Copyright (C) 2007-2018 Thomas Braun, Jens Klingen, Robin Krom
// 
// For more information see: http://getgreenshot.org/
// The Greenshot project is hosted on GitHub https://github.com/greenshot/greenshot
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 1 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

#endregion

#region Usings

using System.Collections.Generic;
using System.Drawing;

#endregion

namespace Greenshot.Addon.LegacyEditor
{
	public static class Colors
	{
		public static bool IsVisible(Color c)
		{
			return !c.Equals(Color.Empty) && !c.Equals(Color.Transparent) && c.A > 0;
		}

		public static Color Mix(IEnumerable<Color> colors)
		{
			var a = 0;
			var r = 0;
			var g = 0;
			var b = 0;
			var count = 0;
			foreach (var color in colors)
			{
			    if (color.Equals(Color.Empty))
			    {
			        continue;
			    }
			    a += color.A;
			    r += color.R;
			    g += color.G;
			    b += color.B;
			    count++;
			}
			return count == 0 ? Color.Empty : Color.FromArgb(a / count, r / count, g / count, b / count);
		}
	}
}