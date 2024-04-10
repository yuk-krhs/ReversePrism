using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 DownloadBar                              00018651CF50 ModelClassType Slider Slider Slider Pointer
    public partial class ForegroundDownloadGauge : DataModel
    {
        public Slider?                                  DownloadBar                             { get; set; }

        public static ForegroundDownloadGauge? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ForegroundDownloadGauge() { Pointer= p0 };

            value.DownloadBar                               = GetObject<Slider>(new IntPtr(p + 0x038), ReversePrism.DataModels.Slider.FromPointer); // 024660A8FE08 0x38 DownloadBar                 ( 00018651CF50 ModelClassType Slider Slider Slider Pointer )

            return value;
        }
    }
}
