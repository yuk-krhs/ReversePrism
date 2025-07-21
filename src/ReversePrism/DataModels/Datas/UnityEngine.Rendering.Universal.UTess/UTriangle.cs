using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Va                                       ModelEnumType float2 float2 float2 Int32
    // 018 Vb                                       ModelEnumType float2 float2 float2 Int32
    // 020 Vc                                       ModelEnumType float2 float2 float2 Int32
    // 028 C                                        ModelEnumType UCircle UCircle UCircle Int32
    // 034 Area                                     ModelPrimitiveType float float float Single
    // 038 Indices                                  ModelEnumType int3 int3 int3 Int32
    public partial class UTriangle : DataModel
    {
        public float2                                   Va                                      { get; set; }
        public float2                                   Vb                                      { get; set; }
        public float2                                   Vc                                      { get; set; }
        public UCircle                                  C                                       { get; set; }
        public float                                    Area                                    { get; set; }
        public int3                                     Indices                                 { get; set; }

        public static UTriangle? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UTriangle() { Pointer= p0 };

            value.Va                                        = (float2)GetInt32(new IntPtr(p + 0x010)); // 0x10 Va                          ( ModelEnumType float2 float2 float2 Int32 )
            value.Vb                                        = (float2)GetInt32(new IntPtr(p + 0x018)); // 0x18 Vb                          ( ModelEnumType float2 float2 float2 Int32 )
            value.Vc                                        = (float2)GetInt32(new IntPtr(p + 0x020)); // 0x20 Vc                          ( ModelEnumType float2 float2 float2 Int32 )
            value.C                                         = (UCircle)GetInt32(new IntPtr(p + 0x028)); // 0x28 C                           ( ModelEnumType UCircle UCircle UCircle Int32 )
            value.Area                                      = GetSingle(new IntPtr(p + 0x034)); // 0x34 Area                        ( ModelPrimitiveType float float float Single )
            value.Indices                                   = (int3)GetInt32(new IntPtr(p + 0x038)); // 0x38 Indices                     ( ModelEnumType int3 int3 int3 Int32 )

            return value;
        }
    }
}
