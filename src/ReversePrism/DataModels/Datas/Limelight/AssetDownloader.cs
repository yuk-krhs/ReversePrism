using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DownloaderImpl                           ModelClassType INativeDownloader INativeDownloader INativeDownloader Pointer
    // 018 PendingErrors                            ModelClassListType List`1<AssetDownloadError> List`1<AssetDownloadError> List<AssetDownloadError> Pointer
    // 020 FocusedError                             ModelClassType AssetDownloadError AssetDownloadError AssetDownloadError Pointer
    // 028 BackgroundErrorIgnoreChance              ModelPrimitiveType bool bool bool Bool
    // 02C BackgroundSuppressionRequestCount        ModelPrimitiveType int int int Int32
    // 030 PauseRequestCount                        ModelPrimitiveType int int int Int32
    // 038 CSource                                  ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    public partial class AssetDownloader : DataModel
    {
        public INativeDownloader?                       DownloaderImpl                          { get; set; }
        public List<AssetDownloadError>?                PendingErrors                           { get; set; }
        public AssetDownloadError?                      FocusedError                            { get; set; }
        public bool                                     BackgroundErrorIgnoreChance             { get; set; }
        public int                                      BackgroundSuppressionRequestCount       { get; set; }
        public int                                      PauseRequestCount                       { get; set; }
        public CancellationTokenSource?                 CSource                                 { get; set; }

        public static AssetDownloader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AssetDownloader() { Pointer= p0 };

            value.DownloaderImpl                            = GetObject<INativeDownloader>(new IntPtr(p + 0x010), ReversePrism.DataModels.INativeDownloader.FromPointer); // 0x10 DownloaderImpl              ( ModelClassType INativeDownloader INativeDownloader INativeDownloader Pointer )
            value.PendingErrors                             = GetObjectList<AssetDownloadError>(new IntPtr(p + 0x018), ReversePrism.DataModels.AssetDownloadError.FromPointer); // 0x18 PendingErrors               ( ModelClassListType List`1<AssetDownloadError> List`1<AssetDownloadError> List<AssetDownloadError> Pointer )
            value.FocusedError                              = GetObject<AssetDownloadError>(new IntPtr(p + 0x020), ReversePrism.DataModels.AssetDownloadError.FromPointer); // 0x20 FocusedError                ( ModelClassType AssetDownloadError AssetDownloadError AssetDownloadError Pointer )
            value.BackgroundErrorIgnoreChance               = GetBool(new IntPtr(p + 0x028)); // 0x28 BackgroundErrorIgnoreChance ( ModelPrimitiveType bool bool bool Bool )
            value.BackgroundSuppressionRequestCount         = GetInt32(new IntPtr(p + 0x02C)); // 0x2C BackgroundSuppressionRequestCount ( ModelPrimitiveType int int int Int32 )
            value.PauseRequestCount                         = GetInt32(new IntPtr(p + 0x030)); // 0x30 PauseRequestCount           ( ModelPrimitiveType int int int Int32 )
            value.CSource                                   = GetObject<CancellationTokenSource>(new IntPtr(p + 0x038), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x38 CSource                     ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )

            return value;
        }
    }
}
