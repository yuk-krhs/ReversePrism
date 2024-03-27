using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TextComponent                            0001866F95C0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 Number                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class BadgeNumber
    {
        public UITextMeshProUGUI?                       TextComponent                           { get; set; }
        public int                                      Number                                  { get; set; }

        public static BadgeNumber? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BadgeNumber();

            value.TextComponent                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 027004F66030 0x20 TextComponent               ( 0001866F95C0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Number                                    = GetInt32(new IntPtr(p + 0x028)); // 027004F66050 0x28 Number                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
