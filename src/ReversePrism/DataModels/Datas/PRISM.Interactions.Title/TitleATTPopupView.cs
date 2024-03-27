using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 attUrl                                   string IL2CPP_TYPE_STRING
    // 020 PreATTContent                            0001867732B0 ModelClassType PreATTContent PreATTContent PreATTContent Pointer
    public partial class TitleATTPopupView
    {
        public PreATTContent?                           PreATTContent                           { get; set; }

        public static TitleATTPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TitleATTPopupView();

            value.PreATTContent                             = GetObject<PreATTContent>(new IntPtr(p + 0x020), ReversePrism.DataModels.PreATTContent.FromPointer); // 027004371328 0x20 PreATTContent               ( 0001867732B0 ModelClassType PreATTContent PreATTContent PreATTContent Pointer )

            return value;
        }
    }
}
