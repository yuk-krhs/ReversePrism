using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 RequiredDearness                         0001865F36C0 ModelPrimitiveType int int int Int32
    // 01C Dearness                                 0001865F36C0 ModelPrimitiveType int int int Int32
    // 020 MstIdolId                                0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class DearnessCondition
    {
        public int                                      RequiredDearness                        { get; set; }
        public int                                      Dearness                                { get; set; }
        public int                                      MstIdolId                               { get; set; }

        public static DearnessCondition? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DearnessCondition();

            value.RequiredDearness                          = GetInt32(new IntPtr(p + 0x018)); // 0270D4D20318 0x18 RequiredDearness            ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Dearness                                  = GetInt32(new IntPtr(p + 0x01C)); // 0270D4D20338 0x1C Dearness                    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.MstIdolId                                 = GetInt32(new IntPtr(p + 0x020)); // 0270D4D20358 0x20 MstIdolId                   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
