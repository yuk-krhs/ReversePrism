using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     000186756290 ModelClassType IDownloadOverlayView IDownloadOverlayView IDownloadOverlayView Pointer
    public partial class DownloadOverlayPresenter
    {
        public IDownloadOverlayView?                    View                                    { get; set; }

        public static DownloadOverlayPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DownloadOverlayPresenter();

            value.View                                      = GetObject<IDownloadOverlayView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IDownloadOverlayView.FromPointer); // 027004E62668 0x10 View                        ( 000186756290 ModelClassType IDownloadOverlayView IDownloadOverlayView IDownloadOverlayView Pointer )

            return value;
        }
    }
}
