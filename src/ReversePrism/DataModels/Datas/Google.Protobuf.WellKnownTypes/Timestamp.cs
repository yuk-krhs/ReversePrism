using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<Timestamp> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 SecondsFieldNumber                       int IL2CPP_TYPE_I4
    // 018 Seconds                                  0001865F7700 ModelPrimitiveType long long long Int64
    // 000 NanosFieldNumber                         int IL2CPP_TYPE_I4
    // 020 Nanos                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 008 UnixEpoch                                DateTime IL2CPP_TYPE_VALUETYPE
    // 000 BclSecondsAtUnixEpoch                    long IL2CPP_TYPE_I8
    // 000 UnixSecondsAtBclMaxValue                 long IL2CPP_TYPE_I8
    // 000 UnixSecondsAtBclMinValue                 long IL2CPP_TYPE_I8
    // 000 MaxNanos                                 int IL2CPP_TYPE_I4
    public partial class Timestamp : DataModel
    {
        public long                                     Seconds                                 { get; set; }
        public int                                      Nanos                                   { get; set; }

        public static Timestamp? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Timestamp() { Pointer= p0 };

            value.Seconds                                   = GetInt64(new IntPtr(p + 0x018)); // 024660D4A018 0x18 Seconds                     ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.Nanos                                     = GetInt32(new IntPtr(p + 0x020)); // 024660D4A058 0x20 Nanos                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
