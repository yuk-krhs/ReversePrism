using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 GridView                                 0001867335D0 ModelClassType EnhancedCharacterSelectGridView EnhancedCharacterSelectGridView EnhancedCharacterSelectGridView Pointer
    // 028 TxtEmptyView                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 FilterAndSortView                        000186580020 ModelClassType FilterAndSortView FilterAndSortView FilterAndSortView Pointer
    // 038 BtnSwitchSortDirection                   0001866F44A0 ModelClassType UISwitch UISwitch UISwitch Pointer
    // 040 FooterView                               00018655D970 ModelClassType FavoriteTransferFooterView FavoriteTransferFooterView FavoriteTransferFooterView Pointer
    // 048 TxtGuide                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 onSelectIndex                            Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 058 onSelectIndexAsFavorite                  Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 060 onSelectIndexAsTransfer                  Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 068 onFilterSort                             Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 070 onSortDirection                          Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 078 onChangeFooterType                       Subject`1<IdolListFooterType> IL2CPP_TYPE_GENERICINST
    // 080 onBatchFavorite                          Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 088 onBatchTransfer                          Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 090 Disposables                              0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    public partial class FesIdolListView : DataModel
    {
        public EnhancedCharacterSelectGridView?         GridView                                { get; set; }
        public UITextMeshProUGUI?                       TxtEmptyView                            { get; set; }
        public FilterAndSortView?                       FilterAndSortView                       { get; set; }
        public UISwitch?                                BtnSwitchSortDirection                  { get; set; }
        public FavoriteTransferFooterView?              FooterView                              { get; set; }
        public UITextMeshProUGUI?                       TxtGuide                                { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }

        public static FesIdolListView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FesIdolListView() { Pointer= p0 };

            value.GridView                                  = GetObject<EnhancedCharacterSelectGridView>(new IntPtr(p + 0x020), ReversePrism.DataModels.EnhancedCharacterSelectGridView.FromPointer); // 02466A2C4ED0 0x20 GridView                    ( 0001867335D0 ModelClassType EnhancedCharacterSelectGridView EnhancedCharacterSelectGridView EnhancedCharacterSelectGridView Pointer )
            value.TxtEmptyView                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A2C4EF0 0x28 TxtEmptyView                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.FilterAndSortView                         = GetObject<FilterAndSortView>(new IntPtr(p + 0x030), ReversePrism.DataModels.FilterAndSortView.FromPointer); // 02466A2C4F10 0x30 FilterAndSortView           ( 000186580020 ModelClassType FilterAndSortView FilterAndSortView FilterAndSortView Pointer )
            value.BtnSwitchSortDirection                    = GetObject<UISwitch>(new IntPtr(p + 0x038), ReversePrism.DataModels.UISwitch.FromPointer); // 02466A2C4F30 0x38 BtnSwitchSortDirection      ( 0001866F44A0 ModelClassType UISwitch UISwitch UISwitch Pointer )
            value.FooterView                                = GetObject<FavoriteTransferFooterView>(new IntPtr(p + 0x040), ReversePrism.DataModels.FavoriteTransferFooterView.FromPointer); // 02466A2C4F50 0x40 FooterView                  ( 00018655D970 ModelClassType FavoriteTransferFooterView FavoriteTransferFooterView FavoriteTransferFooterView Pointer )
            value.TxtGuide                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A2C4F70 0x48 TxtGuide                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x090), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 02466A2C5090 0x90 Disposables                 ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
