using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Era                                      0001865F2F90 ModelPrimitiveType int int int Int32
    // 018 Ticks                                    0001865F79C0 ModelPrimitiveType long long long Int64
    // 020 YearOffset                               0001865F2F90 ModelPrimitiveType int int int Int32
    // 024 MinEraYear                               0001865F2F90 ModelPrimitiveType int int int Int32
    // 028 MaxEraYear                               0001865F2F90 ModelPrimitiveType int int int Int32
    // 030 EraName                                  000186671BA0 ModelPrimitiveType string string string String
    // 038 AbbrevEraName                            000186671BA0 ModelPrimitiveType string string string String
    // 040 EnglishEraName                           000186671BA0 ModelPrimitiveType string string string String
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

            value.Era                                       = GetInt32(new IntPtr(p + 0x010)); // 024662FD6368 0x10 Era                         ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Ticks                                     = GetInt64(new IntPtr(p + 0x018)); // 024662FD6388 0x18 Ticks                       ( 0001865F79C0 ModelPrimitiveType long long long Int64 )
            value.YearOffset                                = GetInt32(new IntPtr(p + 0x020)); // 024662FD63A8 0x20 YearOffset                  ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.MinEraYear                                = GetInt32(new IntPtr(p + 0x024)); // 024662FD63C8 0x24 MinEraYear                  ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.MaxEraYear                                = GetInt32(new IntPtr(p + 0x028)); // 024662FD63E8 0x28 MaxEraYear                  ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.EraName                                   = GetString(new IntPtr(p + 0x030)); // 024662FD6408 0x30 EraName                     ( 000186671BA0 ModelPrimitiveType string string string String )
            value.AbbrevEraName                             = GetString(new IntPtr(p + 0x038)); // 024662FD6428 0x38 AbbrevEraName               ( 000186671BA0 ModelPrimitiveType string string string String )
            value.EnglishEraName                            = GetString(new IntPtr(p + 0x040)); // 024662FD6448 0x40 EnglishEraName              ( 000186671BA0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
