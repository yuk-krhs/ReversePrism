using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SourceIcons                              ModelClassListType FUnitIcon[] FUnitIcon[] List<FUnitIcon> Pointer
    // 018 SelectedUnitId                           ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    // 020 SelectedHeaderUnit                       ModelPrimitiveType int int int Int32
    // 028 SortFilterModel                          ModelClassType FUnitSortFilterModel FUnitSortFilterModel FUnitSortFilterModel Pointer
    // 030 SaveData                                 ModelClassType IdolListFUSortFilterSaveData IdolListFUSortFilterSaveData IdolListFUSortFilterSaveData Pointer
    // 038 IsSelectedLimit                          ModelPrimitiveType bool bool bool Bool
    // 03C FooterType                               ModelEnumType IdolListFooterType IdolListFooterType IdolListFooterType Int32
    // 040 displayIconData                          Dictionary`2<int, string> IL2CPP_TYPE_GENERICINST
    // 048 CurrentNumRP                             ReactiveProperty`1<ValueTuple`2<int, bool>> IL2CPP_TYPE_GENERICINST
    public partial class FesUnitSelectModel : DataModel
    {
        public List<FUnitIcon>?                         SourceIcons                             { get; set; }
        public List<string>?                            SelectedUnitId                          { get; set; }
        public int                                      SelectedHeaderUnit                      { get; set; }
        public FUnitSortFilterModel?                    SortFilterModel                         { get; set; }
        public IdolListFUSortFilterSaveData?            SaveData                                { get; set; }
        public bool                                     IsSelectedLimit                         { get; set; }
        public IdolListFooterType                       FooterType                              { get; set; }

        public static FesUnitSelectModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FesUnitSelectModel() { Pointer= p0 };

            value.SourceIcons                               = GetObjectList<FUnitIcon>(new IntPtr(p + 0x010), ReversePrism.DataModels.FUnitIcon.FromPointer); // 0x10 SourceIcons                 ( ModelClassListType FUnitIcon[] FUnitIcon[] List<FUnitIcon> Pointer )
            value.SelectedUnitId                            = GetStringList(new IntPtr(p + 0x018)); // 0x18 SelectedUnitId              ( ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )
            value.SelectedHeaderUnit                        = GetInt32(new IntPtr(p + 0x020)); // 0x20 SelectedHeaderUnit          ( ModelPrimitiveType int int int Int32 )
            value.SortFilterModel                           = GetObject<FUnitSortFilterModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.FUnitSortFilterModel.FromPointer); // 0x28 SortFilterModel             ( ModelClassType FUnitSortFilterModel FUnitSortFilterModel FUnitSortFilterModel Pointer )
            value.SaveData                                  = GetObject<IdolListFUSortFilterSaveData>(new IntPtr(p + 0x030), ReversePrism.DataModels.IdolListFUSortFilterSaveData.FromPointer); // 0x30 SaveData                    ( ModelClassType IdolListFUSortFilterSaveData IdolListFUSortFilterSaveData IdolListFUSortFilterSaveData Pointer )
            value.IsSelectedLimit                           = GetBool(new IntPtr(p + 0x038)); // 0x38 IsSelectedLimit             ( ModelPrimitiveType bool bool bool Bool )
            value.FooterType                                = (IdolListFooterType)GetInt32(new IntPtr(p + 0x03C)); // 0x3C FooterType                  ( ModelEnumType IdolListFooterType IdolListFooterType IdolListFooterType Int32 )

            return value;
        }
    }
}
