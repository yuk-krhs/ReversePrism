using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<DateTime> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 YearFieldNumber                          int IL2CPP_TYPE_I4
    // 018 Year                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MonthFieldNumber                         int IL2CPP_TYPE_I4
    // 01C Month                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 DayFieldNumber                           int IL2CPP_TYPE_I4
    // 020 Day                                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 HoursFieldNumber                         int IL2CPP_TYPE_I4
    // 024 Hours                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MinutesFieldNumber                       int IL2CPP_TYPE_I4
    // 028 Minutes                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 SecondsFieldNumber                       int IL2CPP_TYPE_I4
    // 02C Seconds                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 NanosFieldNumber                         int IL2CPP_TYPE_I4
    // 030 Nanos                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 UtcOffsetFieldNumber                     int IL2CPP_TYPE_I4
    // 000 TimeZoneFieldNumber                      int IL2CPP_TYPE_I4
    // 038 timeOffset_                              <object> IL2CPP_TYPE_OBJECT
    // 040 TimeOffsetCase                           00018657BAE0 ModelEnumType TimeOffsetOneofCase TimeOffsetOneofCase TimeOffsetOneofCase Int32
    public partial class DateTime
    {
        public int                                      Year                                    { get; set; }
        public int                                      Month                                   { get; set; }
        public int                                      Day                                     { get; set; }
        public int                                      Hours                                   { get; set; }
        public int                                      Minutes                                 { get; set; }
        public int                                      Seconds                                 { get; set; }
        public int                                      Nanos                                   { get; set; }
        public TimeOffsetOneofCase                      TimeOffsetCase                          { get; set; }

        public static DateTime? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DateTime();

            value.Year                                      = GetInt32(new IntPtr(p + 0x018)); // 0270DA68B960 0x18 Year                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Month                                     = GetInt32(new IntPtr(p + 0x01C)); // 0270DA68B9A0 0x1C Month                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Day                                       = GetInt32(new IntPtr(p + 0x020)); // 0270DA68B9E0 0x20 Day                         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Hours                                     = GetInt32(new IntPtr(p + 0x024)); // 0270DA68BA20 0x24 Hours                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Minutes                                   = GetInt32(new IntPtr(p + 0x028)); // 0270DA68BA60 0x28 Minutes                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Seconds                                   = GetInt32(new IntPtr(p + 0x02C)); // 0270DA68BAA0 0x2C Seconds                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Nanos                                     = GetInt32(new IntPtr(p + 0x030)); // 0270DA68BAE0 0x30 Nanos                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.TimeOffsetCase                            = (TimeOffsetOneofCase)GetInt32(new IntPtr(p + 0x040)); // 0270DA68BB60 0x40 TimeOffsetCase              ( 00018657BAE0 ModelEnumType TimeOffsetOneofCase TimeOffsetOneofCase TimeOffsetOneofCase Int32 )

            return value;
        }
    }
}
