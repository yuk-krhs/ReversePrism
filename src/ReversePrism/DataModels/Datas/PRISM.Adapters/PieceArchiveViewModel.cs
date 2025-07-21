using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SelectedIcons                            ModelEnumListType List`1<ProductKey> List`1<ProductKey> List<ProductKey> Pointer
    // 018 SelectedIconsNumRP                       ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer
    // 020 PiPieceIcons                             ModelClassListType List`1<PieceIcon> List`1<PieceIcon> List<PieceIcon> Pointer
    // 028 PiSurplusPieceIcons                      ModelClassListType List`1<PieceIcon> List`1<PieceIcon> List<PieceIcon> Pointer
    // 030 ScPieceIcons                             ModelClassListType List`1<PieceIcon> List`1<PieceIcon> List<PieceIcon> Pointer
    // 038 ScSurplusPieceIcons                      ModelClassListType List`1<PieceIcon> List`1<PieceIcon> List<PieceIcon> Pointer
    // 040 pieceConversionItemNumRP                 ReactiveProperty`1<ValueTuple`2<long, bool>> IL2CPP_TYPE_GENERICINST
    // 048 TargetIcons                              ModelClassListType List`1<PieceIcon> List`1<PieceIcon> List<PieceIcon> Pointer
    // 050 pPieceRequiredToMax                      Dictionary`2<int, int> IL2CPP_TYPE_GENERICINST
    // 058 sPieceRequiredToMax                      Dictionary`2<int, Dictionary`2<int, int>> IL2CPP_TYPE_GENERICINST
    // 060 pIdolTrainingLvDictionary                Dictionary`2<int, int> IL2CPP_TYPE_GENERICINST
    // 068 sCharaMasterTrainingLvDictionary         Dictionary`2<int, ValueTuple`2<int, int>> IL2CPP_TYPE_GENERICINST
    // 070 IsSurplus                                ModelPrimitiveType bool bool bool Bool
    // 074 CurrentTabType                           ModelEnumType PieceArchiveTabType PieceArchiveTabType PieceArchiveTabType Int32
    // 078 PieceConversionItemKey                   ModelEnumType ProductKey ProductKey ProductKey Int32
    // 080 CurrentPieceConversionItemNum            ModelPrimitiveType long long long Int64
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

            value.SelectedIcons                             = GetEnumList<ProductKey>(new IntPtr(p + 0x010)); // 0x10 SelectedIcons               ( ModelEnumListType List`1<ProductKey> List`1<ProductKey> List<ProductKey> Pointer )
            value.SelectedIconsNumRP                        = GetObject<IntReactiveProperty>(new IntPtr(p + 0x018), ReversePrism.DataModels.IntReactiveProperty.FromPointer); // 0x18 SelectedIconsNumRP          ( ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer )
            value.PiPieceIcons                              = GetObjectList<PieceIcon>(new IntPtr(p + 0x020), ReversePrism.DataModels.PieceIcon.FromPointer); // 0x20 PiPieceIcons                ( ModelClassListType List`1<PieceIcon> List`1<PieceIcon> List<PieceIcon> Pointer )
            value.PiSurplusPieceIcons                       = GetObjectList<PieceIcon>(new IntPtr(p + 0x028), ReversePrism.DataModels.PieceIcon.FromPointer); // 0x28 PiSurplusPieceIcons         ( ModelClassListType List`1<PieceIcon> List`1<PieceIcon> List<PieceIcon> Pointer )
            value.ScPieceIcons                              = GetObjectList<PieceIcon>(new IntPtr(p + 0x030), ReversePrism.DataModels.PieceIcon.FromPointer); // 0x30 ScPieceIcons                ( ModelClassListType List`1<PieceIcon> List`1<PieceIcon> List<PieceIcon> Pointer )
            value.ScSurplusPieceIcons                       = GetObjectList<PieceIcon>(new IntPtr(p + 0x038), ReversePrism.DataModels.PieceIcon.FromPointer); // 0x38 ScSurplusPieceIcons         ( ModelClassListType List`1<PieceIcon> List`1<PieceIcon> List<PieceIcon> Pointer )
            value.TargetIcons                               = GetObjectList<PieceIcon>(new IntPtr(p + 0x048), ReversePrism.DataModels.PieceIcon.FromPointer); // 0x48 TargetIcons                 ( ModelClassListType List`1<PieceIcon> List`1<PieceIcon> List<PieceIcon> Pointer )
            value.IsSurplus                                 = GetBool(new IntPtr(p + 0x070)); // 0x70 IsSurplus                   ( ModelPrimitiveType bool bool bool Bool )
            value.CurrentTabType                            = (PieceArchiveTabType)GetInt32(new IntPtr(p + 0x074)); // 0x74 CurrentTabType              ( ModelEnumType PieceArchiveTabType PieceArchiveTabType PieceArchiveTabType Int32 )
            value.PieceConversionItemKey                    = (ProductKey)GetInt32(new IntPtr(p + 0x078)); // 0x78 PieceConversionItemKey      ( ModelEnumType ProductKey ProductKey ProductKey Int32 )
            value.CurrentPieceConversionItemNum             = GetInt64(new IntPtr(p + 0x080)); // 0x80 CurrentPieceConversionItemNum ( ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
