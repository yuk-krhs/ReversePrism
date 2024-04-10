using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Scroller                                 000186735270 ModelClassType EnhancedScroller EnhancedScroller EnhancedScroller Pointer
    // 028 CellViewPrefabs                          000185B7B660 ModelClassListType EnhancedScrollerCellView[] EnhancedScrollerCellView[] List<EnhancedScrollerCellView> Pointer
    // 030 ItemColumnPrefab                         00018667F480 ModelClassType RewardItemColumn RewardItemColumn RewardItemColumn Pointer
    // 038 StatusColumnPrefab                       000186680920 ModelClassType RewardStatusColumn RewardStatusColumn RewardStatusColumn Pointer
    // 040 BorderLinePrefab                         0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 048 ViewModel                                0001866A9610 ModelClassType IdolBaseDetailRewardListViewModel IdolBaseDetailRewardListViewModel IdolBaseDetailRewardListViewModel Pointer
    // 050 ItemColumnHeight                         0001866656B0 ModelPrimitiveType float float float Single
    // 054 StatusColumnHeight                       0001866656B0 ModelPrimitiveType float float float Single
    // 058 BorderLineHeight                         0001866656B0 ModelPrimitiveType float float float Single
    public partial class VariableCellListView : DataModel
    {
        public EnhancedScroller?                        Scroller                                { get; set; }
        public List<EnhancedScrollerCellView>?          CellViewPrefabs                         { get; set; }
        public RewardItemColumn?                        ItemColumnPrefab                        { get; set; }
        public RewardStatusColumn?                      StatusColumnPrefab                      { get; set; }
        public GameObject?                              BorderLinePrefab                        { get; set; }
        public IdolBaseDetailRewardListViewModel?       ViewModel                               { get; set; }
        public float                                    ItemColumnHeight                        { get; set; }
        public float                                    StatusColumnHeight                      { get; set; }
        public float                                    BorderLineHeight                        { get; set; }

        public static VariableCellListView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VariableCellListView() { Pointer= p0 };

            value.Scroller                                  = GetObject<EnhancedScroller>(new IntPtr(p + 0x020), ReversePrism.DataModels.EnhancedScroller.FromPointer); // 02466A351648 0x20 Scroller                    ( 000186735270 ModelClassType EnhancedScroller EnhancedScroller EnhancedScroller Pointer )
            value.CellViewPrefabs                           = GetObjectList<EnhancedScrollerCellView>(new IntPtr(p + 0x028), ReversePrism.DataModels.EnhancedScrollerCellView.FromPointer); // 02466A351668 0x28 CellViewPrefabs             ( 000185B7B660 ModelClassListType EnhancedScrollerCellView[] EnhancedScrollerCellView[] List<EnhancedScrollerCellView> Pointer )
            value.ItemColumnPrefab                          = GetObject<RewardItemColumn>(new IntPtr(p + 0x030), ReversePrism.DataModels.RewardItemColumn.FromPointer); // 02466A351688 0x30 ItemColumnPrefab            ( 00018667F480 ModelClassType RewardItemColumn RewardItemColumn RewardItemColumn Pointer )
            value.StatusColumnPrefab                        = GetObject<RewardStatusColumn>(new IntPtr(p + 0x038), ReversePrism.DataModels.RewardStatusColumn.FromPointer); // 02466A3516A8 0x38 StatusColumnPrefab          ( 000186680920 ModelClassType RewardStatusColumn RewardStatusColumn RewardStatusColumn Pointer )
            value.BorderLinePrefab                          = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 02466A3516C8 0x40 BorderLinePrefab            ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ViewModel                                 = GetObject<IdolBaseDetailRewardListViewModel>(new IntPtr(p + 0x048), ReversePrism.DataModels.IdolBaseDetailRewardListViewModel.FromPointer); // 02466A3516E8 0x48 ViewModel                   ( 0001866A9610 ModelClassType IdolBaseDetailRewardListViewModel IdolBaseDetailRewardListViewModel IdolBaseDetailRewardListViewModel Pointer )
            value.ItemColumnHeight                          = GetSingle(new IntPtr(p + 0x050)); // 02466A351708 0x50 ItemColumnHeight            ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.StatusColumnHeight                        = GetSingle(new IntPtr(p + 0x054)); // 02466A351728 0x54 StatusColumnHeight          ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.BorderLineHeight                          = GetSingle(new IntPtr(p + 0x058)); // 02466A351748 0x58 BorderLineHeight            ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
