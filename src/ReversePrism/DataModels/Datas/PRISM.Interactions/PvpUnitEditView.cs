using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 HeaderPanelView                          0001865E4990 ModelClassType PvpHeaderPanelView PvpHeaderPanelView PvpHeaderPanelView Pointer
    // 028 UnitTypeTabGroup                         0001866F5490 ModelClassType UITabGroup UITabGroup UITabGroup Pointer
    // 030 GridHeaderView                           000186547AB0 ModelClassType FUHeaderView FUHeaderView FUHeaderView Pointer
    // 038 GridView                                 0001865F5DD0 ModelClassType PvpUnitEditGridView PvpUnitEditGridView PvpUnitEditGridView Pointer
    // 040 TotalCountText                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 SortFilterView                           000186580020 ModelClassType FilterAndSortView FilterAndSortView FilterAndSortView Pointer
    // 050 SortSwitch                               0001866F44A0 ModelClassType UISwitch UISwitch UISwitch Pointer
    // 058 DecideButton                             0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 060 PIdolUnitEditButton                      0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 068 fesUnitDetailPopupFactory                PopupViewFactory`1<IFUnitDetailPopupView> IL2CPP_TYPE_GENERICINST
    // 070 pIdolEditPopupViewFactory                PopupViewFactory`1<IPvpPIdolUnitEditPopupView> IL2CPP_TYPE_GENERICINST
    // 078 fesUnitSearchPopupViewFactory            PopupViewFactory`1<IFesUnitSearchPopupView> IL2CPP_TYPE_GENERICINST
    // 080 ViewModel                                0001865F7270 ModelClassType PvpUnitEditViewModel PvpUnitEditViewModel PvpUnitEditViewModel Pointer
    public partial class PvpUnitEditView
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
            var value   = new PvpUnitEditView();

            value.HeaderPanelView                           = GetObject<PvpHeaderPanelView>(new IntPtr(p + 0x020), ReversePrism.DataModels.PvpHeaderPanelView.FromPointer); // 0270DA14BA28 0x20 HeaderPanelView             ( 0001865E4990 ModelClassType PvpHeaderPanelView PvpHeaderPanelView PvpHeaderPanelView Pointer )
            value.UnitTypeTabGroup                          = GetObject<UITabGroup>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITabGroup.FromPointer); // 0270DA14BA48 0x28 UnitTypeTabGroup            ( 0001866F5490 ModelClassType UITabGroup UITabGroup UITabGroup Pointer )
            value.GridHeaderView                            = GetObject<FUHeaderView>(new IntPtr(p + 0x030), ReversePrism.DataModels.FUHeaderView.FromPointer); // 0270DA14BA68 0x30 GridHeaderView              ( 000186547AB0 ModelClassType FUHeaderView FUHeaderView FUHeaderView Pointer )
            value.GridView                                  = GetObject<PvpUnitEditGridView>(new IntPtr(p + 0x038), ReversePrism.DataModels.PvpUnitEditGridView.FromPointer); // 0270DA14BA88 0x38 GridView                    ( 0001865F5DD0 ModelClassType PvpUnitEditGridView PvpUnitEditGridView PvpUnitEditGridView Pointer )
            value.TotalCountText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA14BAA8 0x40 TotalCountText              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SortFilterView                            = GetObject<FilterAndSortView>(new IntPtr(p + 0x048), ReversePrism.DataModels.FilterAndSortView.FromPointer); // 0270DA14BAC8 0x48 SortFilterView              ( 000186580020 ModelClassType FilterAndSortView FilterAndSortView FilterAndSortView Pointer )
            value.SortSwitch                                = GetObject<UISwitch>(new IntPtr(p + 0x050), ReversePrism.DataModels.UISwitch.FromPointer); // 0270DA14BAE8 0x50 SortSwitch                  ( 0001866F44A0 ModelClassType UISwitch UISwitch UISwitch Pointer )
            value.DecideButton                              = GetObject<UIButton>(new IntPtr(p + 0x058), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA14BB08 0x58 DecideButton                ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.PIdolUnitEditButton                       = GetObject<UIButton>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA14BB28 0x60 PIdolUnitEditButton         ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.ViewModel                                 = GetObject<PvpUnitEditViewModel>(new IntPtr(p + 0x080), ReversePrism.DataModels.PvpUnitEditViewModel.FromPointer); // 0270DA14BBA8 0x80 ViewModel                   ( 0001865F7270 ModelClassType PvpUnitEditViewModel PvpUnitEditViewModel PvpUnitEditViewModel Pointer )

            return value;
        }
    }
}
