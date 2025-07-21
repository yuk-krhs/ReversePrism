using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0E0 M_PassData                               ModelClassType PassData PassData PassData Pointer
    // 0E8 M_ColorTarget                            ModelClassType RTHandle RTHandle RTHandle Pointer
    // 0F0 M_DepthTarget                            ModelClassType RTHandle RTHandle RTHandle Pointer
    // 0F8 M_RenderOffscreen                        ModelPrimitiveType bool bool bool Bool
    public partial class DrawScreenSpaceUIPass : DataModel
    {
        public PassData?                                M_PassData                              { get; set; }
        public RTHandle?                                M_ColorTarget                           { get; set; }
        public RTHandle?                                M_DepthTarget                           { get; set; }
        public bool                                     M_RenderOffscreen                       { get; set; }

        public static DrawScreenSpaceUIPass? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DrawScreenSpaceUIPass() { Pointer= p0 };

            value.M_PassData                                = GetObject<PassData>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.PassData.FromPointer); // 0xE0 M_PassData                  ( ModelClassType PassData PassData PassData Pointer )
            value.M_ColorTarget                             = GetObject<RTHandle>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.RTHandle.FromPointer); // 0xE8 M_ColorTarget               ( ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.M_DepthTarget                             = GetObject<RTHandle>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.RTHandle.FromPointer); // 0xF0 M_DepthTarget               ( ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.M_RenderOffscreen                         = GetBool(new IntPtr(p + 0x0F8)); // 0xF8 M_RenderOffscreen           ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
