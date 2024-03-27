using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum VersionChangeType
    {
        Bindings,
        ViewData,
        Hierarchy,
        Layout,
        StyleSheet,
        Styles,
        Overflow,
        BorderRadius,
        BorderWidth,
        Transform,
        Size,
        Repaint,
        Opacity,
        Color,
        RenderHints,
        TransitionProperty,
        EventCallbackCategories,
    }
}
