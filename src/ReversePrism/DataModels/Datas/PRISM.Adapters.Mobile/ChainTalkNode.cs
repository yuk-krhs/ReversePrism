using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MstChainTalkText                         00018661A050 ModelClassType MstChainTalkText MstChainTalkText MstChainTalkText Pointer
    // 018 NextTalkTextIds                          000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer
    public partial class ChainTalkNode : DataModel
    {
        public MstChainTalkText?                        MstChainTalkText                        { get; set; }
        public List<int>?                               NextTalkTextIds                         { get; set; }

        public static ChainTalkNode? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChainTalkNode() { Pointer= p0 };

            value.MstChainTalkText                          = GetObject<MstChainTalkText>(new IntPtr(p + 0x010), ReversePrism.DataModels.MstChainTalkText.FromPointer); // 0246668C74C0 0x10 MstChainTalkText            ( 00018661A050 ModelClassType MstChainTalkText MstChainTalkText MstChainTalkText Pointer )
            value.NextTalkTextIds                           = GetInt32List(new IntPtr(p + 0x018)); // 0246668C74E0 0x18 NextTalkTextIds             ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )

            return value;
        }
    }
}
