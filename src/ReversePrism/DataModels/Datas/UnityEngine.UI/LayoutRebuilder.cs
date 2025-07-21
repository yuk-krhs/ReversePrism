using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_ToRebuild                              ModelClassType RectTransform RectTransform RectTransform Pointer
    // 018 M_CachedHashFromTransform                ModelPrimitiveType int int int Int32
    // 000 s_Rebuilders                             ObjectPool`1<LayoutRebuilder> IL2CPP_TYPE_GENERICINST
    public partial class LayoutRebuilder : DataModel
    {
        public RectTransform?                           M_ToRebuild                             { get; set; }
        public int                                      M_CachedHashFromTransform               { get; set; }

        public static LayoutRebuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LayoutRebuilder() { Pointer= p0 };

            value.M_ToRebuild                               = GetObject<RectTransform>(new IntPtr(p + 0x010), ReversePrism.DataModels.RectTransform.FromPointer); // 0x10 M_ToRebuild                 ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.M_CachedHashFromTransform                 = GetInt32(new IntPtr(p + 0x018)); // 0x18 M_CachedHashFromTransform   ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
