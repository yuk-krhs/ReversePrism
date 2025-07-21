using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 058 Scrollbar                                ModelClassType Scrollbar Scrollbar Scrollbar Pointer
    // 060 EmptyText                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 ScrollButton                             ModelClassType ChainTalkScrollButton ChainTalkScrollButton ChainTalkScrollButton Pointer
    // 070 TalkCellPrefabs                          ModelClassListType ChainTalkCellForReadScroller[] ChainTalkCellForReadScroller[] List<ChainTalkCellForReadScroller> Pointer
    // 078 SeparatorCellPrefab                      ModelClassType ChainTalkSeparatorCell ChainTalkSeparatorCell ChainTalkSeparatorCell Pointer
    // 080 ChainTextColor                           ModelClassType ChainTextColor ChainTextColor ChainTextColor Pointer
    // 088 ScrollingDurationRatio                   ModelPrimitiveType float float float Single
    // 08C IsScrolling                              ModelPrimitiveType bool bool bool Bool
    public partial class ChainTalkReadScrollerView : DataModel
    {
        public Scrollbar?                               Scrollbar                               { get; set; }
        public UITextMeshProUGUI?                       EmptyText                               { get; set; }
        public ChainTalkScrollButton?                   ScrollButton                            { get; set; }
        public List<ChainTalkCellForReadScroller>?      TalkCellPrefabs                         { get; set; }
        public ChainTalkSeparatorCell?                  SeparatorCellPrefab                     { get; set; }
        public ChainTextColor?                          ChainTextColor                          { get; set; }
        public float                                    ScrollingDurationRatio                  { get; set; }
        public bool                                     IsScrolling                             { get; set; }

        public static ChainTalkReadScrollerView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChainTalkReadScrollerView() { Pointer= p0 };

            value.Scrollbar                                 = GetObject<Scrollbar>(new IntPtr(p + 0x058), ReversePrism.DataModels.Scrollbar.FromPointer); // 0x58 Scrollbar                   ( ModelClassType Scrollbar Scrollbar Scrollbar Pointer )
            value.EmptyText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x60 EmptyText                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ScrollButton                              = GetObject<ChainTalkScrollButton>(new IntPtr(p + 0x068), ReversePrism.DataModels.ChainTalkScrollButton.FromPointer); // 0x68 ScrollButton                ( ModelClassType ChainTalkScrollButton ChainTalkScrollButton ChainTalkScrollButton Pointer )
            value.TalkCellPrefabs                           = GetObjectList<ChainTalkCellForReadScroller>(new IntPtr(p + 0x070), ReversePrism.DataModels.ChainTalkCellForReadScroller.FromPointer); // 0x70 TalkCellPrefabs             ( ModelClassListType ChainTalkCellForReadScroller[] ChainTalkCellForReadScroller[] List<ChainTalkCellForReadScroller> Pointer )
            value.SeparatorCellPrefab                       = GetObject<ChainTalkSeparatorCell>(new IntPtr(p + 0x078), ReversePrism.DataModels.ChainTalkSeparatorCell.FromPointer); // 0x78 SeparatorCellPrefab         ( ModelClassType ChainTalkSeparatorCell ChainTalkSeparatorCell ChainTalkSeparatorCell Pointer )
            value.ChainTextColor                            = GetObject<ChainTextColor>(new IntPtr(p + 0x080), ReversePrism.DataModels.ChainTextColor.FromPointer); // 0x80 ChainTextColor              ( ModelClassType ChainTextColor ChainTextColor ChainTextColor Pointer )
            value.ScrollingDurationRatio                    = GetSingle(new IntPtr(p + 0x088)); // 0x88 ScrollingDurationRatio      ( ModelPrimitiveType float float float Single )
            value.IsScrolling                               = GetBool(new IntPtr(p + 0x08C)); // 0x8C IsScrolling                 ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
