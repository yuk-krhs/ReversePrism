using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Element                                  ModelClassType SubSeasonDetailContentElement SubSeasonDetailContentElement SubSeasonDetailContentElement Pointer
    public partial class SubSeasonDetailContent : DataModel
    {
        public SubSeasonDetailContentElement?           Element                                 { get; set; }

        public static SubSeasonDetailContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SubSeasonDetailContent() { Pointer= p0 };

            value.Element                                   = GetObject<SubSeasonDetailContentElement>(new IntPtr(p + 0x020), ReversePrism.DataModels.SubSeasonDetailContentElement.FromPointer); // 0x20 Element                     ( ModelClassType SubSeasonDetailContentElement SubSeasonDetailContentElement SubSeasonDetailContentElement Pointer )

            return value;
        }
    }
}
