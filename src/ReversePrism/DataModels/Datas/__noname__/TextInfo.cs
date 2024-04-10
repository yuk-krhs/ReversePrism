using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Target                                   0001866F95C0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 018 Normal                                   00018666A660 ModelClassType TextStateInfo TextStateInfo TextStateInfo Pointer
    // 020 Pressed                                  00018666A660 ModelClassType TextStateInfo TextStateInfo TextStateInfo Pointer
    // 028 Selected                                 00018666A660 ModelClassType TextStateInfo TextStateInfo TextStateInfo Pointer
    // 030 Disabled                                 00018666A660 ModelClassType TextStateInfo TextStateInfo TextStateInfo Pointer
    public partial class TextInfo : DataModel
    {
        public UITextMeshProUGUI?                       Target                                  { get; set; }
        public TextStateInfo?                           Normal                                  { get; set; }
        public TextStateInfo?                           Pressed                                 { get; set; }
        public TextStateInfo?                           Selected                                { get; set; }
        public TextStateInfo?                           Disabled                                { get; set; }

        public static TextInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TextInfo() { Pointer= p0 };

            value.Target                                    = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x010), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B0A76E0 0x10 Target                      ( 0001866F95C0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Normal                                    = GetObject<TextStateInfo>(new IntPtr(p + 0x018), ReversePrism.DataModels.TextStateInfo.FromPointer); // 02466B0A7700 0x18 Normal                      ( 00018666A660 ModelClassType TextStateInfo TextStateInfo TextStateInfo Pointer )
            value.Pressed                                   = GetObject<TextStateInfo>(new IntPtr(p + 0x020), ReversePrism.DataModels.TextStateInfo.FromPointer); // 02466B0A7720 0x20 Pressed                     ( 00018666A660 ModelClassType TextStateInfo TextStateInfo TextStateInfo Pointer )
            value.Selected                                  = GetObject<TextStateInfo>(new IntPtr(p + 0x028), ReversePrism.DataModels.TextStateInfo.FromPointer); // 02466B0A7740 0x28 Selected                    ( 00018666A660 ModelClassType TextStateInfo TextStateInfo TextStateInfo Pointer )
            value.Disabled                                  = GetObject<TextStateInfo>(new IntPtr(p + 0x030), ReversePrism.DataModels.TextStateInfo.FromPointer); // 02466B0A7760 0x30 Disabled                    ( 00018666A660 ModelClassType TextStateInfo TextStateInfo TextStateInfo Pointer )

            return value;
        }
    }
}
