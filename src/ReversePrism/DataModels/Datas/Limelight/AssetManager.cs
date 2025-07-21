using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LocalRepo                                ModelClassType AssetRepository AssetRepository AssetRepository Pointer
    // 018 RemoteRepo                               ModelClassType AssetRepository AssetRepository AssetRepository Pointer
    // 020 TimeSlicer                               ModelClassType TimeSlicer TimeSlicer TimeSlicer Pointer
    // 028 Decoder                                  ModelClassType RawAssetCoder RawAssetCoder RawAssetCoder Pointer
    // 030 addressCrcExistCache                     Dictionary`2<ulong, bool> IL2CPP_TYPE_GENERICINST
    // 038 CSource                                  ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
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

            value.LocalRepo                                 = GetObject<AssetRepository>(new IntPtr(p + 0x010), ReversePrism.DataModels.AssetRepository.FromPointer); // 0x10 LocalRepo                   ( ModelClassType AssetRepository AssetRepository AssetRepository Pointer )
            value.RemoteRepo                                = GetObject<AssetRepository>(new IntPtr(p + 0x018), ReversePrism.DataModels.AssetRepository.FromPointer); // 0x18 RemoteRepo                  ( ModelClassType AssetRepository AssetRepository AssetRepository Pointer )
            value.TimeSlicer                                = GetObject<TimeSlicer>(new IntPtr(p + 0x020), ReversePrism.DataModels.TimeSlicer.FromPointer); // 0x20 TimeSlicer                  ( ModelClassType TimeSlicer TimeSlicer TimeSlicer Pointer )
            value.Decoder                                   = GetObject<RawAssetCoder>(new IntPtr(p + 0x028), ReversePrism.DataModels.RawAssetCoder.FromPointer); // 0x28 Decoder                     ( ModelClassType RawAssetCoder RawAssetCoder RawAssetCoder Pointer )
            value.CSource                                   = GetObject<CancellationTokenSource>(new IntPtr(p + 0x038), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x38 CSource                     ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )

            return value;
        }
    }
}
