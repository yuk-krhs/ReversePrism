using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AllChainInfo                             000185CD16C8 ModelClassListType List`1<ChainInfo> List`1<ChainInfo> List<ChainInfo> Pointer
    // 018 ReadChainInfoList                        000185CD16C8 ModelClassListType List`1<ChainInfo> List`1<ChainInfo> List<ChainInfo> Pointer
    // 020 <OldestUnreadChainInfo>k__BackingField   Dictionary`2<int, ChainInfo> IL2CPP_TYPE_GENERICINST
    // 028 IsReady                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class ChainCache
    {
        public List<ChainInfo>?                         AllChainInfo                            { get; set; }
        public List<ChainInfo>?                         ReadChainInfoList                       { get; set; }
        public bool                                     IsReady                                 { get; set; }

        public static ChainCache? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChainCache();

            value.AllChainInfo                              = GetObjectList<ChainInfo>(new IntPtr(p + 0x010), ReversePrism.DataModels.ChainInfo.FromPointer); // 027004A85C38 0x10 AllChainInfo                ( 000185CD16C8 ModelClassListType List`1<ChainInfo> List`1<ChainInfo> List<ChainInfo> Pointer )
            value.ReadChainInfoList                         = GetObjectList<ChainInfo>(new IntPtr(p + 0x018), ReversePrism.DataModels.ChainInfo.FromPointer); // 027004A85C58 0x18 ReadChainInfoList           ( 000185CD16C8 ModelClassListType List`1<ChainInfo> List`1<ChainInfo> List<ChainInfo> Pointer )
            value.IsReady                                   = GetBool(new IntPtr(p + 0x028)); // 027004A85C98 0x28 IsReady                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
