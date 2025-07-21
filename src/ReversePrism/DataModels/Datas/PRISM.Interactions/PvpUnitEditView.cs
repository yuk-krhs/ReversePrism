using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 HeaderPanelView                          ModelClassType PvpHeaderPanelView PvpHeaderPanelView PvpHeaderPanelView Pointer
    // 028 UnitTypeTabGroup                         ModelClassType UITabGroup UITabGroup UITabGroup Pointer
    // 030 GridHeaderView                           ModelClassType FUHeaderView FUHeaderView FUHeaderView Pointer
    // 038 GridView                                 ModelClassType PvpUnitEditGridView PvpUnitEditGridView PvpUnitEditGridView Pointer
    // 040 TotalCountText                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 SortFilterView                           ModelClassType FilterAndSortView FilterAndSortView FilterAndSortView Pointer
    // 050 SortSwitch                               ModelClassType UISwitch UISwitch UISwitch Pointer
    // 058 DecideButton                             ModelClassType UIButton UIButton UIButton Pointer
    // 060 PIdolUnitEditButton                      ModelClassType UIButton UIButton UIButton Pointer
    // 068 ViewModel                                ModelClassType PvpUnitEditViewModel PvpUnitEditViewModel PvpUnitEditViewModel Pointer
    public partial class PvpUnitEditView : DataModel
    {
        public PvpHeaderPanelView?                      HeaderPanelView                         { get; set; }
        public UITabGroup?                              UnitTypeTabGroup                        { get; set; }
        public FUHeaderView?                            GridHeaderView                          { get; set; }
        public PvpUnitEditGridView?                     GridView                                { get; set; }
        public UITextMeshProUGUI?                       TotalCountText                          { get; set; }
        public FilterAndSortView?                       SortFilterView                          { get; set; }
        public UISwitch?                                SortSwitch                              { get; set; }
        public UIButton?                                DecideButton                            { get; set; }
        public UIButton?                                PIdolUnitEditButton                     { get; set; }
        public PvpUnitEditViewModel?                    ViewModel                               { get; set; }

        public static PvpUnitEditView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PvpUnitEditView() { Pointer= p0 };

            value.HeaderPanelView                           = GetObject<PvpHeaderPanelView>(new IntPtr(p + 0x020), ReversePrism.DataModels.PvpHeaderPanelView.FromPointer); // 0x20 HeaderPanelView             ( ModelClassType PvpHeaderPanelView PvpHeaderPanelView PvpHeaderPanelView Pointer )
            value.UnitTypeTabGroup                          = GetObject<UITabGroup>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITabGroup.FromPointer); // 0x28 UnitTypeTabGroup            ( ModelClassType UITabGroup UITabGroup UITabGroup Pointer )
            value.GridHeaderView                            = GetObject<FUHeaderView>(new IntPtr(p + 0x030), ReversePrism.DataModels.FUHeaderView.FromPointer); // 0x30 GridHeaderView              ( ModelClassType FUHeaderView FUHeaderView FUHeaderView Pointer )
            value.GridView                                  = GetObject<PvpUnitEditGridView>(new IntPtr(p + 0x038), ReversePrism.DataModels.PvpUnitEditGridView.FromPointer); // 0x38 GridView                    ( ModelClassType PvpUnitEditGridView PvpUnitEditGridView PvpUnitEditGridView Pointer )
            value.TotalCountText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 TotalCountText              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SortFilterView                            = GetObject<FilterAndSortView>(new IntPtr(p + 0x048), ReversePrism.DataModels.FilterAndSortView.FromPointer); // 0x48 SortFilterView              ( ModelClassType FilterAndSortView FilterAndSortView FilterAndSortView Pointer )
            value.SortSwitch                                = GetObject<UISwitch>(new IntPtr(p + 0x050), ReversePrism.DataModels.UISwitch.FromPointer); // 0x50 SortSwitch                  ( ModelClassType UISwitch UISwitch UISwitch Pointer )
            value.DecideButton                              = GetObject<UIButton>(new IntPtr(p + 0x058), ReversePrism.DataModels.UIButton.FromPointer); // 0x58 DecideButton                ( ModelClassType UIButton UIButton UIButton Pointer )
            value.PIdolUnitEditButton                       = GetObject<UIButton>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIButton.FromPointer); // 0x60 PIdolUnitEditButton         ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ViewModel                                 = GetObject<PvpUnitEditViewModel>(new IntPtr(p + 0x068), ReversePrism.DataModels.PvpUnitEditViewModel.FromPointer); // 0x68 ViewModel                   ( ModelClassType PvpUnitEditViewModel PvpUnitEditViewModel PvpUnitEditViewModel Pointer )

            return value;
        }
    }
}
