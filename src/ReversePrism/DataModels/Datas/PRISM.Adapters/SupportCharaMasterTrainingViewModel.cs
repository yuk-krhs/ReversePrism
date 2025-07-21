using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SelectedDiamondLv                        ModelPrimitiveType int int int Int32
    // 018 pieceMaster                              Dictionary`2<int, int> IL2CPP_TYPE_GENERICINST
    // 020 RequiredPieceAmountRP                    ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer
    // 028 PieceAmountRP                            ModelClassType LongReactiveProperty LongReactiveProperty LongReactiveProperty Pointer
    // 030 PieceGaugeRP                             ModelClassType FloatReactiveProperty FloatReactiveProperty FloatReactiveProperty Pointer
    // 038 lvSelectorModels                         Dictionary`2<int, LvSelectorViewModel> IL2CPP_TYPE_GENERICINST
    // 040 IsLessThanRequiredRP                     ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer
    // 048 SupportCharaId                           ModelPrimitiveType int int int Int32
    // 04C CurrentLv                                ModelPrimitiveType int int int Int32
    // 050 MaxLv                                    ModelPrimitiveType int int int Int32
    // 054 PieceProductKey                          ModelEnumType ProductKey ProductKey ProductKey Int32
    // 060 LimitLvContents                          ModelClassListType List`1<LimitLvContentViewModel> List`1<LimitLvContentViewModel> List<LimitLvContentViewModel> Pointer
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

            value.SelectedDiamondLv                         = GetInt32(new IntPtr(p + 0x010)); // 0x10 SelectedDiamondLv           ( ModelPrimitiveType int int int Int32 )
            value.RequiredPieceAmountRP                     = GetObject<IntReactiveProperty>(new IntPtr(p + 0x020), ReversePrism.DataModels.IntReactiveProperty.FromPointer); // 0x20 RequiredPieceAmountRP       ( ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer )
            value.PieceAmountRP                             = GetObject<LongReactiveProperty>(new IntPtr(p + 0x028), ReversePrism.DataModels.LongReactiveProperty.FromPointer); // 0x28 PieceAmountRP               ( ModelClassType LongReactiveProperty LongReactiveProperty LongReactiveProperty Pointer )
            value.PieceGaugeRP                              = GetObject<FloatReactiveProperty>(new IntPtr(p + 0x030), ReversePrism.DataModels.FloatReactiveProperty.FromPointer); // 0x30 PieceGaugeRP                ( ModelClassType FloatReactiveProperty FloatReactiveProperty FloatReactiveProperty Pointer )
            value.IsLessThanRequiredRP                      = GetObject<BoolReactiveProperty>(new IntPtr(p + 0x040), ReversePrism.DataModels.BoolReactiveProperty.FromPointer); // 0x40 IsLessThanRequiredRP        ( ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer )
            value.SupportCharaId                            = GetInt32(new IntPtr(p + 0x048)); // 0x48 SupportCharaId              ( ModelPrimitiveType int int int Int32 )
            value.CurrentLv                                 = GetInt32(new IntPtr(p + 0x04C)); // 0x4C CurrentLv                   ( ModelPrimitiveType int int int Int32 )
            value.MaxLv                                     = GetInt32(new IntPtr(p + 0x050)); // 0x50 MaxLv                       ( ModelPrimitiveType int int int Int32 )
            value.PieceProductKey                           = (ProductKey)GetInt32(new IntPtr(p + 0x054)); // 0x54 PieceProductKey             ( ModelEnumType ProductKey ProductKey ProductKey Int32 )
            value.LimitLvContents                           = GetObjectList<LimitLvContentViewModel>(new IntPtr(p + 0x060), ReversePrism.DataModels.LimitLvContentViewModel.FromPointer); // 0x60 LimitLvContents             ( ModelClassListType List`1<LimitLvContentViewModel> List`1<LimitLvContentViewModel> List<LimitLvContentViewModel> Pointer )

            return value;
        }
    }
}
