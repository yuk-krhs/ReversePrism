using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 defaultValue                             RasterState IL2CPP_TYPE_VALUETYPE
    // 010 M_CullingMode                            000186663F50 ModelEnumType CullMode CullMode CullMode Int32
    // 014 M_OffsetUnits                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 M_OffsetFactor                           0001866656B0 ModelPrimitiveType float float float Single
    // 01C M_DepthClip                              00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01D M_Conservative                           00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01E M_Padding1                               00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 01F M_Padding2                               00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    public partial class RasterState
    {
        public CullMode                                 M_CullingMode                           { get; set; }
        public int                                      M_OffsetUnits                           { get; set; }
        public float                                    M_OffsetFactor                          { get; set; }
        public sbyte                                    M_DepthClip                             { get; set; }
        public sbyte                                    M_Conservative                          { get; set; }
        public sbyte                                    M_Padding1                              { get; set; }
        public sbyte                                    M_Padding2                              { get; set; }

        public static RasterState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RasterState();

            value.M_CullingMode                             = (CullMode)GetInt32(new IntPtr(p + 0x010)); // 0270068CDFA0 0x10 M_CullingMode               ( 000186663F50 ModelEnumType CullMode CullMode CullMode Int32 )
            value.M_OffsetUnits                             = GetInt32(new IntPtr(p + 0x014)); // 0270068CDFC0 0x14 M_OffsetUnits               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_OffsetFactor                            = GetSingle(new IntPtr(p + 0x018)); // 0270068CDFE0 0x18 M_OffsetFactor              ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_DepthClip                               = GetSByte(new IntPtr(p + 0x01C)); // 0270068CE000 0x1C M_DepthClip                 ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.M_Conservative                            = GetSByte(new IntPtr(p + 0x01D)); // 0270068CE020 0x1D M_Conservative              ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.M_Padding1                                = GetSByte(new IntPtr(p + 0x01E)); // 0270068CE040 0x1E M_Padding1                  ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.M_Padding2                                = GetSByte(new IntPtr(p + 0x01F)); // 0270068CE060 0x1F M_Padding2                  ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )

            return value;
        }
    }
}
