using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 NanosPerSecond                           long IL2CPP_TYPE_I8
    // 000 NanosPerTick                             long IL2CPP_TYPE_I8
    // 000 TicksPerSecond                           long IL2CPP_TYPE_I8
    // 000 Native                                   NativeMethods IL2CPP_TYPE_CLASS
    // 008 UnixEpoch                                DateTime IL2CPP_TYPE_VALUETYPE
    // 010 Tv_sec                                   0001865F7700 ModelPrimitiveType long long long Int64
    // 018 Tv_nsec                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C Clock_type                               0001865BA550 ModelEnumType ClockType ClockType ClockType Int32
    public partial class Timespec
    {
        public long                                     Tv_sec                                  { get; set; }
        public int                                      Tv_nsec                                 { get; set; }
        public ClockType                                Clock_type                              { get; set; }

        public static Timespec? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Timespec();

            value.Tv_sec                                    = GetInt64(new IntPtr(p + 0x010)); // 0270D0ED9DD0 0x10 Tv_sec                      ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.Tv_nsec                                   = GetInt32(new IntPtr(p + 0x018)); // 0270D0ED9DF0 0x18 Tv_nsec                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Clock_type                                = (ClockType)GetInt32(new IntPtr(p + 0x01C)); // 0270D0ED9E10 0x1C Clock_type                  ( 0001865BA550 ModelEnumType ClockType ClockType ClockType Int32 )

            return value;
        }
    }
}
