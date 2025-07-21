using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CellBase                                 ModelClassType ChainTalkCellBase ChainTalkCellBase ChainTalkCellBase Pointer
    // 028 TypingBalloon                            ModelClassType GameObject GameObject GameObject Pointer
    // 030 LayoutElement                            ModelClassType LayoutElement LayoutElement LayoutElement Pointer
    // 038 CurrentCellData                          ModelClassType ChainTalkCellDataForUnreadScroller ChainTalkCellDataForUnreadScroller ChainTalkCellDataForUnreadScroller Pointer
    public partial class ChainTalkCellForUnreadScroller : DataModel
    {
        public ChainTalkCellBase?                       CellBase                                { get; set; }
        public GameObject?                              TypingBalloon                           { get; set; }
        public LayoutElement?                           LayoutElement                           { get; set; }
        public ChainTalkCellDataForUnreadScroller?      CurrentCellData                         { get; set; }

        public static ChainTalkCellForUnreadScroller? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChainTalkCellForUnreadScroller() { Pointer= p0 };

            value.CellBase                                  = GetObject<ChainTalkCellBase>(new IntPtr(p + 0x020), ReversePrism.DataModels.ChainTalkCellBase.FromPointer); // 0x20 CellBase                    ( ModelClassType ChainTalkCellBase ChainTalkCellBase ChainTalkCellBase Pointer )
            value.TypingBalloon                             = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 TypingBalloon               ( ModelClassType GameObject GameObject GameObject Pointer )
            value.LayoutElement                             = GetObject<LayoutElement>(new IntPtr(p + 0x030), ReversePrism.DataModels.LayoutElement.FromPointer); // 0x30 LayoutElement               ( ModelClassType LayoutElement LayoutElement LayoutElement Pointer )
            value.CurrentCellData                           = GetObject<ChainTalkCellDataForUnreadScroller>(new IntPtr(p + 0x038), ReversePrism.DataModels.ChainTalkCellDataForUnreadScroller.FromPointer); // 0x38 CurrentCellData             ( ModelClassType ChainTalkCellDataForUnreadScroller ChainTalkCellDataForUnreadScroller ChainTalkCellDataForUnreadScroller Pointer )

            return value;
        }
    }
}
