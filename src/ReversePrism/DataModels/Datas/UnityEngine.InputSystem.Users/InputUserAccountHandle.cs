using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_ApiName                                ModelPrimitiveType string string string String
    // 018 M_Handle                                 ModelPrimitiveType ulong ulong ulong UInt64
    public partial class InputUserAccountHandle : DataModel
    {
        public string                                   M_ApiName                               { get; set; }
        public ulong                                    M_Handle                                { get; set; }

        public static InputUserAccountHandle? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InputUserAccountHandle() { Pointer= p0 };

            value.M_ApiName                                 = GetString(new IntPtr(p + 0x010)); // 0x10 M_ApiName                   ( ModelPrimitiveType string string string String )
            value.M_Handle                                  = GetUInt64(new IntPtr(p + 0x018)); // 0x18 M_Handle                    ( ModelPrimitiveType ulong ulong ulong UInt64 )

            return value;
        }
    }
}
