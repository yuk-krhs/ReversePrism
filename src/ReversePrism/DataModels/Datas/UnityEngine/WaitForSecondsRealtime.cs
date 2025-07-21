using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 WaitTime                                 ModelPrimitiveType float float float Single
    // 014 M_WaitUntilTime                          ModelPrimitiveType float float float Single
    public partial class WaitForSecondsRealtime : DataModel
    {
        public float                                    WaitTime                                { get; set; }
        public float                                    M_WaitUntilTime                         { get; set; }

        public static WaitForSecondsRealtime? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WaitForSecondsRealtime() { Pointer= p0 };

            value.WaitTime                                  = GetSingle(new IntPtr(p + 0x010)); // 0x10 WaitTime                    ( ModelPrimitiveType float float float Single )
            value.M_WaitUntilTime                           = GetSingle(new IntPtr(p + 0x014)); // 0x14 M_WaitUntilTime             ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
