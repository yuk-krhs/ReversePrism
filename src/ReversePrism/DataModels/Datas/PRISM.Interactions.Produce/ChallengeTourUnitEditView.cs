using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 UnitEditGridView                         ModelClassType ChallengeTourUnitEditGridView ChallengeTourUnitEditGridView ChallengeTourUnitEditGridView Pointer
    // 028 SortFilterView                           ModelClassType FilterAndSortView FilterAndSortView FilterAndSortView Pointer
    // 030 SortSwitch                               ModelClassType UISwitch UISwitch UISwitch Pointer
    // 038 DecideButton                             ModelClassType UIButton UIButton UIButton Pointer
    // 040 PIdolSelectedObject                      ModelClassType GameObject GameObject GameObject Pointer
    // 048 PIdolSelectButton                        ModelClassType UIButton UIButton UIButton Pointer
    // 050 TotalCountText                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 BackButton                               ModelClassType ViewBackButton ViewBackButton ViewBackButton Pointer
    // 060 ViewModel                                ModelClassType ChallengeTourUnitEditViewModel ChallengeTourUnitEditViewModel ChallengeTourUnitEditViewModel Pointer
    // 068 CurrentType                              ModelEnumType IdolListFooterType IdolListFooterType IdolListFooterType Int32
    public partial class ChallengeTourUnitEditView : DataModel
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
        public IdolListFooterType                       CurrentType                             { get; set; }

        public static ChallengeTourUnitEditView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourUnitEditView() { Pointer= p0 };

            value.UnitEditGridView                          = GetObject<ChallengeTourUnitEditGridView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ChallengeTourUnitEditGridView.FromPointer); // 0x20 UnitEditGridView            ( ModelClassType ChallengeTourUnitEditGridView ChallengeTourUnitEditGridView ChallengeTourUnitEditGridView Pointer )
            value.SortFilterView                            = GetObject<FilterAndSortView>(new IntPtr(p + 0x028), ReversePrism.DataModels.FilterAndSortView.FromPointer); // 0x28 SortFilterView              ( ModelClassType FilterAndSortView FilterAndSortView FilterAndSortView Pointer )
            value.SortSwitch                                = GetObject<UISwitch>(new IntPtr(p + 0x030), ReversePrism.DataModels.UISwitch.FromPointer); // 0x30 SortSwitch                  ( ModelClassType UISwitch UISwitch UISwitch Pointer )
            value.DecideButton                              = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0x38 DecideButton                ( ModelClassType UIButton UIButton UIButton Pointer )
            value.PIdolSelectedObject                       = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0x40 PIdolSelectedObject         ( ModelClassType GameObject GameObject GameObject Pointer )
            value.PIdolSelectButton                         = GetObject<UIButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIButton.FromPointer); // 0x48 PIdolSelectButton           ( ModelClassType UIButton UIButton UIButton Pointer )
            value.TotalCountText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x50 TotalCountText              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BackButton                                = GetObject<ViewBackButton>(new IntPtr(p + 0x058), ReversePrism.DataModels.ViewBackButton.FromPointer); // 0x58 BackButton                  ( ModelClassType ViewBackButton ViewBackButton ViewBackButton Pointer )
            value.ViewModel                                 = GetObject<ChallengeTourUnitEditViewModel>(new IntPtr(p + 0x060), ReversePrism.DataModels.ChallengeTourUnitEditViewModel.FromPointer); // 0x60 ViewModel                   ( ModelClassType ChallengeTourUnitEditViewModel ChallengeTourUnitEditViewModel ChallengeTourUnitEditViewModel Pointer )
            value.CurrentType                               = (IdolListFooterType)GetInt32(new IntPtr(p + 0x068)); // 0x68 CurrentType                 ( ModelEnumType IdolListFooterType IdolListFooterType IdolListFooterType Int32 )

            return value;
        }
    }
}
