using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 kGlobalsPropertyName                     string IL2CPP_TYPE_STRING
    // 000 kGlobalsPropertyId                       int IL2CPP_TYPE_I4
    // 010 ProbesOcclusion                          0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32
    // 020 SpecCube0_HDR                            0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32
    // 030 SpecCube1_HDR                            0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32
    // 040 SHCoefficients                           0001866AF7C0 ModelEnumType SHCoefficients SHCoefficients SHCoefficients Int32
    public partial class BatchRendererGroupGlobals
    {
        public Vector4                                  ProbesOcclusion                         { get; set; }
        public Vector4                                  SpecCube0_HDR                           { get; set; }
        public Vector4                                  SpecCube1_HDR                           { get; set; }
        public SHCoefficients                           SHCoefficients                          { get; set; }

        public static BatchRendererGroupGlobals? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BatchRendererGroupGlobals();

            value.ProbesOcclusion                           = (Vector4)GetInt32(new IntPtr(p + 0x010)); // 0270D929C358 0x10 ProbesOcclusion             ( 0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.SpecCube0_HDR                             = (Vector4)GetInt32(new IntPtr(p + 0x020)); // 0270D929C378 0x20 SpecCube0_HDR               ( 0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.SpecCube1_HDR                             = (Vector4)GetInt32(new IntPtr(p + 0x030)); // 0270D929C398 0x30 SpecCube1_HDR               ( 0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.SHCoefficients                            = (SHCoefficients)GetInt32(new IntPtr(p + 0x040)); // 0270D929C3B8 0x40 SHCoefficients              ( 0001866AF7C0 ModelEnumType SHCoefficients SHCoefficients SHCoefficients Int32 )

            return value;
        }
    }
}
