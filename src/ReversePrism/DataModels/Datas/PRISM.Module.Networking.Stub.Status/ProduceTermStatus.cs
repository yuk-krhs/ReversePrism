using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ProduceTermStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 SeasonFieldNumber                        int IL2CPP_TYPE_I4
    // 018 Season                                   ModelPrimitiveType int int int Int32
    // 000 WeekFieldNumber                          int IL2CPP_TYPE_I4
    // 01C Week                                     ModelPrimitiveType int int int Int32
    // 000 IsAuditionFieldNumber                    int IL2CPP_TYPE_I4
    // 020 IsAudition                               ModelPrimitiveType bool bool bool Bool
    // 000 WeekLimitFieldNumber                     int IL2CPP_TYPE_I4
    // 024 WeekLimit                                ModelPrimitiveType int int int Int32
    // 000 TotalWeekLimitFieldNumber                int IL2CPP_TYPE_I4
    // 028 TotalWeekLimit                           ModelPrimitiveType int int int Int32
    // 000 TotalWeekFieldNumber                     int IL2CPP_TYPE_I4
    // 02C TotalWeek                                ModelPrimitiveType int int int Int32
    public partial class ProduceTermStatus : DataModel
    {
        public int                                      Season                                  { get; set; }
        public int                                      Week                                    { get; set; }
        public bool                                     IsAudition                              { get; set; }
        public int                                      WeekLimit                               { get; set; }
        public int                                      TotalWeekLimit                          { get; set; }
        public int                                      TotalWeek                               { get; set; }

        public static ProduceTermStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceTermStatus() { Pointer= p0 };

            value.Season                                    = GetInt32(new IntPtr(p + 0x018)); // 0x18 Season                      ( ModelPrimitiveType int int int Int32 )
            value.Week                                      = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Week                        ( ModelPrimitiveType int int int Int32 )
            value.IsAudition                                = GetBool(new IntPtr(p + 0x020)); // 0x20 IsAudition                  ( ModelPrimitiveType bool bool bool Bool )
            value.WeekLimit                                 = GetInt32(new IntPtr(p + 0x024)); // 0x24 WeekLimit                   ( ModelPrimitiveType int int int Int32 )
            value.TotalWeekLimit                            = GetInt32(new IntPtr(p + 0x028)); // 0x28 TotalWeekLimit              ( ModelPrimitiveType int int int Int32 )
            value.TotalWeek                                 = GetInt32(new IntPtr(p + 0x02C)); // 0x2C TotalWeek                   ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
