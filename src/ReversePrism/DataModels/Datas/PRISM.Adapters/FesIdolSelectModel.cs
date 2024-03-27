using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     0001865A7320 ModelEnumType CharacterType CharacterType CharacterType Int32
    // 018 SourceIcons                              000185B7E340 ModelClassListType FIdolIcon[] FIdolIcon[] List<FIdolIcon> Pointer
    // 020 SelectedIdolId                           000185D0D798 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    // 028 SortFilterModel                          000186545E80 ModelClassType FIdolIconSortFilterModel FIdolIconSortFilterModel FIdolIconSortFilterModel Pointer
    // 030 listDataRP                               ReactiveProperty`1<ValueTuple`2<FIdolIcon[], bool>> IL2CPP_TYPE_GENERICINST
    // 038 onChangeSortFilterSettingsRP             ReactiveProperty`1<ValueTuple`2<bool, SortFilterSettings>> IL2CPP_TYPE_GENERICINST
    // 040 currentNumRP                             ReactiveProperty`1<ValueTuple`2<int, bool>> IL2CPP_TYPE_GENERICINST
    // 048 sortFilterSaveData                       SavableJsonObject`1<IdolListFISortFilterPermanentData> IL2CPP_TYPE_GENERICINST
    // 050 IsSelectedLimit                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 054 FooterType                               0001866B2B20 ModelEnumType IdolListFooterType IdolListFooterType IdolListFooterType Int32
    // 058 displayIconData                          Dictionary`2<int, string> IL2CPP_TYPE_GENERICINST
    // 060 OnChangeSortFilterDisposable             000186753A40 ModelClassType IDisposable IDisposable IDisposable Pointer
    // 068 SelectedFavoriteMarkId                   0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class FesIdolSelectModel
    {
        public CharacterType                            Type                                    { get; set; }
        public List<FIdolIcon>?                         SourceIcons                             { get; set; }
        public List<string>?                            SelectedIdolId                          { get; set; }
        public FIdolIconSortFilterModel?                SortFilterModel                         { get; set; }
        public bool                                     IsSelectedLimit                         { get; set; }
        public IdolListFooterType                       FooterType                              { get; set; }
        public IDisposable?                             OnChangeSortFilterDisposable            { get; set; }
        public int                                      SelectedFavoriteMarkId                  { get; set; }

        public static FesIdolSelectModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FesIdolSelectModel();

            value.Type                                      = (CharacterType)GetInt32(new IntPtr(p + 0x010)); // 0270D5F081B0 0x10 Type                        ( 0001865A7320 ModelEnumType CharacterType CharacterType CharacterType Int32 )
            value.SourceIcons                               = GetObjectList<FIdolIcon>(new IntPtr(p + 0x018), ReversePrism.DataModels.FIdolIcon.FromPointer); // 0270D5F081D0 0x18 SourceIcons                 ( 000185B7E340 ModelClassListType FIdolIcon[] FIdolIcon[] List<FIdolIcon> Pointer )
            value.SelectedIdolId                            = GetStringList(new IntPtr(p + 0x020)); // 0270D5F081F0 0x20 SelectedIdolId              ( 000185D0D798 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )
            value.SortFilterModel                           = GetObject<FIdolIconSortFilterModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.FIdolIconSortFilterModel.FromPointer); // 0270D5F08210 0x28 SortFilterModel             ( 000186545E80 ModelClassType FIdolIconSortFilterModel FIdolIconSortFilterModel FIdolIconSortFilterModel Pointer )
            value.IsSelectedLimit                           = GetBool(new IntPtr(p + 0x050)); // 0270D5F082B0 0x50 IsSelectedLimit             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.FooterType                                = (IdolListFooterType)GetInt32(new IntPtr(p + 0x054)); // 0270D5F082D0 0x54 FooterType                  ( 0001866B2B20 ModelEnumType IdolListFooterType IdolListFooterType IdolListFooterType Int32 )
            value.OnChangeSortFilterDisposable              = GetObject<IDisposable>(new IntPtr(p + 0x060), ReversePrism.DataModels.IDisposable.FromPointer); // 0270D5F08310 0x60 OnChangeSortFilterDisposable ( 000186753A40 ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.SelectedFavoriteMarkId                    = GetInt32(new IntPtr(p + 0x068)); // 0270D5F08330 0x68 SelectedFavoriteMarkId      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
