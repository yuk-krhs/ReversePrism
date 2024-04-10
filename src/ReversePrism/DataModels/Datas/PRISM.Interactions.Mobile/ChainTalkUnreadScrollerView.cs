using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ScrollRect                               0001866F7FA0 ModelClassType ScrollRect ScrollRect ScrollRect Pointer
    // 028 TouchArea                                0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 030 CellParent                               0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 038 CellPrefabs                              000185B73C40 ModelClassListType ChainTalkCellForUnreadScroller[] ChainTalkCellForUnreadScroller[] List<ChainTalkCellForUnreadScroller> Pointer
    // 040 SeparatorCellBasePrefab                  0001865665A0 ModelClassType ChainTalkSeparatorCell ChainTalkSeparatorCell ChainTalkSeparatorCell Pointer
    // 048 ChoiceButtonGroup                        000186560190 ModelClassType ChainTalkChoiceButtonGroup ChainTalkChoiceButtonGroup ChainTalkChoiceButtonGroup Pointer
    // 050 TypingDataScriptableObject               000186568690 ModelClassType ChainTalkUserTypingData ChainTalkUserTypingData ChainTalkUserTypingData Pointer
    // 058 IsClicked                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 060 ResourceTag                              00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    public partial class ChainTalkUnreadScrollerView : DataModel
    {
        public ScrollRect?                              ScrollRect                              { get; set; }
        public UIButton?                                TouchArea                               { get; set; }
        public Transform?                               CellParent                              { get; set; }
        public List<ChainTalkCellForUnreadScroller>?    CellPrefabs                             { get; set; }
        public ChainTalkSeparatorCell?                  SeparatorCellBasePrefab                 { get; set; }
        public ChainTalkChoiceButtonGroup?              ChoiceButtonGroup                       { get; set; }
        public ChainTalkUserTypingData?                 TypingDataScriptableObject              { get; set; }
        public bool                                     IsClicked                               { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }

        public static ChainTalkUnreadScrollerView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChainTalkUnreadScrollerView() { Pointer= p0 };

            value.ScrollRect                                = GetObject<ScrollRect>(new IntPtr(p + 0x020), ReversePrism.DataModels.ScrollRect.FromPointer); // 02466B14E290 0x20 ScrollRect                  ( 0001866F7FA0 ModelClassType ScrollRect ScrollRect ScrollRect Pointer )
            value.TouchArea                                 = GetObject<UIButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIButton.FromPointer); // 02466B14E2B0 0x28 TouchArea                   ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.CellParent                                = GetObject<Transform>(new IntPtr(p + 0x030), ReversePrism.DataModels.Transform.FromPointer); // 02466B14E2D0 0x30 CellParent                  ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.CellPrefabs                               = GetObjectList<ChainTalkCellForUnreadScroller>(new IntPtr(p + 0x038), ReversePrism.DataModels.ChainTalkCellForUnreadScroller.FromPointer); // 02466B14E2F0 0x38 CellPrefabs                 ( 000185B73C40 ModelClassListType ChainTalkCellForUnreadScroller[] ChainTalkCellForUnreadScroller[] List<ChainTalkCellForUnreadScroller> Pointer )
            value.SeparatorCellBasePrefab                   = GetObject<ChainTalkSeparatorCell>(new IntPtr(p + 0x040), ReversePrism.DataModels.ChainTalkSeparatorCell.FromPointer); // 02466B14E310 0x40 SeparatorCellBasePrefab     ( 0001865665A0 ModelClassType ChainTalkSeparatorCell ChainTalkSeparatorCell ChainTalkSeparatorCell Pointer )
            value.ChoiceButtonGroup                         = GetObject<ChainTalkChoiceButtonGroup>(new IntPtr(p + 0x048), ReversePrism.DataModels.ChainTalkChoiceButtonGroup.FromPointer); // 02466B14E330 0x48 ChoiceButtonGroup           ( 000186560190 ModelClassType ChainTalkChoiceButtonGroup ChainTalkChoiceButtonGroup ChainTalkChoiceButtonGroup Pointer )
            value.TypingDataScriptableObject                = GetObject<ChainTalkUserTypingData>(new IntPtr(p + 0x050), ReversePrism.DataModels.ChainTalkUserTypingData.FromPointer); // 02466B14E350 0x50 TypingDataScriptableObject  ( 000186568690 ModelClassType ChainTalkUserTypingData ChainTalkUserTypingData ChainTalkUserTypingData Pointer )
            value.IsClicked                                 = GetBool(new IntPtr(p + 0x058)); // 02466B14E370 0x58 IsClicked                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x060), ReversePrism.DataModels.IResourceTag.FromPointer); // 02466B14E390 0x60 ResourceTag                 ( 00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )

            return value;
        }
    }
}
