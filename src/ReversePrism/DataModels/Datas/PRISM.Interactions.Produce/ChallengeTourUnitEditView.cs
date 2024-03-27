using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 UnitEditGridView                         000186589CC0 ModelClassType ChallengeTourUnitEditGridView ChallengeTourUnitEditGridView ChallengeTourUnitEditGridView Pointer
    // 028 SortFilterView                           000186580020 ModelClassType FilterAndSortView FilterAndSortView FilterAndSortView Pointer
    // 030 SortSwitch                               0001866F44A0 ModelClassType UISwitch UISwitch UISwitch Pointer
    // 038 DecideButton                             0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 040 PIdolSelectedObject                      0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 048 PIdolSelectButton                        0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 050 TotalCountText                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 BackButton                               00018651A320 ModelClassType ViewBackButton ViewBackButton ViewBackButton Pointer
    // 060 fUnitDetailPopupViewFactory              PopupViewFactory`1<IFUnitDetailPopupView> IL2CPP_TYPE_GENERICINST
    // 068 fUnitSearchPopupViewFactory              PopupViewFactory`1<IFesUnitSearchPopupView> IL2CPP_TYPE_GENERICINST
    // 070 pIdolEditPopupViewFactory                PopupViewFactory`1<IChallengeTourPIdolEditPopupView> IL2CPP_TYPE_GENERICINST
    // 078 ViewModel                                00018658B440 ModelClassType ChallengeTourUnitEditViewModel ChallengeTourUnitEditViewModel ChallengeTourUnitEditViewModel Pointer
    // 080 ResourceTag                              00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    // 088 CurrentType                              0001866B2B20 ModelEnumType IdolListFooterType IdolListFooterType IdolListFooterType Int32
    public partial class ChallengeTourUnitEditView
    {
        public ChallengeTourUnitEditGridView?           UnitEditGridView                        { get; set; }
        public FilterAndSortView?                       SortFilterView                          { get; set; }
        public UISwitch?                                SortSwitch                              { get; set; }
        public UIButton?                                DecideButton                            { get; set; }
        public GameObject?                              PIdolSelectedObject                     { get; set; }
        public UIButton?                                PIdolSelectButton                       { get; set; }
        public UITextMeshProUGUI?                       TotalCountText                          { get; set; }
        public ViewBackButton?                          BackButton                              { get; set; }
        public ChallengeTourUnitEditViewModel?          ViewModel                               { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }
        public IdolListFooterType                       CurrentType                             { get; set; }

        public static ChallengeTourUnitEditView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourUnitEditView();

            value.UnitEditGridView                          = GetObject<ChallengeTourUnitEditGridView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ChallengeTourUnitEditGridView.FromPointer); // 0270DA1D2A68 0x20 UnitEditGridView            ( 000186589CC0 ModelClassType ChallengeTourUnitEditGridView ChallengeTourUnitEditGridView ChallengeTourUnitEditGridView Pointer )
            value.SortFilterView                            = GetObject<FilterAndSortView>(new IntPtr(p + 0x028), ReversePrism.DataModels.FilterAndSortView.FromPointer); // 0270DA1D2A88 0x28 SortFilterView              ( 000186580020 ModelClassType FilterAndSortView FilterAndSortView FilterAndSortView Pointer )
            value.SortSwitch                                = GetObject<UISwitch>(new IntPtr(p + 0x030), ReversePrism.DataModels.UISwitch.FromPointer); // 0270DA1D2AA8 0x30 SortSwitch                  ( 0001866F44A0 ModelClassType UISwitch UISwitch UISwitch Pointer )
            value.DecideButton                              = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA1D2AC8 0x38 DecideButton                ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.PIdolSelectedObject                       = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA1D2AE8 0x40 PIdolSelectedObject         ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.PIdolSelectButton                         = GetObject<UIButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA1D2B08 0x48 PIdolSelectButton           ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.TotalCountText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA1D2B28 0x50 TotalCountText              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BackButton                                = GetObject<ViewBackButton>(new IntPtr(p + 0x058), ReversePrism.DataModels.ViewBackButton.FromPointer); // 0270DA1D2B48 0x58 BackButton                  ( 00018651A320 ModelClassType ViewBackButton ViewBackButton ViewBackButton Pointer )
            value.ViewModel                                 = GetObject<ChallengeTourUnitEditViewModel>(new IntPtr(p + 0x078), ReversePrism.DataModels.ChallengeTourUnitEditViewModel.FromPointer); // 0270DA1D2BC8 0x78 ViewModel                   ( 00018658B440 ModelClassType ChallengeTourUnitEditViewModel ChallengeTourUnitEditViewModel ChallengeTourUnitEditViewModel Pointer )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x080), ReversePrism.DataModels.IResourceTag.FromPointer); // 0270DA1D2BE8 0x80 ResourceTag                 ( 00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )
            value.CurrentType                               = (IdolListFooterType)GetInt32(new IntPtr(p + 0x088)); // 0270DA1D2C08 0x88 CurrentType                 ( 0001866B2B20 ModelEnumType IdolListFooterType IdolListFooterType IdolListFooterType Int32 )

            return value;
        }
    }
}
