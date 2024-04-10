using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LocalRepo                                00018658C630 ModelClassType AssetRepository AssetRepository AssetRepository Pointer
    // 018 RemoteRepo                               00018658C630 ModelClassType AssetRepository AssetRepository AssetRepository Pointer
    // 020 TimeSlicer                               000186669030 ModelClassType TimeSlicer TimeSlicer TimeSlicer Pointer
    // 028 Decoder                                  000186612DF0 ModelClassType RawAssetCoder RawAssetCoder RawAssetCoder Pointer
    // 030 addressCrcExistCache                     Dictionary`2<ulong, bool> IL2CPP_TYPE_GENERICINST
    // 038 CSource                                  0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    public partial class AssetManager : DataModel
    {
        public AssetRepository?                         LocalRepo                               { get; set; }
        public AssetRepository?                         RemoteRepo                              { get; set; }
        public TimeSlicer?                              TimeSlicer                              { get; set; }
        public RawAssetCoder?                           Decoder                                 { get; set; }
        public CancellationTokenSource?                 CSource                                 { get; set; }

        public static AssetManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AssetManager() { Pointer= p0 };

            value.LocalRepo                                 = GetObject<AssetRepository>(new IntPtr(p + 0x010), ReversePrism.DataModels.AssetRepository.FromPointer); // 0245A3E04668 0x10 LocalRepo                   ( 00018658C630 ModelClassType AssetRepository AssetRepository AssetRepository Pointer )
            value.RemoteRepo                                = GetObject<AssetRepository>(new IntPtr(p + 0x018), ReversePrism.DataModels.AssetRepository.FromPointer); // 0245A3E04688 0x18 RemoteRepo                  ( 00018658C630 ModelClassType AssetRepository AssetRepository AssetRepository Pointer )
            value.TimeSlicer                                = GetObject<TimeSlicer>(new IntPtr(p + 0x020), ReversePrism.DataModels.TimeSlicer.FromPointer); // 0245A3E046A8 0x20 TimeSlicer                  ( 000186669030 ModelClassType TimeSlicer TimeSlicer TimeSlicer Pointer )
            value.Decoder                                   = GetObject<RawAssetCoder>(new IntPtr(p + 0x028), ReversePrism.DataModels.RawAssetCoder.FromPointer); // 0245A3E046C8 0x28 Decoder                     ( 000186612DF0 ModelClassType RawAssetCoder RawAssetCoder RawAssetCoder Pointer )
            value.CSource                                   = GetObject<CancellationTokenSource>(new IntPtr(p + 0x038), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0245A3E04708 0x38 CSource                     ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )

            return value;
        }
    }
}
