using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Weight0                                ModelPrimitiveType float float float Single
    // 014 M_Weight1                                ModelPrimitiveType float float float Single
    // 018 M_Weight2                                ModelPrimitiveType float float float Single
    // 01C M_Weight3                                ModelPrimitiveType float float float Single
    // 020 M_BoneIndex0                             ModelPrimitiveType int int int Int32
    // 024 M_BoneIndex1                             ModelPrimitiveType int int int Int32
    // 028 M_BoneIndex2                             ModelPrimitiveType int int int Int32
    // 02C M_BoneIndex3                             ModelPrimitiveType int int int Int32
    public partial class BoneWeight : DataModel
    {
        public float                                    M_Weight0                               { get; set; }
        public float                                    M_Weight1                               { get; set; }
        public float                                    M_Weight2                               { get; set; }
        public float                                    M_Weight3                               { get; set; }
        public int                                      M_BoneIndex0                            { get; set; }
        public int                                      M_BoneIndex1                            { get; set; }
        public int                                      M_BoneIndex2                            { get; set; }
        public int                                      M_BoneIndex3                            { get; set; }

        public static BoneWeight? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BoneWeight() { Pointer= p0 };

            value.M_Weight0                                 = GetSingle(new IntPtr(p + 0x010)); // 0x10 M_Weight0                   ( ModelPrimitiveType float float float Single )
            value.M_Weight1                                 = GetSingle(new IntPtr(p + 0x014)); // 0x14 M_Weight1                   ( ModelPrimitiveType float float float Single )
            value.M_Weight2                                 = GetSingle(new IntPtr(p + 0x018)); // 0x18 M_Weight2                   ( ModelPrimitiveType float float float Single )
            value.M_Weight3                                 = GetSingle(new IntPtr(p + 0x01C)); // 0x1C M_Weight3                   ( ModelPrimitiveType float float float Single )
            value.M_BoneIndex0                              = GetInt32(new IntPtr(p + 0x020)); // 0x20 M_BoneIndex0                ( ModelPrimitiveType int int int Int32 )
            value.M_BoneIndex1                              = GetInt32(new IntPtr(p + 0x024)); // 0x24 M_BoneIndex1                ( ModelPrimitiveType int int int Int32 )
            value.M_BoneIndex2                              = GetInt32(new IntPtr(p + 0x028)); // 0x28 M_BoneIndex2                ( ModelPrimitiveType int int int Int32 )
            value.M_BoneIndex3                              = GetInt32(new IntPtr(p + 0x02C)); // 0x2C M_BoneIndex3                ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
