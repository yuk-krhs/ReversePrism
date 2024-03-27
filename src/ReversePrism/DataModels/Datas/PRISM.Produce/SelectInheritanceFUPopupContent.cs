using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 HeaderView                               000186547AB0 ModelClassType FUHeaderView FUHeaderView FUHeaderView Pointer
    // 068 GridView                                 0001866EFDB0 ModelClassType InheritanceUnitSelectGridView InheritanceUnitSelectGridView InheritanceUnitSelectGridView Pointer
    // 070 TxtEmptyView                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 FilterAndSortView                        000186580020 ModelClassType FilterAndSortView FilterAndSortView FilterAndSortView Pointer
    // 080 BtnSwitchSortDirection                   0001866F44A0 ModelClassType UISwitch UISwitch UISwitch Pointer
    // 088 NumText                                  0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 090 FesUnitSearchPopupCaller                 00018656A1C0 ModelClassType FesUnitSearchPopupCaller FesUnitSearchPopupCaller FesUnitSearchPopupCaller Pointer
    // 098 Model                                    00018656C2B0 ModelClassType FesUnitSelectModel FesUnitSelectModel FesUnitSelectModel Pointer
    // 0A0 Disposable                               0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 0A8 SelectedFavoriteMarkId                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0AC IsSetupFinish                            000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class SelectInheritanceFUPopupContent
    {
        public FUHeaderView?                            HeaderView                              { get; set; }
        public InheritanceUnitSelectGridView?           GridView                                { get; set; }
        public UITextMeshProUGUI?                       TxtEmptyView                            { get; set; }
        public FilterAndSortView?                       FilterAndSortView                       { get; set; }
        public UISwitch?                                BtnSwitchSortDirection                  { get; set; }
        public TextMeshProUGUI?                         NumText                                 { get; set; }
        public FesUnitSearchPopupCaller?                FesUnitSearchPopupCaller                { get; set; }
        public FesUnitSelectModel?                      Model                                   { get; set; }
        public CompositeDisposable?                     Disposable                              { get; set; }
        public int                                      SelectedFavoriteMarkId                  { get; set; }
        public bool                                     IsSetupFinish                           { get; set; }

        public static SelectInheritanceFUPopupContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SelectInheritanceFUPopupContent();

            value.HeaderView                                = GetObject<FUHeaderView>(new IntPtr(p + 0x060), ReversePrism.DataModels.FUHeaderView.FromPointer); // 0270D5A43360 0x60 HeaderView                  ( 000186547AB0 ModelClassType FUHeaderView FUHeaderView FUHeaderView Pointer )
            value.GridView                                  = GetObject<InheritanceUnitSelectGridView>(new IntPtr(p + 0x068), ReversePrism.DataModels.InheritanceUnitSelectGridView.FromPointer); // 0270D5A43380 0x68 GridView                    ( 0001866EFDB0 ModelClassType InheritanceUnitSelectGridView InheritanceUnitSelectGridView InheritanceUnitSelectGridView Pointer )
            value.TxtEmptyView                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5A433A0 0x70 TxtEmptyView                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.FilterAndSortView                         = GetObject<FilterAndSortView>(new IntPtr(p + 0x078), ReversePrism.DataModels.FilterAndSortView.FromPointer); // 0270D5A433C0 0x78 FilterAndSortView           ( 000186580020 ModelClassType FilterAndSortView FilterAndSortView FilterAndSortView Pointer )
            value.BtnSwitchSortDirection                    = GetObject<UISwitch>(new IntPtr(p + 0x080), ReversePrism.DataModels.UISwitch.FromPointer); // 0270D5A433E0 0x80 BtnSwitchSortDirection      ( 0001866F44A0 ModelClassType UISwitch UISwitch UISwitch Pointer )
            value.NumText                                   = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x088), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0270D5A43400 0x88 NumText                     ( 0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.FesUnitSearchPopupCaller                  = GetObject<FesUnitSearchPopupCaller>(new IntPtr(p + 0x090), ReversePrism.DataModels.FesUnitSearchPopupCaller.FromPointer); // 0270D5A43420 0x90 FesUnitSearchPopupCaller    ( 00018656A1C0 ModelClassType FesUnitSearchPopupCaller FesUnitSearchPopupCaller FesUnitSearchPopupCaller Pointer )
            value.Model                                     = GetObject<FesUnitSelectModel>(new IntPtr(p + 0x098), ReversePrism.DataModels.FesUnitSelectModel.FromPointer); // 0270D5A43440 0x98 Model                       ( 00018656C2B0 ModelClassType FesUnitSelectModel FesUnitSelectModel FesUnitSelectModel Pointer )
            value.Disposable                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0270D5A43460 0xA0 Disposable                  ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.SelectedFavoriteMarkId                    = GetInt32(new IntPtr(p + 0x0A8)); // 0270D5A43480 0xA8 SelectedFavoriteMarkId      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsSetupFinish                             = GetBool(new IntPtr(p + 0x0AC)); // 0270D5A434A0 0xAC IsSetupFinish               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
