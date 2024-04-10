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
    // 028 SortFilterModel                          00018654DA70 ModelClassType FUnitSortFilterModel FUnitSortFilterModel FUnitSortFilterModel Pointer
    // 030 listDataRP                               ReactiveProperty`1<ValueTuple`2<FUnitIcon[], bool>> IL2CPP_TYPE_GENERICINST
    // 038 onChangeSortFilterSettingsRP             ReactiveProperty`1<ValueTuple`2<bool, SortFilterSettings>> IL2CPP_TYPE_GENERICINST
    // 040 currentNumRP                             ReactiveProperty`1<ValueTuple`2<int, bool>> IL2CPP_TYPE_GENERICINST
    // 048 sortFilterSaveData                       SavableJsonObject`1<IdolListFUSortFilterPermanentData> IL2CPP_TYPE_GENERICINST
    // 050 IsSelectedLimit                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 054 FooterType                               0001866B2B20 ModelEnumType IdolListFooterType IdolListFooterType IdolListFooterType Int32
    // 058 displayIconData                          Dictionary`2<int, string> IL2CPP_TYPE_GENERICINST
    // 060 OnChangeSortFilterDisposable             000186753A40 ModelClassType IDisposable IDisposable IDisposable Pointer
    // 068 SelectedFavoriteMarkId                   0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class FesUnitSelectModel : DataModel
    {
        public List<FUnitIcon>?                         SourceIcons                             { get; set; }
        public List<string>?                            SelectedUnitId                          { get; set; }
        public int                                      SelectedHeaderUnit                      { get; set; }
        public FUnitSortFilterModel?                    SortFilterModel                         { get; set; }
        public bool                                     IsSelectedLimit                         { get; set; }
        public IdolListFooterType                       FooterType                              { get; set; }
        public IDisposable?                             OnChangeSortFilterDisposable            { get; set; }
        public int                                      SelectedFavoriteMarkId                  { get; set; }

        public static FesUnitSelectModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FesUnitSelectModel() { Pointer= p0 };

            value.SourceIcons                               = GetObjectList<FUnitIcon>(new IntPtr(p + 0x010), ReversePrism.DataModels.FUnitIcon.FromPointer); // 024665F67490 0x10 SourceIcons                 ( 000185B7E800 ModelClassListType FUnitIcon[] FUnitIcon[] List<FUnitIcon> Pointer )
            value.SelectedUnitId                            = GetStringList(new IntPtr(p + 0x018)); // 024665F674B0 0x18 SelectedUnitId              ( 000185D0D798 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )
            value.SelectedHeaderUnit                        = GetInt32(new IntPtr(p + 0x020)); // 024665F674D0 0x20 SelectedHeaderUnit          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SortFilterModel                           = GetObject<FUnitSortFilterModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.FUnitSortFilterModel.FromPointer); // 024665F674F0 0x28 SortFilterModel             ( 00018654DA70 ModelClassType FUnitSortFilterModel FUnitSortFilterModel FUnitSortFilterModel Pointer )
            value.IsSelectedLimit                           = GetBool(new IntPtr(p + 0x050)); // 024665F67590 0x50 IsSelectedLimit             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.FooterType                                = (IdolListFooterType)GetInt32(new IntPtr(p + 0x054)); // 024665F675B0 0x54 FooterType                  ( 0001866B2B20 ModelEnumType IdolListFooterType IdolListFooterType IdolListFooterType Int32 )
            value.OnChangeSortFilterDisposable              = GetObject<IDisposable>(new IntPtr(p + 0x060), ReversePrism.DataModels.IDisposable.FromPointer); // 024665F675F0 0x60 OnChangeSortFilterDisposable ( 000186753A40 ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.SelectedFavoriteMarkId                    = GetInt32(new IntPtr(p + 0x068)); // 024665F67610 0x68 SelectedFavoriteMarkId      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
