using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 buffer                                   IntPtr IL2CPP_TYPE_PTR
    // 018 Length                                   ModelPrimitiveType int int int Int32
    // 01C Capacity                                 ModelPrimitiveType int int int Int32
    // 020 BitBuffer                                ModelPrimitiveType ulong ulong ulong UInt64
    // 028 BitIndex                                 ModelPrimitiveType int int int Int32
    // 02C FailedWrites                             ModelPrimitiveType int int int Int32
    public partial class StreamData : DataModel
    {
        public int                                      Length                                  { get; set; }
        public int                                      Capacity                                { get; set; }
        public ulong                                    BitBuffer                               { get; set; }
        public int                                      BitIndex                                { get; set; }
        public int                                      FailedWrites                            { get; set; }

        public static StreamData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StreamData() { Pointer= p0 };

            value.Length                                    = GetInt32(new IntPtr(p + 0x018)); // 0x18 Length                      ( ModelPrimitiveType int int int Int32 )
            value.Capacity                                  = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Capacity                    ( ModelPrimitiveType int int int Int32 )
            value.BitBuffer                                 = GetUInt64(new IntPtr(p + 0x020)); // 0x20 BitBuffer                   ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.BitIndex                                  = GetInt32(new IntPtr(p + 0x028)); // 0x28 BitIndex                    ( ModelPrimitiveType int int int Int32 )
            value.FailedWrites                              = GetInt32(new IntPtr(p + 0x02C)); // 0x2C FailedWrites                ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
