using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 198 M_ColorTargetIndentifiers                ModelClassListType RTHandle[] RTHandle[] List<RTHandle> Pointer
    // 1A0 M_DepthTargetIndentifiers                ModelClassType RTHandle RTHandle RTHandle Pointer
    public partial class DrawObjectsWithRenderingLayersPass : DataModel
    {
        public List<RTHandle>?                          M_ColorTargetIndentifiers               { get; set; }
        public RTHandle?                                M_DepthTargetIndentifiers               { get; set; }

        public static DrawObjectsWithRenderingLayersPass? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DrawObjectsWithRenderingLayersPass() { Pointer= p0 };

            value.M_ColorTargetIndentifiers                 = GetObjectList<RTHandle>(new IntPtr(p + 0x198), ReversePrism.DataModels.RTHandle.FromPointer); // 0x198 M_ColorTargetIndentifiers   ( ModelClassListType RTHandle[] RTHandle[] List<RTHandle> Pointer )
            value.M_DepthTargetIndentifiers                 = GetObject<RTHandle>(new IntPtr(p + 0x1A0), ReversePrism.DataModels.RTHandle.FromPointer); // 0x1A0 M_DepthTargetIndentifiers   ( ModelClassType RTHandle RTHandle RTHandle Pointer )

            return value;
        }
    }
}
