using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 DEFAULT_FONT_SIZE                        int IL2CPP_TYPE_I4
    // 000 DEFAULT_LINE_SPACING                     float IL2CPP_TYPE_R4
    // 000 defaultTextColorCode                     string IL2CPP_TYPE_STRING
    // 008 fullWidthSpace                           string IL2CPP_TYPE_STRING
    // 000 DEFAULT_PADDING_PIXEL                    int IL2CPP_TYPE_I4
    // 010 Replacer                                 000186723120 ModelClassType XMLTransferSourceReplacer XMLTransferSourceReplacer XMLTransferSourceReplacer Pointer
    public partial class XMLTransfer
    {
        public XMLTransferSourceReplacer?               Replacer                                { get; set; }

        public static XMLTransfer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XMLTransfer();

            value.Replacer                                  = GetObject<XMLTransferSourceReplacer>(new IntPtr(p + 0x010), ReversePrism.DataModels.XMLTransferSourceReplacer.FromPointer); // 0270D4B3DA58 0x10 Replacer                    ( 000186723120 ModelClassType XMLTransferSourceReplacer XMLTransferSourceReplacer XMLTransferSourceReplacer Pointer )

            return value;
        }
    }
}
