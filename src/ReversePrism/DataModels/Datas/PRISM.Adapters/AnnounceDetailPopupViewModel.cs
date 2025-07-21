using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AnnounceDetail                           ModelClassType IAnnounceDetailStatus IAnnounceDetailStatus IAnnounceDetailStatus Pointer
    public partial class AnnounceDetailPopupViewModel : DataModel
    {
        public IAnnounceDetailStatus?                   AnnounceDetail                          { get; set; }

        public static AnnounceDetailPopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AnnounceDetailPopupViewModel() { Pointer= p0 };

            value.AnnounceDetail                            = GetObject<IAnnounceDetailStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IAnnounceDetailStatus.FromPointer); // 0x10 AnnounceDetail              ( ModelClassType IAnnounceDetailStatus IAnnounceDetailStatus IAnnounceDetailStatus Pointer )

            return value;
        }
    }
}
