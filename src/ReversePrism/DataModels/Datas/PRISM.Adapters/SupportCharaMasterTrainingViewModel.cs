using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SelectedDiamondLv                        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 pieceMaster                              Dictionary`2<int, int> IL2CPP_TYPE_GENERICINST
    // 020 RequiredPieceAmountRP                    000186714660 ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer
    // 028 PieceAmountRP                            0001865BF5C0 ModelClassType LongReactiveProperty LongReactiveProperty LongReactiveProperty Pointer
    // 030 PieceGaugeRP                             0001865A8B80 ModelClassType FloatReactiveProperty FloatReactiveProperty FloatReactiveProperty Pointer
    // 038 lvSelectorModels                         Dictionary`2<int, LvSelectorViewModel> IL2CPP_TYPE_GENERICINST
    // 040 IsLessThanRequiredRP                     000186769300 ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer
    // 048 SupportCharaId                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 04C CurrentLv                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 050 MaxLv                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 054 PieceProductKey                          0001865A2170 ModelEnumType ProductKey ProductKey ProductKey Int32
    // 060 LimitLvContents                          000185CF0018 ModelClassListType List`1<LimitLvContentViewModel> List`1<LimitLvContentViewModel> List<LimitLvContentViewModel> Pointer
    // 068 <ReachedMaxLv>k__BackingField            Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 070 <LvSelectorModelRP>k__BackingField       ReactiveProperty`1<LvSelectorViewModel> IL2CPP_TYPE_GENERICINST
    public partial class SupportCharaMasterTrainingViewModel : DataModel
    {
        public int                                      SelectedDiamondLv                       { get; set; }
        public IntReactiveProperty?                     RequiredPieceAmountRP                   { get; set; }
        public LongReactiveProperty?                    PieceAmountRP                           { get; set; }
        public FloatReactiveProperty?                   PieceGaugeRP                            { get; set; }
        public BoolReactiveProperty?                    IsLessThanRequiredRP                    { get; set; }
        public int                                      SupportCharaId                          { get; set; }
        public int                                      CurrentLv                               { get; set; }
        public int                                      MaxLv                                   { get; set; }
        public ProductKey                               PieceProductKey                         { get; set; }
        public List<LimitLvContentViewModel>?           LimitLvContents                         { get; set; }

        public static SupportCharaMasterTrainingViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportCharaMasterTrainingViewModel() { Pointer= p0 };

            value.SelectedDiamondLv                         = GetInt32(new IntPtr(p + 0x010)); // 0246660C8C18 0x10 SelectedDiamondLv           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.RequiredPieceAmountRP                     = GetObject<IntReactiveProperty>(new IntPtr(p + 0x020), ReversePrism.DataModels.IntReactiveProperty.FromPointer); // 0246660C8C58 0x20 RequiredPieceAmountRP       ( 000186714660 ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer )
            value.PieceAmountRP                             = GetObject<LongReactiveProperty>(new IntPtr(p + 0x028), ReversePrism.DataModels.LongReactiveProperty.FromPointer); // 0246660C8C78 0x28 PieceAmountRP               ( 0001865BF5C0 ModelClassType LongReactiveProperty LongReactiveProperty LongReactiveProperty Pointer )
            value.PieceGaugeRP                              = GetObject<FloatReactiveProperty>(new IntPtr(p + 0x030), ReversePrism.DataModels.FloatReactiveProperty.FromPointer); // 0246660C8C98 0x30 PieceGaugeRP                ( 0001865A8B80 ModelClassType FloatReactiveProperty FloatReactiveProperty FloatReactiveProperty Pointer )
            value.IsLessThanRequiredRP                      = GetObject<BoolReactiveProperty>(new IntPtr(p + 0x040), ReversePrism.DataModels.BoolReactiveProperty.FromPointer); // 0246660C8CD8 0x40 IsLessThanRequiredRP        ( 000186769300 ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer )
            value.SupportCharaId                            = GetInt32(new IntPtr(p + 0x048)); // 0246660C8CF8 0x48 SupportCharaId              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CurrentLv                                 = GetInt32(new IntPtr(p + 0x04C)); // 0246660C8D18 0x4C CurrentLv                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MaxLv                                     = GetInt32(new IntPtr(p + 0x050)); // 0246660C8D38 0x50 MaxLv                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.PieceProductKey                           = (ProductKey)GetInt32(new IntPtr(p + 0x054)); // 0246660C8D58 0x54 PieceProductKey             ( 0001865A2170 ModelEnumType ProductKey ProductKey ProductKey Int32 )
            value.LimitLvContents                           = GetObjectList<LimitLvContentViewModel>(new IntPtr(p + 0x060), ReversePrism.DataModels.LimitLvContentViewModel.FromPointer); // 0246660C8D78 0x60 LimitLvContents             ( 000185CF0018 ModelClassListType List`1<LimitLvContentViewModel> List`1<LimitLvContentViewModel> List<LimitLvContentViewModel> Pointer )

            return value;
        }
    }
}
