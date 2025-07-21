using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ScrollRect                               ModelClassType ScrollRect ScrollRect ScrollRect Pointer
    // 028 TouchArea                                ModelClassType UIButton UIButton UIButton Pointer
    // 030 CellParent                               ModelClassType Transform Transform Transform Pointer
    // 038 CellPrefabs                              ModelClassListType ChainTalkCellForUnreadScroller[] ChainTalkCellForUnreadScroller[] List<ChainTalkCellForUnreadScroller> Pointer
    // 040 SeparatorCellBasePrefab                  ModelClassType ChainTalkSeparatorCell ChainTalkSeparatorCell ChainTalkSeparatorCell Pointer
    // 048 ChoiceButtonGroup                        ModelClassType ChainTalkChoiceButtonGroup ChainTalkChoiceButtonGroup ChainTalkChoiceButtonGroup Pointer
    // 050 TypingDataScriptableObject               ModelClassType ChainTalkUserTypingData ChainTalkUserTypingData ChainTalkUserTypingData Pointer
    // 058 IsClicked                                ModelPrimitiveType bool bool bool Bool
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

        public static ChainTalkUnreadScrollerView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChainTalkUnreadScrollerView() { Pointer= p0 };

            value.ScrollRect                                = GetObject<ScrollRect>(new IntPtr(p + 0x020), ReversePrism.DataModels.ScrollRect.FromPointer); // 0x20 ScrollRect                  ( ModelClassType ScrollRect ScrollRect ScrollRect Pointer )
            value.TouchArea                                 = GetObject<UIButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIButton.FromPointer); // 0x28 TouchArea                   ( ModelClassType UIButton UIButton UIButton Pointer )
            value.CellParent                                = GetObject<Transform>(new IntPtr(p + 0x030), ReversePrism.DataModels.Transform.FromPointer); // 0x30 CellParent                  ( ModelClassType Transform Transform Transform Pointer )
            value.CellPrefabs                               = GetObjectList<ChainTalkCellForUnreadScroller>(new IntPtr(p + 0x038), ReversePrism.DataModels.ChainTalkCellForUnreadScroller.FromPointer); // 0x38 CellPrefabs                 ( ModelClassListType ChainTalkCellForUnreadScroller[] ChainTalkCellForUnreadScroller[] List<ChainTalkCellForUnreadScroller> Pointer )
            value.SeparatorCellBasePrefab                   = GetObject<ChainTalkSeparatorCell>(new IntPtr(p + 0x040), ReversePrism.DataModels.ChainTalkSeparatorCell.FromPointer); // 0x40 SeparatorCellBasePrefab     ( ModelClassType ChainTalkSeparatorCell ChainTalkSeparatorCell ChainTalkSeparatorCell Pointer )
            value.ChoiceButtonGroup                         = GetObject<ChainTalkChoiceButtonGroup>(new IntPtr(p + 0x048), ReversePrism.DataModels.ChainTalkChoiceButtonGroup.FromPointer); // 0x48 ChoiceButtonGroup           ( ModelClassType ChainTalkChoiceButtonGroup ChainTalkChoiceButtonGroup ChainTalkChoiceButtonGroup Pointer )
            value.TypingDataScriptableObject                = GetObject<ChainTalkUserTypingData>(new IntPtr(p + 0x050), ReversePrism.DataModels.ChainTalkUserTypingData.FromPointer); // 0x50 TypingDataScriptableObject  ( ModelClassType ChainTalkUserTypingData ChainTalkUserTypingData ChainTalkUserTypingData Pointer )
            value.IsClicked                                 = GetBool(new IntPtr(p + 0x058)); // 0x58 IsClicked                   ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
