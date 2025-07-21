using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 lvSelectorModels                         Dictionary`2<int, LvSelectorViewModel> IL2CPP_TYPE_GENERICINST
    // 018 statusBonus                              Dictionary`2<int, IIdolParameterStatus> IL2CPP_TYPE_GENERICINST
    // 020 mstBreakRecipeNums                       Dictionary`2<int, int> IL2CPP_TYPE_GENERICINST
    // 028 CurrentRequiredPieceCount                ModelPrimitiveType int int int Int32
    // 030 OtherBonusViewModel                      ModelClassType OtherBonusViewModel OtherBonusViewModel OtherBonusViewModel Pointer
    // 038 SelectedTrainingLv                       ModelPrimitiveType int int int Int32
    // 03C CurrentLv                                ModelPrimitiveType int int int Int32
    // 040 MaxLv                                    ModelPrimitiveType int int int Int32
    // 044 PieceProductKey                          ModelEnumType ProductKey ProductKey ProductKey Int32
    // 050 PieceCount                               ModelPrimitiveType long long long Int64
    // 058 LiveOnly                                 ModelPrimitiveType bool bool bool Bool
    // 060 <LvSelectorModelRP>k__BackingField       ReactiveProperty`1<LvSelectorViewModel> IL2CPP_TYPE_GENERICINST
    // 068 <PieceRequiredRP>k__BackingField         ReactiveProperty`1<ValueTuple`2<long, int>> IL2CPP_TYPE_GENERICINST
    // 070 <InsufficientPieceRP>k__BackingField     ReactiveProperty`1<bool> IL2CPP_TYPE_GENERICINST
    // 078 <BeforeParameterRP>k__BackingField       ReactiveProperty`1<IIdolParameterStatus> IL2CPP_TYPE_GENERICINST
    // 080 <AfterParameterRP>k__BackingField        ReactiveProperty`1<IIdolParameterStatus> IL2CPP_TYPE_GENERICINST
    // 088 <ReachedMaxLv>k__BackingField            Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class ProduceIdolTrainingViewModel : DataModel
    {
        public int                                      CurrentRequiredPieceCount               { get; set; }
        public OtherBonusViewModel?                     OtherBonusViewModel                     { get; set; }
        public int                                      SelectedTrainingLv                      { get; set; }
        public int                                      CurrentLv                               { get; set; }
        public int                                      MaxLv                                   { get; set; }
        public ProductKey                               PieceProductKey                         { get; set; }
        public long                                     PieceCount                              { get; set; }
        public bool                                     LiveOnly                                { get; set; }

        public static ProduceIdolTrainingViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceIdolTrainingViewModel() { Pointer= p0 };

            value.CurrentRequiredPieceCount                 = GetInt32(new IntPtr(p + 0x028)); // 0x28 CurrentRequiredPieceCount   ( ModelPrimitiveType int int int Int32 )
            value.OtherBonusViewModel                       = GetObject<OtherBonusViewModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.OtherBonusViewModel.FromPointer); // 0x30 OtherBonusViewModel         ( ModelClassType OtherBonusViewModel OtherBonusViewModel OtherBonusViewModel Pointer )
            value.SelectedTrainingLv                        = GetInt32(new IntPtr(p + 0x038)); // 0x38 SelectedTrainingLv          ( ModelPrimitiveType int int int Int32 )
            value.CurrentLv                                 = GetInt32(new IntPtr(p + 0x03C)); // 0x3C CurrentLv                   ( ModelPrimitiveType int int int Int32 )
            value.MaxLv                                     = GetInt32(new IntPtr(p + 0x040)); // 0x40 MaxLv                       ( ModelPrimitiveType int int int Int32 )
            value.PieceProductKey                           = (ProductKey)GetInt32(new IntPtr(p + 0x044)); // 0x44 PieceProductKey             ( ModelEnumType ProductKey ProductKey ProductKey Int32 )
            value.PieceCount                                = GetInt64(new IntPtr(p + 0x050)); // 0x50 PieceCount                  ( ModelPrimitiveType long long long Int64 )
            value.LiveOnly                                  = GetBool(new IntPtr(p + 0x058)); // 0x58 LiveOnly                    ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
