using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 KatmaiTimeScaleMultiplicator             int[] IL2CPP_TYPE_SZARRAY
    // 008 SQLTicksPerMillisecond                   double IL2CPP_TYPE_R8
    // 010 SQLTicksPerSecond                        ModelPrimitiveType int int int Int32
    // 014 SQLTicksPerMinute                        ModelPrimitiveType int int int Int32
    // 018 SQLTicksPerHour                          ModelPrimitiveType int int int Int32
    // 01C SQLTicksPerDay                           ModelPrimitiveType int int int Int32
    public partial class BinXmlDateTime : DataModel
    {
        public int                                      SQLTicksPerSecond                       { get; set; }
        public int                                      SQLTicksPerMinute                       { get; set; }
        public int                                      SQLTicksPerHour                         { get; set; }
        public int                                      SQLTicksPerDay                          { get; set; }

        public static BinXmlDateTime? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BinXmlDateTime() { Pointer= p0 };

            value.SQLTicksPerSecond                         = GetInt32(new IntPtr(p + 0x010)); // 0x10 SQLTicksPerSecond           ( ModelPrimitiveType int int int Int32 )
            value.SQLTicksPerMinute                         = GetInt32(new IntPtr(p + 0x014)); // 0x14 SQLTicksPerMinute           ( ModelPrimitiveType int int int Int32 )
            value.SQLTicksPerHour                           = GetInt32(new IntPtr(p + 0x018)); // 0x18 SQLTicksPerHour             ( ModelPrimitiveType int int int Int32 )
            value.SQLTicksPerDay                            = GetInt32(new IntPtr(p + 0x01C)); // 0x1C SQLTicksPerDay              ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
