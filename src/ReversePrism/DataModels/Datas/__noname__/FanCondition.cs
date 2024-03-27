using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 RequiredFan                              0001865F36C0 ModelPrimitiveType int int int Int32
    // 01C Fan                                      0001865F36C0 ModelPrimitiveType int int int Int32
    // 020 MstIdolId                                0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class FanCondition
    {
        public int                                      RequiredFan                             { get; set; }
        public int                                      Fan                                     { get; set; }
        public int                                      MstIdolId                               { get; set; }

        public static FanCondition? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FanCondition();

            value.RequiredFan                               = GetInt32(new IntPtr(p + 0x018)); // 0270D4D20A90 0x18 RequiredFan                 ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Fan                                       = GetInt32(new IntPtr(p + 0x01C)); // 0270D4D20AB0 0x1C Fan                         ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.MstIdolId                                 = GetInt32(new IntPtr(p + 0x020)); // 0270D4D20AD0 0x20 MstIdolId                   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
