using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AllChainInfo                             ModelClassListType List`1<ChainInfo> List`1<ChainInfo> List<ChainInfo> Pointer
    // 018 ReadChainInfoList                        ModelClassListType List`1<ChainInfo> List`1<ChainInfo> List<ChainInfo> Pointer
    // 020 <OldestUnreadChainInfo>k__BackingField   Dictionary`2<int, ChainInfo> IL2CPP_TYPE_GENERICINST
    // 028 IsReady                                  ModelPrimitiveType bool bool bool Bool
    public partial class ChainCache : DataModel
    {
        public List<ChainInfo>?                         AllChainInfo                            { get; set; }
        public List<ChainInfo>?                         ReadChainInfoList                       { get; set; }
        public bool                                     IsReady                                 { get; set; }

        public static ChainCache? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChainCache() { Pointer= p0 };

            value.AllChainInfo                              = GetObjectList<ChainInfo>(new IntPtr(p + 0x010), ReversePrism.DataModels.ChainInfo.FromPointer); // 0x10 AllChainInfo                ( ModelClassListType List`1<ChainInfo> List`1<ChainInfo> List<ChainInfo> Pointer )
            value.ReadChainInfoList                         = GetObjectList<ChainInfo>(new IntPtr(p + 0x018), ReversePrism.DataModels.ChainInfo.FromPointer); // 0x18 ReadChainInfoList           ( ModelClassListType List`1<ChainInfo> List`1<ChainInfo> List<ChainInfo> Pointer )
            value.IsReady                                   = GetBool(new IntPtr(p + 0x028)); // 0x28 IsReady                     ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
