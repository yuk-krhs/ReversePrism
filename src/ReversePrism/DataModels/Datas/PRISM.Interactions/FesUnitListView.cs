using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 HeaderView                               ModelClassType FUHeaderView FUHeaderView FUHeaderView Pointer
    // 028 GridView                                 ModelClassType EnhancedUnitSelectGridView EnhancedUnitSelectGridView EnhancedUnitSelectGridView Pointer
    // 030 TxtEmptyView                             ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 FilterAndSortView                        ModelClassType FilterAndSortView FilterAndSortView FilterAndSortView Pointer
    // 040 BtnSwitchSortDirection                   ModelClassType UISwitch UISwitch UISwitch Pointer
    // 048 FooterView                               ModelClassType FavoriteTransferFooterView FavoriteTransferFooterView FavoriteTransferFooterView Pointer
    // 050 TxtGuide                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 onSelectIndex                            Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 060 onSelectIndexAsFavorite                  Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 068 onSelectIndexAsTransfer                  Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 070 onFilterSort                             Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 078 onSortDirection                          Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 080 onHeaderUnit                             Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 088 onChangeFooterType                       Subject`1<IdolListFooterType> IL2CPP_TYPE_GENERICINST
    // 090 onBatchFavorite                          Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 098 onBatchTransfer                          Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 0A0 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    public partial class FesUnitListView : DataModel
    {
        public FUHeaderView?                            HeaderView                              { get; set; }
        public EnhancedUnitSelectGridView?              GridView                                { get; set; }
        public UITextMeshProUGUI?                       TxtEmptyView                            { get; set; }
        public FilterAndSortView?                       FilterAndSortView                       { get; set; }
        public UISwitch?                                BtnSwitchSortDirection                  { get; set; }
        public FavoriteTransferFooterView?              FooterView                              { get; set; }
        public UITextMeshProUGUI?                       TxtGuide                                { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }

        public static FesUnitListView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FesUnitListView() { Pointer= p0 };

            value.HeaderView                                = GetObject<FUHeaderView>(new IntPtr(p + 0x020), ReversePrism.DataModels.FUHeaderView.FromPointer); // 0x20 HeaderView                  ( ModelClassType FUHeaderView FUHeaderView FUHeaderView Pointer )
            value.GridView                                  = GetObject<EnhancedUnitSelectGridView>(new IntPtr(p + 0x028), ReversePrism.DataModels.EnhancedUnitSelectGridView.FromPointer); // 0x28 GridView                    ( ModelClassType EnhancedUnitSelectGridView EnhancedUnitSelectGridView EnhancedUnitSelectGridView Pointer )
            value.TxtEmptyView                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 TxtEmptyView                ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.FilterAndSortView                         = GetObject<FilterAndSortView>(new IntPtr(p + 0x038), ReversePrism.DataModels.FilterAndSortView.FromPointer); // 0x38 FilterAndSortView           ( ModelClassType FilterAndSortView FilterAndSortView FilterAndSortView Pointer )
            value.BtnSwitchSortDirection                    = GetObject<UISwitch>(new IntPtr(p + 0x040), ReversePrism.DataModels.UISwitch.FromPointer); // 0x40 BtnSwitchSortDirection      ( ModelClassType UISwitch UISwitch UISwitch Pointer )
            value.FooterView                                = GetObject<FavoriteTransferFooterView>(new IntPtr(p + 0x048), ReversePrism.DataModels.FavoriteTransferFooterView.FromPointer); // 0x48 FooterView                  ( ModelClassType FavoriteTransferFooterView FavoriteTransferFooterView FavoriteTransferFooterView Pointer )
            value.TxtGuide                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x50 TxtGuide                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0xA0 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
