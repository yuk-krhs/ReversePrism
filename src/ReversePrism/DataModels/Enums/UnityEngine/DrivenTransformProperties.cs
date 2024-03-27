using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum DrivenTransformProperties
    {
        None,
        All,
        AnchoredPositionX,
        AnchoredPositionY,
        AnchoredPositionZ,
        Rotation,
        ScaleX,
        ScaleY,
        ScaleZ,
        AnchorMinX,
        AnchorMinY,
        AnchorMaxX,
        AnchorMaxY,
        SizeDeltaX,
        SizeDeltaY,
        PivotX,
        PivotY,
        AnchoredPosition,
        AnchoredPosition3D,
        Scale,
        AnchorMin,
        AnchorMax,
        Anchors,
        SizeDelta,
        Pivot,
    }
}
