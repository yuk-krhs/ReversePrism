using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 attUrl                                   string IL2CPP_TYPE_STRING
    // 020 PreATTContent                            ModelClassType PreATTContent PreATTContent PreATTContent Pointer
    public partial class TitleATTPopupView : DataModel
    {
        public PreATTContent?                           PreATTContent                           { get; set; }

        public static TitleATTPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TitleATTPopupView() { Pointer= p0 };

            value.PreATTContent                             = GetObject<PreATTContent>(new IntPtr(p + 0x020), ReversePrism.DataModels.PreATTContent.FromPointer); // 0x20 PreATTContent               ( ModelClassType PreATTContent PreATTContent PreATTContent Pointer )

            return value;
        }
    }
}
