using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Core                                     ModelClassType LimelightCore LimelightCore LimelightCore Pointer
    // 018 assetContainerPool                       ObjectPool`1<AssetContainer> IL2CPP_TYPE_GENERICINST
    // 020 cache                                    Dictionary`2<string, AssetContainer> IL2CPP_TYPE_GENERICINST
    // 028 Downloader                               ModelClassType ResourceDownloader ResourceDownloader ResourceDownloader Pointer
    public partial class ResourceLoader : DataModel
    {
        public LimelightCore?                           Core                                    { get; set; }
        public ResourceDownloader?                      Downloader                              { get; set; }

        public static ResourceLoader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ResourceLoader() { Pointer= p0 };

            value.Core                                      = GetObject<LimelightCore>(new IntPtr(p + 0x010), ReversePrism.DataModels.LimelightCore.FromPointer); // 0x10 Core                        ( ModelClassType LimelightCore LimelightCore LimelightCore Pointer )
            value.Downloader                                = GetObject<ResourceDownloader>(new IntPtr(p + 0x028), ReversePrism.DataModels.ResourceDownloader.FromPointer); // 0x28 Downloader                  ( ModelClassType ResourceDownloader ResourceDownloader ResourceDownloader Pointer )

            return value;
        }
    }
}
