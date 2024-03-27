using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DecideReactiveProperty                   0001867695E0 ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer
    // 018 sortFilterSaveData                       SavableJsonObject`1<IdolListFUSortFilterPermanentData> IL2CPP_TYPE_GENERICINST
    // 020 FUnitIcons                               000185B7E800 ModelClassListType FUnitIcon[] FUnitIcon[] List<FUnitIcon> Pointer
    // 028 DisplayFUnitIcons                        000185B7E800 ModelClassListType FUnitIcon[] FUnitIcon[] List<FUnitIcon> Pointer
    // 030 SortFilterModel                          00018654D810 ModelClassType FUnitSortFilterModel FUnitSortFilterModel FUnitSortFilterModel Pointer
    // 038 ChallengeTourViewModel                   00018658D950 ModelClassType ChallengeTourUnitViewModel ChallengeTourUnitViewModel ChallengeTourUnitViewModel Pointer
    // 040 SelectedFUnitIcon                        00018654C680 ModelClassType FUnitIcon FUnitIcon FUnitIcon Pointer
    // 048 InChallengeTourSelected                  000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class ChallengeTourUnitEditViewModel
    {
        public BoolReactiveProperty?                    DecideReactiveProperty                  { get; set; }
        public List<FUnitIcon>?                         FUnitIcons                              { get; set; }
        public List<FUnitIcon>?                         DisplayFUnitIcons                       { get; set; }
        public FUnitSortFilterModel?                    SortFilterModel                         { get; set; }
        public ChallengeTourUnitViewModel?              ChallengeTourViewModel                  { get; set; }
        public FUnitIcon?                               SelectedFUnitIcon                       { get; set; }
        public bool                                     InChallengeTourSelected                 { get; set; }

        public static ChallengeTourUnitEditViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourUnitEditViewModel();

            value.DecideReactiveProperty                    = GetObject<BoolReactiveProperty>(new IntPtr(p + 0x010), ReversePrism.DataModels.BoolReactiveProperty.FromPointer); // 0270D64BE4F0 0x10 DecideReactiveProperty      ( 0001867695E0 ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer )
            value.FUnitIcons                                = GetObjectList<FUnitIcon>(new IntPtr(p + 0x020), ReversePrism.DataModels.FUnitIcon.FromPointer); // 0270D64BE530 0x20 FUnitIcons                  ( 000185B7E800 ModelClassListType FUnitIcon[] FUnitIcon[] List<FUnitIcon> Pointer )
            value.DisplayFUnitIcons                         = GetObjectList<FUnitIcon>(new IntPtr(p + 0x028), ReversePrism.DataModels.FUnitIcon.FromPointer); // 0270D64BE550 0x28 DisplayFUnitIcons           ( 000185B7E800 ModelClassListType FUnitIcon[] FUnitIcon[] List<FUnitIcon> Pointer )
            value.SortFilterModel                           = GetObject<FUnitSortFilterModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.FUnitSortFilterModel.FromPointer); // 0270D64BE570 0x30 SortFilterModel             ( 00018654D810 ModelClassType FUnitSortFilterModel FUnitSortFilterModel FUnitSortFilterModel Pointer )
            value.ChallengeTourViewModel                    = GetObject<ChallengeTourUnitViewModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.ChallengeTourUnitViewModel.FromPointer); // 0270D64BE590 0x38 ChallengeTourViewModel      ( 00018658D950 ModelClassType ChallengeTourUnitViewModel ChallengeTourUnitViewModel ChallengeTourUnitViewModel Pointer )
            value.SelectedFUnitIcon                         = GetObject<FUnitIcon>(new IntPtr(p + 0x040), ReversePrism.DataModels.FUnitIcon.FromPointer); // 0270D64BE5B0 0x40 SelectedFUnitIcon           ( 00018654C680 ModelClassType FUnitIcon FUnitIcon FUnitIcon Pointer )
            value.InChallengeTourSelected                   = GetBool(new IntPtr(p + 0x048)); // 0270D64BE5D0 0x48 InChallengeTourSelected     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
