using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 GiveupMessage                            ModelPrimitiveType string string string String
    public partial class ProduceGiveUpConfirmationPopupParam : DataModel
    {
        public string                                   GiveupMessage                           { get; set; }

        public static ProduceGiveUpConfirmationPopupParam? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceGiveUpConfirmationPopupParam() { Pointer= p0 };

            value.GiveupMessage                             = GetString(new IntPtr(p + 0x090)); // 0x90 GiveupMessage               ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
