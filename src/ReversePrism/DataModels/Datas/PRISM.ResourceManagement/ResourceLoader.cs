using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Core                                     00018652BD10 ModelClassType LimelightCore LimelightCore LimelightCore Pointer
    // 018 assetCache                               Dictionary`2<string, AssetContainer`1<Object>> IL2CPP_TYPE_GENERICINST
    // 020 rawCache                                 Dictionary`2<string, AssetContainer`1<sbyte[]>> IL2CPP_TYPE_GENERICINST
    // 028 Downloader                               00018666E3A0 ModelClassType ResourceDownloader ResourceDownloader ResourceDownloader Pointer
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

            value.Core                                      = GetObject<LimelightCore>(new IntPtr(p + 0x010), ReversePrism.DataModels.LimelightCore.FromPointer); // 0245A3CF5578 0x10 Core                        ( 00018652BD10 ModelClassType LimelightCore LimelightCore LimelightCore Pointer )
            value.Downloader                                = GetObject<ResourceDownloader>(new IntPtr(p + 0x028), ReversePrism.DataModels.ResourceDownloader.FromPointer); // 0245A3CF55D8 0x28 Downloader                  ( 00018666E3A0 ModelClassType ResourceDownloader ResourceDownloader ResourceDownloader Pointer )

            return value;
        }
    }
}
