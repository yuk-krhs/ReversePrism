using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<Date> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 YearFieldNumber                          int IL2CPP_TYPE_I4
    // 018 Year                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MonthFieldNumber                         int IL2CPP_TYPE_I4
    // 01C Month                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 DayFieldNumber                           int IL2CPP_TYPE_I4
    // 020 Day                                      0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class Date : DataModel
    {
        public int                                      Year                                    { get; set; }
        public int                                      Month                                   { get; set; }
        public int                                      Day                                     { get; set; }

        public static Date? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Date() { Pointer= p0 };

            value.Year                                      = GetInt32(new IntPtr(p + 0x018)); // 02466A6D50C0 0x18 Year                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Month                                     = GetInt32(new IntPtr(p + 0x01C)); // 02466A6D5100 0x1C Month                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Day                                       = GetInt32(new IntPtr(p + 0x020)); // 02466A6D5140 0x20 Day                         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
