using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<TimeOfDay> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 HoursFieldNumber                         int IL2CPP_TYPE_I4
    // 018 Hours                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MinutesFieldNumber                       int IL2CPP_TYPE_I4
    // 01C Minutes                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 SecondsFieldNumber                       int IL2CPP_TYPE_I4
    // 020 Seconds                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 NanosFieldNumber                         int IL2CPP_TYPE_I4
    // 024 Nanos                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class TimeOfDay : DataModel
    {
        public int                                      Hours                                   { get; set; }
        public int                                      Minutes                                 { get; set; }
        public int                                      Seconds                                 { get; set; }
        public int                                      Nanos                                   { get; set; }

        public static TimeOfDay? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TimeOfDay() { Pointer= p0 };

            value.Hours                                     = GetInt32(new IntPtr(p + 0x018)); // 02466A715110 0x18 Hours                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Minutes                                   = GetInt32(new IntPtr(p + 0x01C)); // 02466A715150 0x1C Minutes                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Seconds                                   = GetInt32(new IntPtr(p + 0x020)); // 02466A715190 0x20 Seconds                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Nanos                                     = GetInt32(new IntPtr(p + 0x024)); // 02466A7151D0 0x24 Nanos                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
