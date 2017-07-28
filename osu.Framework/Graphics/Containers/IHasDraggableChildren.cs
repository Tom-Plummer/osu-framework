// Copyright (c) 2007-2017 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu-framework/master/LICENCE

using System;
using osu.Framework.Input;

namespace osu.Framework.Graphics.Containers
{
    public interface IHasDraggableChildren : IDrawable
    {
        void OnChildDragStart(Drawable child, InputState state);

        void OnChildDrag(Drawable child, InputState state);

        void OnChildDragEnd(Drawable child, InputState state);
    }
}
