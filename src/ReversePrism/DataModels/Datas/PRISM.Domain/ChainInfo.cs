using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ReadDate                                 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 020 MstChainTalkId                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 024 MstChainTalkGroupId                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 ChainTalk                                00018655A990 ModelClassType ChainTalk ChainTalk ChainTalk Pointer
    public partial class ChainInfo
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
            var value   = new ChainInfo();

            value.ReadDate                                  = GetDateTime(new IntPtr(p + 0x010)); // 027004AEB6F0 0x10 ReadDate                    ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.MstChainTalkId                            = GetInt32(new IntPtr(p + 0x020)); // 027004AEB710 0x20 MstChainTalkId              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstChainTalkGroupId                       = GetInt32(new IntPtr(p + 0x024)); // 027004AEB730 0x24 MstChainTalkGroupId         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ChainTalk                                 = GetObject<ChainTalk>(new IntPtr(p + 0x028), ReversePrism.DataModels.ChainTalk.FromPointer); // 027004AEB750 0x28 ChainTalk                   ( 00018655A990 ModelClassType ChainTalk ChainTalk ChainTalk Pointer )

            return value;
        }
    }
}
