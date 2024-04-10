using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 HideCount                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 ForegroundGauge                          0001865B5200 ModelClassType ForegroundDownloadGauge ForegroundDownloadGauge ForegroundDownloadGauge Pointer
    // 030 BackgroundGauge                          000186734690 ModelClassType BackgroundDownloadGauge BackgroundDownloadGauge BackgroundDownloadGauge Pointer
    public partial class AssetDownloadUI : DataModel
    {
        public int                                      HideCount                               { get; set; }
        public ForegroundDownloadGauge?                 ForegroundGauge                         { get; set; }
        public BackgroundDownloadGauge?                 BackgroundGauge                         { get; set; }

        public static AssetDownloadUI? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AssetDownloadUI() { Pointer= p0 };

            value.HideCount                                 = GetInt32(new IntPtr(p + 0x020)); // 024660A8FEF0 0x20 HideCount                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ForegroundGauge                           = GetObject<ForegroundDownloadGauge>(new IntPtr(p + 0x028), ReversePrism.DataModels.ForegroundDownloadGauge.FromPointer); // 024660A8FF10 0x28 ForegroundGauge             ( 0001865B5200 ModelClassType ForegroundDownloadGauge ForegroundDownloadGauge ForegroundDownloadGauge Pointer )
            value.BackgroundGauge                           = GetObject<BackgroundDownloadGauge>(new IntPtr(p + 0x030), ReversePrism.DataModels.BackgroundDownloadGauge.FromPointer); // 024660A8FF30 0x30 BackgroundGauge             ( 000186734690 ModelClassType BackgroundDownloadGauge BackgroundDownloadGauge BackgroundDownloadGauge Pointer )

            return value;
        }
    }
}
