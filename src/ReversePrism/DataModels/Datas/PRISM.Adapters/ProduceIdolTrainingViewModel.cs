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
    // 028 CurrentRequiredPieceCount                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 030 OtherBonusModel                          0001866EE330 ModelClassType OtherBonusModel OtherBonusModel OtherBonusModel Pointer
    // 038 IdolSkillLvLimit                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 03C PotentialLiveSkillLimit                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 040 SelectedTrainingLv                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 044 CurrentLv                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 048 MaxLv                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 04C PieceProductKey                          0001865A2170 ModelEnumType ProductKey ProductKey ProductKey Int32
    // 058 PieceCount                               0001865F7700 ModelPrimitiveType long long long Int64
    // 060 MaxOtherBonusContentNum                  0001865F4260 ModelPrimitiveType int int int Int32
    // 068 <LvSelectorModelRP>k__BackingField       ReactiveProperty`1<LvSelectorViewModel> IL2CPP_TYPE_GENERICINST
    // 070 <PieceRequiredRP>k__BackingField         ReactiveProperty`1<ValueTuple`2<long, int>> IL2CPP_TYPE_GENERICINST
    // 078 <InsufficientPieceRP>k__BackingField     ReactiveProperty`1<bool> IL2CPP_TYPE_GENERICINST
    // 080 <BeforeParameterRP>k__BackingField       ReactiveProperty`1<IIdolParameterStatus> IL2CPP_TYPE_GENERICINST
    // 088 <AfterParameterRP>k__BackingField        ReactiveProperty`1<IIdolParameterStatus> IL2CPP_TYPE_GENERICINST
    // 090 <OnChangeOtherBonus>k__BackingField      Subject`1<OtherBonusViewModel> IL2CPP_TYPE_GENERICINST
    // 098 <ReachedMaxLv>k__BackingField            Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class ProduceIdolTrainingViewModel
    {
        public int                                      CurrentRequiredPieceCount               { get; set; }
        public OtherBonusModel?                         OtherBonusModel                         { get; set; }
        public int                                      IdolSkillLvLimit                        { get; set; }
        public int                                      PotentialLiveSkillLimit                 { get; set; }
        public int                                      SelectedTrainingLv                      { get; set; }
        public int                                      CurrentLv                               { get; set; }
        public int                                      MaxLv                                   { get; set; }
        public ProductKey                               PieceProductKey                         { get; set; }
        public long                                     PieceCount                              { get; set; }
        public int                                      MaxOtherBonusContentNum                 { get; set; }

        public static ProduceIdolTrainingViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceIdolTrainingViewModel();

            value.CurrentRequiredPieceCount                 = GetInt32(new IntPtr(p + 0x028)); // 0270D5FBCF40 0x28 CurrentRequiredPieceCount   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.OtherBonusModel                           = GetObject<OtherBonusModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.OtherBonusModel.FromPointer); // 0270D5FBCF60 0x30 OtherBonusModel             ( 0001866EE330 ModelClassType OtherBonusModel OtherBonusModel OtherBonusModel Pointer )
            value.IdolSkillLvLimit                          = GetInt32(new IntPtr(p + 0x038)); // 0270D5FBCF80 0x38 IdolSkillLvLimit            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.PotentialLiveSkillLimit                   = GetInt32(new IntPtr(p + 0x03C)); // 0270D5FBCFA0 0x3C PotentialLiveSkillLimit     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SelectedTrainingLv                        = GetInt32(new IntPtr(p + 0x040)); // 0270D5FBCFC0 0x40 SelectedTrainingLv          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CurrentLv                                 = GetInt32(new IntPtr(p + 0x044)); // 0270D5FBCFE0 0x44 CurrentLv                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MaxLv                                     = GetInt32(new IntPtr(p + 0x048)); // 0270D5FBD000 0x48 MaxLv                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.PieceProductKey                           = (ProductKey)GetInt32(new IntPtr(p + 0x04C)); // 0270D5FBD020 0x4C PieceProductKey             ( 0001865A2170 ModelEnumType ProductKey ProductKey ProductKey Int32 )
            value.PieceCount                                = GetInt64(new IntPtr(p + 0x058)); // 0270D5FBD040 0x58 PieceCount                  ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.MaxOtherBonusContentNum                   = GetInt32(new IntPtr(p + 0x060)); // 0270D5FBD060 0x60 MaxOtherBonusContentNum     ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
