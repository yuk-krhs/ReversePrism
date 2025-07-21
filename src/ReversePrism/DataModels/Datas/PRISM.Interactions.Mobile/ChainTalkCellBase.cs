using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Header                                   ModelClassType ChainTalkCellHeader ChainTalkCellHeader ChainTalkCellHeader Pointer
    // 028 ContentContainer                         ModelClassType ChainTalkCellContentContainer ChainTalkCellContentContainer ChainTalkCellContentContainer Pointer
    public partial class ChainTalkCellBase : DataModel
    {
        public ChainTalkCellHeader?                     Header                                  { get; set; }
        public ChainTalkCellContentContainer?           ContentContainer                        { get; set; }

        public static ChainTalkCellBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChainTalkCellBase() { Pointer= p0 };

            value.Header                                    = GetObject<ChainTalkCellHeader>(new IntPtr(p + 0x020), ReversePrism.DataModels.ChainTalkCellHeader.FromPointer); // 0x20 Header                      ( ModelClassType ChainTalkCellHeader ChainTalkCellHeader ChainTalkCellHeader Pointer )
            value.ContentContainer                          = GetObject<ChainTalkCellContentContainer>(new IntPtr(p + 0x028), ReversePrism.DataModels.ChainTalkCellContentContainer.FromPointer); // 0x28 ContentContainer            ( ModelClassType ChainTalkCellContentContainer ChainTalkCellContentContainer ChainTalkCellContentContainer Pointer )

            return value;
        }
    }
}
