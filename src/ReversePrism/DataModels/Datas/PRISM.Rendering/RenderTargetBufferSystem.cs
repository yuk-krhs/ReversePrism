using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_A                                      00018670DA70 ModelEnumType SwapBuffer SwapBuffer SwapBuffer Int32
    // 030 M_B                                      00018670DA70 ModelEnumType SwapBuffer SwapBuffer SwapBuffer Int32
    // 000 m_AisBackBuffer                          bool IL2CPP_TYPE_BOOLEAN
    // 004 m_Desc                                   RenderTextureDescriptor IL2CPP_TYPE_VALUETYPE
    // 050 M_FilterMode                             000186580780 ModelEnumType FilterMode FilterMode FilterMode Int32
    // 054 M_AllowMSAA                              000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class RenderTargetBufferSystem : DataModel
    {
        public SwapBuffer                               M_A                                     { get; set; }
        public SwapBuffer                               M_B                                     { get; set; }
        public FilterMode                               M_FilterMode                            { get; set; }
        public bool                                     M_AllowMSAA                             { get; set; }

        public static RenderTargetBufferSystem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RenderTargetBufferSystem() { Pointer= p0 };

            value.M_A                                       = (SwapBuffer)GetInt32(new IntPtr(p + 0x010)); // 024660AB3700 0x10 M_A                         ( 00018670DA70 ModelEnumType SwapBuffer SwapBuffer SwapBuffer Int32 )
            value.M_B                                       = (SwapBuffer)GetInt32(new IntPtr(p + 0x030)); // 024660AB3720 0x30 M_B                         ( 00018670DA70 ModelEnumType SwapBuffer SwapBuffer SwapBuffer Int32 )
            value.M_FilterMode                              = (FilterMode)GetInt32(new IntPtr(p + 0x050)); // 024660AB3780 0x50 M_FilterMode                ( 000186580780 ModelEnumType FilterMode FilterMode FilterMode Int32 )
            value.M_AllowMSAA                               = GetBool(new IntPtr(p + 0x054)); // 024660AB37A0 0x54 M_AllowMSAA                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
