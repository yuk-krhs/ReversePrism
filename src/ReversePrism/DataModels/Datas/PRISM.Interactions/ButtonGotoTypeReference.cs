using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TransferAccount                          ModelPrimitiveType string string string String
    // 028 ProduceResumePopup                       ModelPrimitiveType string string string String
    public partial class ButtonGotoTypeReference : DataModel
    {
        public string                                   TransferAccount                         { get; set; }
        public string                                   ProduceResumePopup                      { get; set; }

        public static ButtonGotoTypeReference? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ButtonGotoTypeReference() { Pointer= p0 };

            value.TransferAccount                           = GetString(new IntPtr(p + 0x020)); // 0x20 TransferAccount             ( ModelPrimitiveType string string string String )
            value.ProduceResumePopup                        = GetString(new IntPtr(p + 0x028)); // 0x28 ProduceResumePopup          ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
