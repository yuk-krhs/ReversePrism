using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DecideReactiveProperty                   ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer
    // 018 sortFilterSaveData                       SavableJsonObject`1<IdolListFUSortFilterPermanentData> IL2CPP_TYPE_GENERICINST
    // 020 FUnitIcons                               ModelClassListType FUnitIcon[] FUnitIcon[] List<FUnitIcon> Pointer
    // 028 DisplayFUnitIcons                        ModelClassListType FUnitIcon[] FUnitIcon[] List<FUnitIcon> Pointer
    // 030 SortFilterModel                          ModelClassType FUnitSortFilterModel FUnitSortFilterModel FUnitSortFilterModel Pointer
    // 038 ChallengeTourViewModel                   ModelClassType ChallengeTourUnitViewModel ChallengeTourUnitViewModel ChallengeTourUnitViewModel Pointer
    // 040 SelectedFUnitIcon                        ModelClassType FUnitIcon FUnitIcon FUnitIcon Pointer
    // 048 InChallengeTourSelected                  ModelPrimitiveType bool bool bool Bool
    public partial class ChallengeTourUnitEditViewModel : DataModel
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
            var value   = new ChallengeTourUnitEditViewModel() { Pointer= p0 };

            value.DecideReactiveProperty                    = GetObject<BoolReactiveProperty>(new IntPtr(p + 0x010), ReversePrism.DataModels.BoolReactiveProperty.FromPointer); // 0x10 DecideReactiveProperty      ( ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer )
            value.FUnitIcons                                = GetObjectList<FUnitIcon>(new IntPtr(p + 0x020), ReversePrism.DataModels.FUnitIcon.FromPointer); // 0x20 FUnitIcons                  ( ModelClassListType FUnitIcon[] FUnitIcon[] List<FUnitIcon> Pointer )
            value.DisplayFUnitIcons                         = GetObjectList<FUnitIcon>(new IntPtr(p + 0x028), ReversePrism.DataModels.FUnitIcon.FromPointer); // 0x28 DisplayFUnitIcons           ( ModelClassListType FUnitIcon[] FUnitIcon[] List<FUnitIcon> Pointer )
            value.SortFilterModel                           = GetObject<FUnitSortFilterModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.FUnitSortFilterModel.FromPointer); // 0x30 SortFilterModel             ( ModelClassType FUnitSortFilterModel FUnitSortFilterModel FUnitSortFilterModel Pointer )
            value.ChallengeTourViewModel                    = GetObject<ChallengeTourUnitViewModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.ChallengeTourUnitViewModel.FromPointer); // 0x38 ChallengeTourViewModel      ( ModelClassType ChallengeTourUnitViewModel ChallengeTourUnitViewModel ChallengeTourUnitViewModel Pointer )
            value.SelectedFUnitIcon                         = GetObject<FUnitIcon>(new IntPtr(p + 0x040), ReversePrism.DataModels.FUnitIcon.FromPointer); // 0x40 SelectedFUnitIcon           ( ModelClassType FUnitIcon FUnitIcon FUnitIcon Pointer )
            value.InChallengeTourSelected                   = GetBool(new IntPtr(p + 0x048)); // 0x48 InChallengeTourSelected     ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
