using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Scroller                                 ModelClassType EnhancedScroller EnhancedScroller EnhancedScroller Pointer
    // 028 CellViewPrefabs                          ModelClassListType EnhancedScrollerCellView[] EnhancedScrollerCellView[] List<EnhancedScrollerCellView> Pointer
    // 030 ItemColumnPrefab                         ModelClassType RewardItemColumn RewardItemColumn RewardItemColumn Pointer
    // 038 StatusColumnPrefab                       ModelClassType RewardStatusColumn RewardStatusColumn RewardStatusColumn Pointer
    // 040 BorderLinePrefab                         ModelClassType GameObject GameObject GameObject Pointer
    // 048 ViewModel                                ModelClassType IdolBaseDetailRewardListViewModel IdolBaseDetailRewardListViewModel IdolBaseDetailRewardListViewModel Pointer
    // 050 ItemColumnHeight                         ModelPrimitiveType float float float Single
    // 054 StatusColumnHeight                       ModelPrimitiveType float float float Single
    // 058 BorderLineHeight                         ModelPrimitiveType float float float Single
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

            value.Scroller                                  = GetObject<EnhancedScroller>(new IntPtr(p + 0x020), ReversePrism.DataModels.EnhancedScroller.FromPointer); // 0x20 Scroller                    ( ModelClassType EnhancedScroller EnhancedScroller EnhancedScroller Pointer )
            value.CellViewPrefabs                           = GetObjectList<EnhancedScrollerCellView>(new IntPtr(p + 0x028), ReversePrism.DataModels.EnhancedScrollerCellView.FromPointer); // 0x28 CellViewPrefabs             ( ModelClassListType EnhancedScrollerCellView[] EnhancedScrollerCellView[] List<EnhancedScrollerCellView> Pointer )
            value.ItemColumnPrefab                          = GetObject<RewardItemColumn>(new IntPtr(p + 0x030), ReversePrism.DataModels.RewardItemColumn.FromPointer); // 0x30 ItemColumnPrefab            ( ModelClassType RewardItemColumn RewardItemColumn RewardItemColumn Pointer )
            value.StatusColumnPrefab                        = GetObject<RewardStatusColumn>(new IntPtr(p + 0x038), ReversePrism.DataModels.RewardStatusColumn.FromPointer); // 0x38 StatusColumnPrefab          ( ModelClassType RewardStatusColumn RewardStatusColumn RewardStatusColumn Pointer )
            value.BorderLinePrefab                          = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0x40 BorderLinePrefab            ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ViewModel                                 = GetObject<IdolBaseDetailRewardListViewModel>(new IntPtr(p + 0x048), ReversePrism.DataModels.IdolBaseDetailRewardListViewModel.FromPointer); // 0x48 ViewModel                   ( ModelClassType IdolBaseDetailRewardListViewModel IdolBaseDetailRewardListViewModel IdolBaseDetailRewardListViewModel Pointer )
            value.ItemColumnHeight                          = GetSingle(new IntPtr(p + 0x050)); // 0x50 ItemColumnHeight            ( ModelPrimitiveType float float float Single )
            value.StatusColumnHeight                        = GetSingle(new IntPtr(p + 0x054)); // 0x54 StatusColumnHeight          ( ModelPrimitiveType float float float Single )
            value.BorderLineHeight                          = GetSingle(new IntPtr(p + 0x058)); // 0x58 BorderLineHeight            ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
