using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 RequiredFan                              ModelPrimitiveType int int int Int32
    // 01C Fan                                      ModelPrimitiveType int int int Int32
    // 020 MstIdolId                                ModelPrimitiveType int int int Int32
    public partial class FanCondition : DataModel
    {
        public int                                      RequiredFan                             { get; set; }
        public int                                      Fan                                     { get; set; }
        public int                                      MstIdolId                               { get; set; }

        public static FanCondition? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FanCondition() { Pointer= p0 };

            value.RequiredFan                               = GetInt32(new IntPtr(p + 0x018)); // 0x18 RequiredFan                 ( ModelPrimitiveType int int int Int32 )
            value.Fan                                       = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Fan                         ( ModelPrimitiveType int int int Int32 )
            value.MstIdolId                                 = GetInt32(new IntPtr(p + 0x020)); // 0x20 MstIdolId                   ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
