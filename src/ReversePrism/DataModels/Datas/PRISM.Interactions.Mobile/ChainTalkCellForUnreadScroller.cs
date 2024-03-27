using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CellBase                                 00018655BB00 ModelClassType ChainTalkCellBase ChainTalkCellBase ChainTalkCellBase Pointer
    // 028 TypingBalloon                            0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 030 LayoutElement                            00018650C2A0 ModelClassType LayoutElement LayoutElement LayoutElement Pointer
    // 038 CurrentCellData                          00018655D1E0 ModelClassType ChainTalkCellDataForUnreadScroller ChainTalkCellDataForUnreadScroller ChainTalkCellDataForUnreadScroller Pointer
    public partial class ChainTalkCellForUnreadScroller
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
            var value   = new ChainTalkCellForUnreadScroller();

            value.CellBase                                  = GetObject<ChainTalkCellBase>(new IntPtr(p + 0x020), ReversePrism.DataModels.ChainTalkCellBase.FromPointer); // 0270DB114D70 0x20 CellBase                    ( 00018655BB00 ModelClassType ChainTalkCellBase ChainTalkCellBase ChainTalkCellBase Pointer )
            value.TypingBalloon                             = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB114D90 0x28 TypingBalloon               ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.LayoutElement                             = GetObject<LayoutElement>(new IntPtr(p + 0x030), ReversePrism.DataModels.LayoutElement.FromPointer); // 0270DB114DB0 0x30 LayoutElement               ( 00018650C2A0 ModelClassType LayoutElement LayoutElement LayoutElement Pointer )
            value.CurrentCellData                           = GetObject<ChainTalkCellDataForUnreadScroller>(new IntPtr(p + 0x038), ReversePrism.DataModels.ChainTalkCellDataForUnreadScroller.FromPointer); // 0270DB114DD0 0x38 CurrentCellData             ( 00018655D1E0 ModelClassType ChainTalkCellDataForUnreadScroller ChainTalkCellDataForUnreadScroller ChainTalkCellDataForUnreadScroller Pointer )

            return value;
        }
    }
}
