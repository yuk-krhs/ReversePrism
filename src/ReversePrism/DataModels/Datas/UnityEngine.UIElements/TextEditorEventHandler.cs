using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TextElement                              000186638D60 ModelClassType TextElement TextElement TextElement Pointer
    // 018 EditingUtilities                         000186637830 ModelClassType TextEditingUtilities TextEditingUtilities TextEditingUtilities Pointer
    public partial class TextEditorEventHandler : DataModel
    {
        public TextElement?                             TextElement                             { get; set; }
        public TextEditingUtilities?                    EditingUtilities                        { get; set; }

        public static TextEditorEventHandler? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TextEditorEventHandler() { Pointer= p0 };

            value.TextElement                               = GetObject<TextElement>(new IntPtr(p + 0x010), ReversePrism.DataModels.TextElement.FromPointer); // 0245A66D86D0 0x10 TextElement                 ( 000186638D60 ModelClassType TextElement TextElement TextElement Pointer )
            value.EditingUtilities                          = GetObject<TextEditingUtilities>(new IntPtr(p + 0x018), ReversePrism.DataModels.TextEditingUtilities.FromPointer); // 0245A66D86F0 0x18 EditingUtilities            ( 000186637830 ModelClassType TextEditingUtilities TextEditingUtilities TextEditingUtilities Pointer )

            return value;
        }
    }
}
