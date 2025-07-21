using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Target                                   ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 018 Normal                                   ModelClassType TextStateInfo TextStateInfo TextStateInfo Pointer
    // 020 Pressed                                  ModelClassType TextStateInfo TextStateInfo TextStateInfo Pointer
    // 028 Selected                                 ModelClassType TextStateInfo TextStateInfo TextStateInfo Pointer
    // 030 Disabled                                 ModelClassType TextStateInfo TextStateInfo TextStateInfo Pointer
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

            value.Target                                    = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x010), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x10 Target                      ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Normal                                    = GetObject<TextStateInfo>(new IntPtr(p + 0x018), ReversePrism.DataModels.TextStateInfo.FromPointer); // 0x18 Normal                      ( ModelClassType TextStateInfo TextStateInfo TextStateInfo Pointer )
            value.Pressed                                   = GetObject<TextStateInfo>(new IntPtr(p + 0x020), ReversePrism.DataModels.TextStateInfo.FromPointer); // 0x20 Pressed                     ( ModelClassType TextStateInfo TextStateInfo TextStateInfo Pointer )
            value.Selected                                  = GetObject<TextStateInfo>(new IntPtr(p + 0x028), ReversePrism.DataModels.TextStateInfo.FromPointer); // 0x28 Selected                    ( ModelClassType TextStateInfo TextStateInfo TextStateInfo Pointer )
            value.Disabled                                  = GetObject<TextStateInfo>(new IntPtr(p + 0x030), ReversePrism.DataModels.TextStateInfo.FromPointer); // 0x30 Disabled                    ( ModelClassType TextStateInfo TextStateInfo TextStateInfo Pointer )

            return value;
        }
    }
}
