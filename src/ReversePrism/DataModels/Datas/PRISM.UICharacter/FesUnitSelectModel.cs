using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SourceIcons                              000185B7E800 ModelClassListType FUnitIcon[] FUnitIcon[] List<FUnitIcon> Pointer
    // 018 SelectedUnitId                           000185D0D798 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    // 020 SelectedHeaderUnit                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 SortFilterModel                          00018654DF70 ModelClassType FUnitSortFilterModel FUnitSortFilterModel FUnitSortFilterModel Pointer
    // 030 SaveData                                 0001866B23B0 ModelClassType IdolListFUSortFilterSaveData IdolListFUSortFilterSaveData IdolListFUSortFilterSaveData Pointer
    // 038 IsSelectedLimit                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 03C FooterType                               0001866B2B20 ModelEnumType IdolListFooterType IdolListFooterType IdolListFooterType Int32
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

            value.SourceIcons                               = GetObjectList<FUnitIcon>(new IntPtr(p + 0x010), ReversePrism.DataModels.FUnitIcon.FromPointer); // 024665AA3AC8 0x10 SourceIcons                 ( 000185B7E800 ModelClassListType FUnitIcon[] FUnitIcon[] List<FUnitIcon> Pointer )
            value.SelectedUnitId                            = GetStringList(new IntPtr(p + 0x018)); // 024665AA3AE8 0x18 SelectedUnitId              ( 000185D0D798 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )
            value.SelectedHeaderUnit                        = GetInt32(new IntPtr(p + 0x020)); // 024665AA3B08 0x20 SelectedHeaderUnit          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SortFilterModel                           = GetObject<FUnitSortFilterModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.FUnitSortFilterModel.FromPointer); // 024665AA3B28 0x28 SortFilterModel             ( 00018654DF70 ModelClassType FUnitSortFilterModel FUnitSortFilterModel FUnitSortFilterModel Pointer )
            value.SaveData                                  = GetObject<IdolListFUSortFilterSaveData>(new IntPtr(p + 0x030), ReversePrism.DataModels.IdolListFUSortFilterSaveData.FromPointer); // 024665AA3B48 0x30 SaveData                    ( 0001866B23B0 ModelClassType IdolListFUSortFilterSaveData IdolListFUSortFilterSaveData IdolListFUSortFilterSaveData Pointer )
            value.IsSelectedLimit                           = GetBool(new IntPtr(p + 0x038)); // 024665AA3B68 0x38 IsSelectedLimit             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.FooterType                                = (IdolListFooterType)GetInt32(new IntPtr(p + 0x03C)); // 024665AA3B88 0x3C FooterType                  ( 0001866B2B20 ModelEnumType IdolListFooterType IdolListFooterType IdolListFooterType Int32 )

            return value;
        }
    }
}
