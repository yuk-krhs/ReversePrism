using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 From                                     ModelPrimitiveType ulong ulong ulong UInt64
    // 018 To                                       ModelPrimitiveType ulong ulong ulong UInt64
    public partial class AllowRange : DataModel
    {
        public ulong                                    From                                    { get; set; }
        public ulong                                    To                                      { get; set; }

        public static AllowRange? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AllowRange() { Pointer= p0 };

            value.From                                      = GetUInt64(new IntPtr(p + 0x010)); // 0x10 From                        ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.To                                        = GetUInt64(new IntPtr(p + 0x018)); // 0x18 To                          ( ModelPrimitiveType ulong ulong ulong UInt64 )

            return value;
        }
    }
}
