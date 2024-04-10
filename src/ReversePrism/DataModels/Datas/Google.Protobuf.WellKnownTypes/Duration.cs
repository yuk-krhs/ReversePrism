using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<Duration> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 SecondsFieldNumber                       int IL2CPP_TYPE_I4
    // 018 Seconds                                  0001865F7700 ModelPrimitiveType long long long Int64
    // 000 NanosFieldNumber                         int IL2CPP_TYPE_I4
    // 020 Nanos                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 NanosecondsPerSecond                     int IL2CPP_TYPE_I4
    // 000 NanosecondsPerTick                       int IL2CPP_TYPE_I4
    // 000 MaxSeconds                               long IL2CPP_TYPE_I8
    // 000 MinSeconds                               long IL2CPP_TYPE_I8
    // 000 MaxNanoseconds                           int IL2CPP_TYPE_I4
    // 000 MinNanoseconds                           int IL2CPP_TYPE_I4
    public partial class Duration : DataModel
    {
        public long                                     Seconds                                 { get; set; }
        public int                                      Nanos                                   { get; set; }

        public static Duration? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Duration() { Pointer= p0 };

            value.Seconds                                   = GetInt64(new IntPtr(p + 0x018)); // 02466A4CE6A8 0x18 Seconds                     ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.Nanos                                     = GetInt32(new IntPtr(p + 0x020)); // 02466A4CE6E8 0x20 Nanos                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
