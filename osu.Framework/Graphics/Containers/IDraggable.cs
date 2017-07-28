// Copyright (c) 2007-2017 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu-framework/master/LICENCE

using System;
using osu.Framework.Input;

namespace osu.Framework.Graphics.Containers
{
    public interface IDraggable : IDrawable
    {
        Action<Drawable, InputState> DragStart { set; }

        Action<Drawable, InputState> Drag { set; }

        Action<Drawable, InputState> DragEnd { set; }
    }
}
