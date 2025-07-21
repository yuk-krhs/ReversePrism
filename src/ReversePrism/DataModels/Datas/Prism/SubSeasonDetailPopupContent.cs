using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 SubseasonContent                         ModelClassType SubSeasonDetailContent SubSeasonDetailContent SubSeasonDetailContent Pointer
    public partial class SubSeasonDetailPopupContent : DataModel
    {
        public SubSeasonDetailContent?                  SubseasonContent                        { get; set; }

        public static SubSeasonDetailPopupContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SubSeasonDetailPopupContent() { Pointer= p0 };

            value.SubseasonContent                          = GetObject<SubSeasonDetailContent>(new IntPtr(p + 0x060), ReversePrism.DataModels.SubSeasonDetailContent.FromPointer); // 0x60 SubseasonContent            ( ModelClassType SubSeasonDetailContent SubSeasonDetailContent SubSeasonDetailContent Pointer )

            return value;
        }
    }
}
