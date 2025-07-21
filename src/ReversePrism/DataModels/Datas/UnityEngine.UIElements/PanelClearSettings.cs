using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ClearDepthStencil                        ModelPrimitiveType bool bool bool Bool
    // 011 ClearColor                               ModelPrimitiveType bool bool bool Bool
    // 014 Color                                    ModelEnumType Color Color Color Int32
    public partial class PanelClearSettings : DataModel
    {
        public bool                                     ClearDepthStencil                       { get; set; }
        public bool                                     ClearColor                              { get; set; }
        public Color                                    Color                                   { get; set; }

        public static PanelClearSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PanelClearSettings() { Pointer= p0 };

            value.ClearDepthStencil                         = GetBool(new IntPtr(p + 0x010)); // 0x10 ClearDepthStencil           ( ModelPrimitiveType bool bool bool Bool )
            value.ClearColor                                = GetBool(new IntPtr(p + 0x011)); // 0x11 ClearColor                  ( ModelPrimitiveType bool bool bool Bool )
            value.Color                                     = (Color)GetInt32(new IntPtr(p + 0x014)); // 0x14 Color                       ( ModelEnumType Color Color Color Int32 )

            return value;
        }
    }
}
