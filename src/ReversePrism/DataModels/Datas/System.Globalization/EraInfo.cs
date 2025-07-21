using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Era                                      ModelPrimitiveType int int int Int32
    // 018 Ticks                                    ModelPrimitiveType long long long Int64
    // 020 YearOffset                               ModelPrimitiveType int int int Int32
    // 024 MinEraYear                               ModelPrimitiveType int int int Int32
    // 028 MaxEraYear                               ModelPrimitiveType int int int Int32
    // 030 EraName                                  ModelPrimitiveType string string string String
    // 038 AbbrevEraName                            ModelPrimitiveType string string string String
    // 040 EnglishEraName                           ModelPrimitiveType string string string String
    public partial class EraInfo : DataModel
    {
        public int                                      Era                                     { get; set; }
        public long                                     Ticks                                   { get; set; }
        public int                                      YearOffset                              { get; set; }
        public int                                      MinEraYear                              { get; set; }
        public int                                      MaxEraYear                              { get; set; }
        public string                                   EraName                                 { get; set; }
        public string                                   AbbrevEraName                           { get; set; }
        public string                                   EnglishEraName                          { get; set; }

        public static EraInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EraInfo() { Pointer= p0 };

            value.Era                                       = GetInt32(new IntPtr(p + 0x010)); // 0x10 Era                         ( ModelPrimitiveType int int int Int32 )
            value.Ticks                                     = GetInt64(new IntPtr(p + 0x018)); // 0x18 Ticks                       ( ModelPrimitiveType long long long Int64 )
            value.YearOffset                                = GetInt32(new IntPtr(p + 0x020)); // 0x20 YearOffset                  ( ModelPrimitiveType int int int Int32 )
            value.MinEraYear                                = GetInt32(new IntPtr(p + 0x024)); // 0x24 MinEraYear                  ( ModelPrimitiveType int int int Int32 )
            value.MaxEraYear                                = GetInt32(new IntPtr(p + 0x028)); // 0x28 MaxEraYear                  ( ModelPrimitiveType int int int Int32 )
            value.EraName                                   = GetString(new IntPtr(p + 0x030)); // 0x30 EraName                     ( ModelPrimitiveType string string string String )
            value.AbbrevEraName                             = GetString(new IntPtr(p + 0x038)); // 0x38 AbbrevEraName               ( ModelPrimitiveType string string string String )
            value.EnglishEraName                            = GetString(new IntPtr(p + 0x040)); // 0x40 EnglishEraName              ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
