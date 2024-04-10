using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Model                                    0001866C1330 ModelClassType AnnounceModel AnnounceModel AnnounceModel Pointer
    public partial class AnnounceOverlayViewModel : DataModel
    {
        public AnnounceModel?                           Model                                   { get; set; }

        public static AnnounceOverlayViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AnnounceOverlayViewModel() { Pointer= p0 };

            value.Model                                     = GetObject<AnnounceModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.AnnounceModel.FromPointer); // 024665ECB6D0 0x10 Model                       ( 0001866C1330 ModelClassType AnnounceModel AnnounceModel AnnounceModel Pointer )

            return value;
        }
    }
}
