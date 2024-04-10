using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DataPointer                              00018669BB50 ModelPrimitiveType ulong ulong ulong UInt64
    // 018 Size                                     000186698DF0 ModelPrimitiveType uint uint uint UInt32
    // 01C Reserved                                 0001865F2F90 ModelPrimitiveType int int int Int32
    public partial class EventData : DataModel
    {
        public ulong                                    DataPointer                             { get; set; }
        public uint                                     Size                                    { get; set; }
        public int                                      Reserved                                { get; set; }

        public static EventData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventData() { Pointer= p0 };

            value.DataPointer                               = GetUInt64(new IntPtr(p + 0x010)); // 02466BAB3FD8 0x10 DataPointer                 ( 00018669BB50 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.Size                                      = GetUInt32(new IntPtr(p + 0x018)); // 02466BAB3FF8 0x18 Size                        ( 000186698DF0 ModelPrimitiveType uint uint uint UInt32 )
            value.Reserved                                  = GetInt32(new IntPtr(p + 0x01C)); // 02466BAB4018 0x1C Reserved                    ( 0001865F2F90 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
