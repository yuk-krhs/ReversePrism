using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SelectedIcons                            000185CFE7A8 ModelEnumListType List`1<ProductKey> List`1<ProductKey> List<ProductKey> Pointer
    // 018 SelectedIconsNumRP                       000186714660 ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer
    // 020 PiPieceIcons                             000185CF93B8 ModelClassListType List`1<PieceIcon> List`1<PieceIcon> List<PieceIcon> Pointer
    // 028 PiSurplusPieceIcons                      000185CF9308 ModelClassListType List`1<PieceIcon> List`1<PieceIcon> List<PieceIcon> Pointer
    // 030 ScPieceIcons                             000185CF93B8 ModelClassListType List`1<PieceIcon> List`1<PieceIcon> List<PieceIcon> Pointer
    // 038 ScSurplusPieceIcons                      000185CF9308 ModelClassListType List`1<PieceIcon> List`1<PieceIcon> List<PieceIcon> Pointer
    // 040 pieceConversionItemNumRP                 ReactiveProperty`1<ValueTuple`2<long, bool>> IL2CPP_TYPE_GENERICINST
    // 048 TargetIcons                              000185CF9308 ModelClassListType List`1<PieceIcon> List`1<PieceIcon> List<PieceIcon> Pointer
    // 050 pPieceRequiredToMax                      Dictionary`2<int, int> IL2CPP_TYPE_GENERICINST
    // 058 sPieceRequiredToMax                      Dictionary`2<int, Dictionary`2<int, int>> IL2CPP_TYPE_GENERICINST
    // 060 pIdolTrainingLvDictionary                Dictionary`2<int, int> IL2CPP_TYPE_GENERICINST
    // 068 sCharaMasterTrainingLvDictionary         Dictionary`2<int, ValueTuple`2<int, int>> IL2CPP_TYPE_GENERICINST
    // 070 IsSurplus                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 074 CurrentTabType                           00018673E250 ModelEnumType PieceArchiveTabType PieceArchiveTabType PieceArchiveTabType Int32
    // 078 PieceConversionItemKey                   0001865A2170 ModelEnumType ProductKey ProductKey ProductKey Int32
    // 080 CurrentPieceConversionItemNum            0001865F7700 ModelPrimitiveType long long long Int64
    public partial class PieceArchiveViewModel : DataModel
    {
        public List<ProductKey>?                        SelectedIcons                           { get; set; }
        public IntReactiveProperty?                     SelectedIconsNumRP                      { get; set; }
        public List<PieceIcon>?                         PiPieceIcons                            { get; set; }
        public List<PieceIcon>?                         PiSurplusPieceIcons                     { get; set; }
        public List<PieceIcon>?                         ScPieceIcons                            { get; set; }
        public List<PieceIcon>?                         ScSurplusPieceIcons                     { get; set; }
        public List<PieceIcon>?                         TargetIcons                             { get; set; }
        public bool                                     IsSurplus                               { get; set; }
        public PieceArchiveTabType                      CurrentTabType                          { get; set; }
        public ProductKey                               PieceConversionItemKey                  { get; set; }
        public long                                     CurrentPieceConversionItemNum           { get; set; }

        public static PieceArchiveViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PieceArchiveViewModel() { Pointer= p0 };

            value.SelectedIcons                             = GetEnumList<ProductKey>(new IntPtr(p + 0x010)); // 024665F79BF0 0x10 SelectedIcons               ( 000185CFE7A8 ModelEnumListType List`1<ProductKey> List`1<ProductKey> List<ProductKey> Pointer )
            value.SelectedIconsNumRP                        = GetObject<IntReactiveProperty>(new IntPtr(p + 0x018), ReversePrism.DataModels.IntReactiveProperty.FromPointer); // 024665F79C10 0x18 SelectedIconsNumRP          ( 000186714660 ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer )
            value.PiPieceIcons                              = GetObjectList<PieceIcon>(new IntPtr(p + 0x020), ReversePrism.DataModels.PieceIcon.FromPointer); // 024665F79C30 0x20 PiPieceIcons                ( 000185CF93B8 ModelClassListType List`1<PieceIcon> List`1<PieceIcon> List<PieceIcon> Pointer )
            value.PiSurplusPieceIcons                       = GetObjectList<PieceIcon>(new IntPtr(p + 0x028), ReversePrism.DataModels.PieceIcon.FromPointer); // 024665F79C50 0x28 PiSurplusPieceIcons         ( 000185CF9308 ModelClassListType List`1<PieceIcon> List`1<PieceIcon> List<PieceIcon> Pointer )
            value.ScPieceIcons                              = GetObjectList<PieceIcon>(new IntPtr(p + 0x030), ReversePrism.DataModels.PieceIcon.FromPointer); // 024665F79C70 0x30 ScPieceIcons                ( 000185CF93B8 ModelClassListType List`1<PieceIcon> List`1<PieceIcon> List<PieceIcon> Pointer )
            value.ScSurplusPieceIcons                       = GetObjectList<PieceIcon>(new IntPtr(p + 0x038), ReversePrism.DataModels.PieceIcon.FromPointer); // 024665F79C90 0x38 ScSurplusPieceIcons         ( 000185CF9308 ModelClassListType List`1<PieceIcon> List`1<PieceIcon> List<PieceIcon> Pointer )
            value.TargetIcons                               = GetObjectList<PieceIcon>(new IntPtr(p + 0x048), ReversePrism.DataModels.PieceIcon.FromPointer); // 024665F79CD0 0x48 TargetIcons                 ( 000185CF9308 ModelClassListType List`1<PieceIcon> List`1<PieceIcon> List<PieceIcon> Pointer )
            value.IsSurplus                                 = GetBool(new IntPtr(p + 0x070)); // 024665F79D70 0x70 IsSurplus                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CurrentTabType                            = (PieceArchiveTabType)GetInt32(new IntPtr(p + 0x074)); // 024665F79D90 0x74 CurrentTabType              ( 00018673E250 ModelEnumType PieceArchiveTabType PieceArchiveTabType PieceArchiveTabType Int32 )
            value.PieceConversionItemKey                    = (ProductKey)GetInt32(new IntPtr(p + 0x078)); // 024665F79DB0 0x78 PieceConversionItemKey      ( 0001865A2170 ModelEnumType ProductKey ProductKey ProductKey Int32 )
            value.CurrentPieceConversionItemNum             = GetInt64(new IntPtr(p + 0x080)); // 024665F79DD0 0x80 CurrentPieceConversionItemNum ( 0001865F7700 ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
