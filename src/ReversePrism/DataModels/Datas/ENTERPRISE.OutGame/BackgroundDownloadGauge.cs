using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 PeakProgress                             0001866656B0 ModelPrimitiveType float float float Single
    // 040 DownloadBar                              00018662F280 ModelClassType RectMaskGauge RectMaskGauge RectMaskGauge Pointer
    public partial class BackgroundDownloadGauge : DataModel
    {
        public float                                    PeakProgress                            { get; set; }
        public RectMaskGauge?                           DownloadBar                             { get; set; }

        public static BackgroundDownloadGauge? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BackgroundDownloadGauge() { Pointer= p0 };

            value.PeakProgress                              = GetSingle(new IntPtr(p + 0x038)); // 024660A90050 0x38 PeakProgress                ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.DownloadBar                               = GetObject<RectMaskGauge>(new IntPtr(p + 0x040), ReversePrism.DataModels.RectMaskGauge.FromPointer); // 024660A90070 0x40 DownloadBar                 ( 00018662F280 ModelClassType RectMaskGauge RectMaskGauge RectMaskGauge Pointer )

            return value;
        }
    }
}
