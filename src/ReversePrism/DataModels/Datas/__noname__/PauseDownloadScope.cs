using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Downloader                               0001866E62B0 ModelClassType AssetDownloader AssetDownloader AssetDownloader Pointer
    public partial class PauseDownloadScope
    {
        public AssetDownloader?                         Downloader                              { get; set; }

        public static PauseDownloadScope? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PauseDownloadScope();

            value.Downloader                                = GetObject<AssetDownloader>(new IntPtr(p + 0x010), ReversePrism.DataModels.AssetDownloader.FromPointer); // 0270DB4E0B50 0x10 Downloader                  ( 0001866E62B0 ModelClassType AssetDownloader AssetDownloader AssetDownloader Pointer )

            return value;
        }
    }
}
