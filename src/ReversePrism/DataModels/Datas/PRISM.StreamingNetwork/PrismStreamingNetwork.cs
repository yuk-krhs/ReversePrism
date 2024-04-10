using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 prismStreamingGrpcClient                 PrismStreamingGrpcClient IL2CPP_TYPE_CLASS
    // 008 prismStreamingCdn                        PrismStreamingCDN IL2CPP_TYPE_CLASS
    // 010 InstantiatedGuid                         000185D0D738 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    // 018 SoundViewUsedForSynchronization          0001865DE480 ModelClassType IPrismStreamingCurrentTime IPrismStreamingCurrentTime IPrismStreamingCurrentTime Pointer
    // 020 Callbacks                                000185CE6E78 ModelClassListType List`1<IPrismStreamingCallbacks> List`1<IPrismStreamingCallbacks> List<IPrismStreamingCallbacks> Pointer
    public partial class PrismStreamingNetwork : DataModel
    {
        public List<string>?                            InstantiatedGuid                        { get; set; }
        public IPrismStreamingCurrentTime?              SoundViewUsedForSynchronization         { get; set; }
        public List<IPrismStreamingCallbacks>?          Callbacks                               { get; set; }

        public static PrismStreamingNetwork? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PrismStreamingNetwork() { Pointer= p0 };

            value.InstantiatedGuid                          = GetStringList(new IntPtr(p + 0x010)); // 024664F8F208 0x10 InstantiatedGuid            ( 000185D0D738 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )
            value.SoundViewUsedForSynchronization           = GetObject<IPrismStreamingCurrentTime>(new IntPtr(p + 0x018), ReversePrism.DataModels.IPrismStreamingCurrentTime.FromPointer); // 024664F8F228 0x18 SoundViewUsedForSynchronization ( 0001865DE480 ModelClassType IPrismStreamingCurrentTime IPrismStreamingCurrentTime IPrismStreamingCurrentTime Pointer )
            value.Callbacks                                 = GetObjectList<IPrismStreamingCallbacks>(new IntPtr(p + 0x020), ReversePrism.DataModels.IPrismStreamingCallbacks.FromPointer); // 024664F8F248 0x20 Callbacks                   ( 000185CE6E78 ModelClassListType List`1<IPrismStreamingCallbacks> List`1<IPrismStreamingCallbacks> List<IPrismStreamingCallbacks> Pointer )

            return value;
        }
    }
}
