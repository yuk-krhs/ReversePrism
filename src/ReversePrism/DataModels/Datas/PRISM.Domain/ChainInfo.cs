using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ReadDate                                 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 020 MstChainTalkId                           ModelPrimitiveType int int int Int32
    // 024 MstChainTalkGroupId                      ModelPrimitiveType int int int Int32
    // 028 ChainTalk                                ModelClassType ChainTalk ChainTalk ChainTalk Pointer
    public partial class ChainInfo : DataModel
    {
        public DateTime                                 ReadDate                                { get; set; }
        public int                                      MstChainTalkId                          { get; set; }
        public int                                      MstChainTalkGroupId                     { get; set; }
        public ChainTalk?                               ChainTalk                               { get; set; }

        public static ChainInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChainInfo() { Pointer= p0 };

            value.ReadDate                                  = GetDateTime(new IntPtr(p + 0x010)); // 0x10 ReadDate                    ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.MstChainTalkId                            = GetInt32(new IntPtr(p + 0x020)); // 0x20 MstChainTalkId              ( ModelPrimitiveType int int int Int32 )
            value.MstChainTalkGroupId                       = GetInt32(new IntPtr(p + 0x024)); // 0x24 MstChainTalkGroupId         ( ModelPrimitiveType int int int Int32 )
            value.ChainTalk                                 = GetObject<ChainTalk>(new IntPtr(p + 0x028), ReversePrism.DataModels.ChainTalk.FromPointer); // 0x28 ChainTalk                   ( ModelClassType ChainTalk ChainTalk ChainTalk Pointer )

            return value;
        }
    }
}
