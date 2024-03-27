using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AnnounceDetail                           0001866F5950 ModelClassType IAnnounceDetailStatus IAnnounceDetailStatus IAnnounceDetailStatus Pointer
    public partial class AnnounceDetailPopupViewModel
    {
        public IAnnounceDetailStatus?                   AnnounceDetail                          { get; set; }

        public static AnnounceDetailPopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AnnounceDetailPopupViewModel();

            value.AnnounceDetail                            = GetObject<IAnnounceDetailStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IAnnounceDetailStatus.FromPointer); // 0270D5E58FB0 0x10 AnnounceDetail              ( 0001866F5950 ModelClassType IAnnounceDetailStatus IAnnounceDetailStatus IAnnounceDetailStatus Pointer )

            return value;
        }
    }
}
