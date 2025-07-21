using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DataPointer                              ModelPrimitiveType ulong ulong ulong UInt64
    // 018 Size                                     ModelPrimitiveType uint uint uint UInt32
    // 01C Reserved                                 ModelPrimitiveType int int int Int32
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

            value.DataPointer                               = GetUInt64(new IntPtr(p + 0x010)); // 0x10 DataPointer                 ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.Size                                      = GetUInt32(new IntPtr(p + 0x018)); // 0x18 Size                        ( ModelPrimitiveType uint uint uint UInt32 )
            value.Reserved                                  = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Reserved                    ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
