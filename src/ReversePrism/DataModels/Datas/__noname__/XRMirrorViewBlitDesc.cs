using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 displaySubsystemInstance                 <int> IL2CPP_TYPE_I
    // 018 NativeBlitAvailable                      000186595960 ModelPrimitiveType bool bool bool Bool
    // 019 NativeBlitInvalidStates                  000186595960 ModelPrimitiveType bool bool bool Bool
    // 01C BlitParamsCount                          0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class XRMirrorViewBlitDesc
    {
        public bool                                     NativeBlitAvailable                     { get; set; }
        public bool                                     NativeBlitInvalidStates                 { get; set; }
        public int                                      BlitParamsCount                         { get; set; }

        public static XRMirrorViewBlitDesc? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XRMirrorViewBlitDesc();

            value.NativeBlitAvailable                       = GetBool(new IntPtr(p + 0x018)); // 0270069724C8 0x18 NativeBlitAvailable         ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.NativeBlitInvalidStates                   = GetBool(new IntPtr(p + 0x019)); // 0270069724E8 0x19 NativeBlitInvalidStates     ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.BlitParamsCount                           = GetInt32(new IntPtr(p + 0x01C)); // 027006972508 0x1C BlitParamsCount             ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
