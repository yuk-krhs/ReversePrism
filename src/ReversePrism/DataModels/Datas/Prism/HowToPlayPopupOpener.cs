using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 HowToPlayPopupResourceConfigRef          000186671E00 ModelPrimitiveType string string string String
    // 028 HowToPlayPopupResourceConfigRefPc        000186671E00 ModelPrimitiveType string string string String
    public partial class HowToPlayPopupOpener : DataModel
    {
        public string                                   HowToPlayPopupResourceConfigRef         { get; set; }
        public string                                   HowToPlayPopupResourceConfigRefPc       { get; set; }

        public static HowToPlayPopupOpener? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HowToPlayPopupOpener() { Pointer= p0 };

            value.HowToPlayPopupResourceConfigRef           = GetString(new IntPtr(p + 0x020)); // 024664CA7BB8 0x20 HowToPlayPopupResourceConfigRef ( 000186671E00 ModelPrimitiveType string string string String )
            value.HowToPlayPopupResourceConfigRefPc         = GetString(new IntPtr(p + 0x028)); // 024664CA7BD8 0x28 HowToPlayPopupResourceConfigRefPc ( 000186671E00 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
