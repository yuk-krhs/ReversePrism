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

            value.ReadDate                                  = GetDateTime(new IntPtr(p + 0x010)); // 0245A4B436E0 0x10 ReadDate                    ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.MstChainTalkId                            = GetInt32(new IntPtr(p + 0x020)); // 0245A4B43700 0x20 MstChainTalkId              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstChainTalkGroupId                       = GetInt32(new IntPtr(p + 0x024)); // 0245A4B43720 0x24 MstChainTalkGroupId         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ChainTalk                                 = GetObject<ChainTalk>(new IntPtr(p + 0x028), ReversePrism.DataModels.ChainTalk.FromPointer); // 0245A4B43740 0x28 ChainTalk                   ( 00018655A990 ModelClassType ChainTalk ChainTalk ChainTalk Pointer )

            return value;
        }
    }
}
