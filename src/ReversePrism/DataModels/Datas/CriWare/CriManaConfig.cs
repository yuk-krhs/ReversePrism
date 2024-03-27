using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 NumberOfDecoders                         0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 NumberOfMaxEntries                       0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 GraphicsMultiThreaded                    000186596AF0 ModelPrimitiveType bool bool bool Bool
    // 020 PcH264PlaybackConfig                     000186562320 ModelClassType PCH264PlaybackConfig PCH264PlaybackConfig PCH264PlaybackConfig Pointer
    // 028 VitaH264PlaybackConfig                   000186562820 ModelClassType VitaH264PlaybackConfig VitaH264PlaybackConfig VitaH264PlaybackConfig Pointer
    // 030 WebglConfig                              000186562D20 ModelClassType WebGLConfig WebGLConfig WebGLConfig Pointer
    public partial class CriManaConfig
    {
        public int                                      NumberOfDecoders                        { get; set; }
        public int                                      NumberOfMaxEntries                      { get; set; }
        public bool                                     GraphicsMultiThreaded                   { get; set; }
        public PCH264PlaybackConfig?                    PcH264PlaybackConfig                    { get; set; }
        public VitaH264PlaybackConfig?                  VitaH264PlaybackConfig                  { get; set; }
        public WebGLConfig?                             WebglConfig                             { get; set; }

        public static CriManaConfig? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriManaConfig();

            value.NumberOfDecoders                          = GetInt32(new IntPtr(p + 0x010)); // 0270D1171858 0x10 NumberOfDecoders            ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.NumberOfMaxEntries                        = GetInt32(new IntPtr(p + 0x014)); // 0270D1171878 0x14 NumberOfMaxEntries          ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.GraphicsMultiThreaded                     = GetBool(new IntPtr(p + 0x018)); // 0270D1171898 0x18 GraphicsMultiThreaded       ( 000186596AF0 ModelPrimitiveType bool bool bool Bool )
            value.PcH264PlaybackConfig                      = GetObject<PCH264PlaybackConfig>(new IntPtr(p + 0x020), ReversePrism.DataModels.PCH264PlaybackConfig.FromPointer); // 0270D11718B8 0x20 PcH264PlaybackConfig        ( 000186562320 ModelClassType PCH264PlaybackConfig PCH264PlaybackConfig PCH264PlaybackConfig Pointer )
            value.VitaH264PlaybackConfig                    = GetObject<VitaH264PlaybackConfig>(new IntPtr(p + 0x028), ReversePrism.DataModels.VitaH264PlaybackConfig.FromPointer); // 0270D11718D8 0x28 VitaH264PlaybackConfig      ( 000186562820 ModelClassType VitaH264PlaybackConfig VitaH264PlaybackConfig VitaH264PlaybackConfig Pointer )
            value.WebglConfig                               = GetObject<WebGLConfig>(new IntPtr(p + 0x030), ReversePrism.DataModels.WebGLConfig.FromPointer); // 0270D11718F8 0x30 WebglConfig                 ( 000186562D20 ModelClassType WebGLConfig WebGLConfig WebGLConfig Pointer )

            return value;
        }
    }
}
