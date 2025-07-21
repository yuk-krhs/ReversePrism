using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Time                                   ModelPrimitiveType float float float Single
    // 014 M_Value                                  ModelPrimitiveType float float float Single
    // 018 M_InTangent                              ModelPrimitiveType float float float Single
    // 01C M_OutTangent                             ModelPrimitiveType float float float Single
    // 020 M_WeightedMode                           ModelPrimitiveType int int int Int32
    // 024 M_InWeight                               ModelPrimitiveType float float float Single
    // 028 M_OutWeight                              ModelPrimitiveType float float float Single
    public partial class Keyframe : DataModel
    {
        public float                                    M_Time                                  { get; set; }
        public float                                    M_Value                                 { get; set; }
        public float                                    M_InTangent                             { get; set; }
        public float                                    M_OutTangent                            { get; set; }
        public int                                      M_WeightedMode                          { get; set; }
        public float                                    M_InWeight                              { get; set; }
        public float                                    M_OutWeight                             { get; set; }

        public static Keyframe? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Keyframe() { Pointer= p0 };

            value.M_Time                                    = GetSingle(new IntPtr(p + 0x010)); // 0x10 M_Time                      ( ModelPrimitiveType float float float Single )
            value.M_Value                                   = GetSingle(new IntPtr(p + 0x014)); // 0x14 M_Value                     ( ModelPrimitiveType float float float Single )
            value.M_InTangent                               = GetSingle(new IntPtr(p + 0x018)); // 0x18 M_InTangent                 ( ModelPrimitiveType float float float Single )
            value.M_OutTangent                              = GetSingle(new IntPtr(p + 0x01C)); // 0x1C M_OutTangent                ( ModelPrimitiveType float float float Single )
            value.M_WeightedMode                            = GetInt32(new IntPtr(p + 0x020)); // 0x20 M_WeightedMode              ( ModelPrimitiveType int int int Int32 )
            value.M_InWeight                                = GetSingle(new IntPtr(p + 0x024)); // 0x24 M_InWeight                  ( ModelPrimitiveType float float float Single )
            value.M_OutWeight                               = GetSingle(new IntPtr(p + 0x028)); // 0x28 M_OutWeight                 ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
