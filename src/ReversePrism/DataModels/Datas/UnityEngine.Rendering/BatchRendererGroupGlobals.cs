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
    public partial class BatchRendererGroupGlobals : DataModel
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
            var value   = new BatchRendererGroupGlobals() { Pointer= p0 };

            value.ProbesOcclusion                           = (Vector4)GetInt32(new IntPtr(p + 0x010)); // 0246692FE848 0x10 ProbesOcclusion             ( 0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.SpecCube0_HDR                             = (Vector4)GetInt32(new IntPtr(p + 0x020)); // 0246692FE868 0x20 SpecCube0_HDR               ( 0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.SpecCube1_HDR                             = (Vector4)GetInt32(new IntPtr(p + 0x030)); // 0246692FE888 0x30 SpecCube1_HDR               ( 0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.SHCoefficients                            = (SHCoefficients)GetInt32(new IntPtr(p + 0x040)); // 0246692FE8A8 0x40 SHCoefficients              ( 0001866AF7C0 ModelEnumType SHCoefficients SHCoefficients SHCoefficients Int32 )

            return value;
        }
    }
}
