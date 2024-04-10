using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AssetManager                             0001866E7C90 ModelClassType AssetManager AssetManager AssetManager Pointer
    // 018 Downloader                               0001866E62B0 ModelClassType AssetDownloader AssetDownloader AssetDownloader Pointer
    // 020 DownloadFactory                          000186754D30 ModelClassType IDownloadContextFactory IDownloadContextFactory IDownloadContextFactory Pointer
    // 028 CatalogDB                                00018654B8D0 ModelClassType CatalogDB CatalogDB CatalogDB Pointer
    // 030 DownloaderImpl                           000186687780 ModelClassType NativeDownloader NativeDownloader NativeDownloader Pointer
    // 038 CatalogCache                             00018654B3C0 ModelClassType CatalogCacheSavedata CatalogCacheSavedata CatalogCacheSavedata Pointer
    // 040 CSource                                  0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 048 DownloadDataRoot                         000186672F10 ModelPrimitiveType string string string String
    // 050 MetaLocationProvider                     0001865B1BC0 ModelClassType IMetadataLocationProvider IMetadataLocationProvider IMetadataLocationProvider Pointer
    // 058 LocalLocator                             00018661B660 ModelClassType IResourceLocator IResourceLocator IResourceLocator Pointer
    // 060 TimeSlicer                               000186668B30 ModelClassType TimeSlicer TimeSlicer TimeSlicer Pointer
    // 000 instance                                 LimelightCore IL2CPP_TYPE_CLASS
    // 068 BrokenCatalogDatabaseDetected            000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class LimelightCore : DataModel
    {
        public AssetManager?                            AssetManager                            { get; set; }
        public AssetDownloader?                         Downloader                              { get; set; }
        public IDownloadContextFactory?                 DownloadFactory                         { get; set; }
        public CatalogDB?                               CatalogDB                               { get; set; }
        public NativeDownloader?                        DownloaderImpl                          { get; set; }
        public CatalogCacheSavedata?                    CatalogCache                            { get; set; }
        public CancellationTokenSource?                 CSource                                 { get; set; }
        public string                                   DownloadDataRoot                        { get; set; }
        public IMetadataLocationProvider?               MetaLocationProvider                    { get; set; }
        public IResourceLocator?                        LocalLocator                            { get; set; }
        public TimeSlicer?                              TimeSlicer                              { get; set; }
        public bool                                     BrokenCatalogDatabaseDetected           { get; set; }

        public static LimelightCore? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LimelightCore() { Pointer= p0 };

            value.AssetManager                              = GetObject<AssetManager>(new IntPtr(p + 0x010), ReversePrism.DataModels.AssetManager.FromPointer); // 0245A3CF45F8 0x10 AssetManager                ( 0001866E7C90 ModelClassType AssetManager AssetManager AssetManager Pointer )
            value.Downloader                                = GetObject<AssetDownloader>(new IntPtr(p + 0x018), ReversePrism.DataModels.AssetDownloader.FromPointer); // 0245A3CF4618 0x18 Downloader                  ( 0001866E62B0 ModelClassType AssetDownloader AssetDownloader AssetDownloader Pointer )
            value.DownloadFactory                           = GetObject<IDownloadContextFactory>(new IntPtr(p + 0x020), ReversePrism.DataModels.IDownloadContextFactory.FromPointer); // 0245A3CF4638 0x20 DownloadFactory             ( 000186754D30 ModelClassType IDownloadContextFactory IDownloadContextFactory IDownloadContextFactory Pointer )
            value.CatalogDB                                 = GetObject<CatalogDB>(new IntPtr(p + 0x028), ReversePrism.DataModels.CatalogDB.FromPointer); // 0245A3CF4658 0x28 CatalogDB                   ( 00018654B8D0 ModelClassType CatalogDB CatalogDB CatalogDB Pointer )
            value.DownloaderImpl                            = GetObject<NativeDownloader>(new IntPtr(p + 0x030), ReversePrism.DataModels.NativeDownloader.FromPointer); // 0245A3CF4678 0x30 DownloaderImpl              ( 000186687780 ModelClassType NativeDownloader NativeDownloader NativeDownloader Pointer )
            value.CatalogCache                              = GetObject<CatalogCacheSavedata>(new IntPtr(p + 0x038), ReversePrism.DataModels.CatalogCacheSavedata.FromPointer); // 0245A3CF4698 0x38 CatalogCache                ( 00018654B3C0 ModelClassType CatalogCacheSavedata CatalogCacheSavedata CatalogCacheSavedata Pointer )
            value.CSource                                   = GetObject<CancellationTokenSource>(new IntPtr(p + 0x040), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0245A3CF46B8 0x40 CSource                     ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.DownloadDataRoot                          = GetString(new IntPtr(p + 0x048)); // 0245A3CF46D8 0x48 DownloadDataRoot            ( 000186672F10 ModelPrimitiveType string string string String )
            value.MetaLocationProvider                      = GetObject<IMetadataLocationProvider>(new IntPtr(p + 0x050), ReversePrism.DataModels.IMetadataLocationProvider.FromPointer); // 0245A3CF46F8 0x50 MetaLocationProvider        ( 0001865B1BC0 ModelClassType IMetadataLocationProvider IMetadataLocationProvider IMetadataLocationProvider Pointer )
            value.LocalLocator                              = GetObject<IResourceLocator>(new IntPtr(p + 0x058), ReversePrism.DataModels.IResourceLocator.FromPointer); // 0245A3CF4718 0x58 LocalLocator                ( 00018661B660 ModelClassType IResourceLocator IResourceLocator IResourceLocator Pointer )
            value.TimeSlicer                                = GetObject<TimeSlicer>(new IntPtr(p + 0x060), ReversePrism.DataModels.TimeSlicer.FromPointer); // 0245A3CF4738 0x60 TimeSlicer                  ( 000186668B30 ModelClassType TimeSlicer TimeSlicer TimeSlicer Pointer )
            value.BrokenCatalogDatabaseDetected             = GetBool(new IntPtr(p + 0x068)); // 0245A3CF4778 0x68 BrokenCatalogDatabaseDetected ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
