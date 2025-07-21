using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SwitchID                                 ModelPrimitiveType string string string String
    // 028 SwitchUnitNo                             ModelPrimitiveType int int int Int32
    public partial class SwitchIDHolder : DataModel
    {
        public string                                   SwitchID                                { get; set; }
        public int                                      SwitchUnitNo                            { get; set; }

        public static SwitchIDHolder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SwitchIDHolder() { Pointer= p0 };

            value.SwitchID                                  = GetString(new IntPtr(p + 0x020)); // 0x20 SwitchID                    ( ModelPrimitiveType string string string String )
            value.SwitchUnitNo                              = GetInt32(new IntPtr(p + 0x028)); // 0x28 SwitchUnitNo                ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
