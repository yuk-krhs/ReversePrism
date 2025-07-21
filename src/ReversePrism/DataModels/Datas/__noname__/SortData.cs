using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FlagAndTeamId                            ModelPrimitiveType uint uint uint UInt32
    // 014 PrimitiveIndex                           ModelPrimitiveType int int int Int32
    // 018 FirstMinMax                              ModelEnumType float2 float2 float2 Int32
    // 020 SecondMinMax                             ModelEnumType float2 float2 float2 Int32
    // 028 ThirdMinMax                              ModelEnumType float2 float2 float2 Int32
    public partial class SortData : DataModel
    {
        public uint                                     FlagAndTeamId                           { get; set; }
        public int                                      PrimitiveIndex                          { get; set; }
        public float2                                   FirstMinMax                             { get; set; }
        public float2                                   SecondMinMax                            { get; set; }
        public float2                                   ThirdMinMax                             { get; set; }

        public static SortData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SortData() { Pointer= p0 };

            value.FlagAndTeamId                             = GetUInt32(new IntPtr(p + 0x010)); // 0x10 FlagAndTeamId               ( ModelPrimitiveType uint uint uint UInt32 )
            value.PrimitiveIndex                            = GetInt32(new IntPtr(p + 0x014)); // 0x14 PrimitiveIndex              ( ModelPrimitiveType int int int Int32 )
            value.FirstMinMax                               = (float2)GetInt32(new IntPtr(p + 0x018)); // 0x18 FirstMinMax                 ( ModelEnumType float2 float2 float2 Int32 )
            value.SecondMinMax                              = (float2)GetInt32(new IntPtr(p + 0x020)); // 0x20 SecondMinMax                ( ModelEnumType float2 float2 float2 Int32 )
            value.ThirdMinMax                               = (float2)GetInt32(new IntPtr(p + 0x028)); // 0x28 ThirdMinMax                 ( ModelEnumType float2 float2 float2 Int32 )

            return value;
        }
    }
}
