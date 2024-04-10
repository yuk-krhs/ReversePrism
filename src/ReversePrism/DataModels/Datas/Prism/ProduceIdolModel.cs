using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CharaId                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 BaseStatus                               0001866C4130 ModelClassType IdolStatusData IdolStatusData IdolStatusData Pointer
    // 020 CurrentStatus                            0001866C4420 ModelClassType IdolStatusData IdolStatusData IdolStatusData Pointer
    // 028 ActiveSkill                              00018657CEF0 ModelClassType IInProduceIdolSkillStatus IInProduceIdolSkillStatus IInProduceIdolSkillStatus Pointer
    // 030 BaseIdolVo                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 034 BaseIdolDa                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 038 BaseIdolVi                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 03C BaseIdolMe                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 040 TrainingWearCostume                      00018661D250 ModelClassType MstCostumeSet MstCostumeSet MstCostumeSet Pointer
    // 048 StageCostume                             00018661D4F0 ModelClassType MstCostumeSet MstCostumeSet MstCostumeSet Pointer
    // 050 MiniCharaStage1                          00018661D4F0 ModelClassType MstCostumeSet MstCostumeSet MstCostumeSet Pointer
    // 058 MiniCharaStage2                          00018661D4F0 ModelClassType MstCostumeSet MstCostumeSet MstCostumeSet Pointer
    // 060 RoomWearCostume                          00018661D4F0 ModelClassType MstCostumeSet MstCostumeSet MstCostumeSet Pointer
    // 068 MiniCharaTrainingWear                    00018661D4F0 ModelClassType MstCostumeSet MstCostumeSet MstCostumeSet Pointer
    // 070 SelectedMstSkillId                       0001865F36C0 ModelPrimitiveType int int int Int32
    // 078 ProduceIdol                              000186546A30 ModelClassType ProduceIdol ProduceIdol ProduceIdol Pointer
    public partial class ProduceIdolModel : DataModel
    {
        public int                                      CharaId                                 { get; set; }
        public IdolStatusData?                          BaseStatus                              { get; set; }
        public IdolStatusData?                          CurrentStatus                           { get; set; }
        public IInProduceIdolSkillStatus?               ActiveSkill                             { get; set; }
        public int                                      BaseIdolVo                              { get; set; }
        public int                                      BaseIdolDa                              { get; set; }
        public int                                      BaseIdolVi                              { get; set; }
        public int                                      BaseIdolMe                              { get; set; }
        public MstCostumeSet?                           TrainingWearCostume                     { get; set; }
        public MstCostumeSet?                           StageCostume                            { get; set; }
        public MstCostumeSet?                           MiniCharaStage1                         { get; set; }
        public MstCostumeSet?                           MiniCharaStage2                         { get; set; }
        public MstCostumeSet?                           RoomWearCostume                         { get; set; }
        public MstCostumeSet?                           MiniCharaTrainingWear                   { get; set; }
        public int                                      SelectedMstSkillId                      { get; set; }
        public ProduceIdol?                             ProduceIdol                             { get; set; }

        public static ProduceIdolModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceIdolModel() { Pointer= p0 };

            value.CharaId                                   = GetInt32(new IntPtr(p + 0x010)); // 0245A3B1F9C8 0x10 CharaId                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.BaseStatus                                = GetObject<IdolStatusData>(new IntPtr(p + 0x018), ReversePrism.DataModels.IdolStatusData.FromPointer); // 0245A3B1F9E8 0x18 BaseStatus                  ( 0001866C4130 ModelClassType IdolStatusData IdolStatusData IdolStatusData Pointer )
            value.CurrentStatus                             = GetObject<IdolStatusData>(new IntPtr(p + 0x020), ReversePrism.DataModels.IdolStatusData.FromPointer); // 0245A3B1FA08 0x20 CurrentStatus               ( 0001866C4420 ModelClassType IdolStatusData IdolStatusData IdolStatusData Pointer )
            value.ActiveSkill                               = GetObject<IInProduceIdolSkillStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.IInProduceIdolSkillStatus.FromPointer); // 0245A3B1FA28 0x28 ActiveSkill                 ( 00018657CEF0 ModelClassType IInProduceIdolSkillStatus IInProduceIdolSkillStatus IInProduceIdolSkillStatus Pointer )
            value.BaseIdolVo                                = GetInt32(new IntPtr(p + 0x030)); // 0245A3B1FA48 0x30 BaseIdolVo                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.BaseIdolDa                                = GetInt32(new IntPtr(p + 0x034)); // 0245A3B1FA68 0x34 BaseIdolDa                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.BaseIdolVi                                = GetInt32(new IntPtr(p + 0x038)); // 0245A3B1FA88 0x38 BaseIdolVi                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.BaseIdolMe                                = GetInt32(new IntPtr(p + 0x03C)); // 0245A3B1FAA8 0x3C BaseIdolMe                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.TrainingWearCostume                       = GetObject<MstCostumeSet>(new IntPtr(p + 0x040), ReversePrism.DataModels.MstCostumeSet.FromPointer); // 0245A3B1FAC8 0x40 TrainingWearCostume         ( 00018661D250 ModelClassType MstCostumeSet MstCostumeSet MstCostumeSet Pointer )
            value.StageCostume                              = GetObject<MstCostumeSet>(new IntPtr(p + 0x048), ReversePrism.DataModels.MstCostumeSet.FromPointer); // 0245A3B1FAE8 0x48 StageCostume                ( 00018661D4F0 ModelClassType MstCostumeSet MstCostumeSet MstCostumeSet Pointer )
            value.MiniCharaStage1                           = GetObject<MstCostumeSet>(new IntPtr(p + 0x050), ReversePrism.DataModels.MstCostumeSet.FromPointer); // 0245A3B1FB08 0x50 MiniCharaStage1             ( 00018661D4F0 ModelClassType MstCostumeSet MstCostumeSet MstCostumeSet Pointer )
            value.MiniCharaStage2                           = GetObject<MstCostumeSet>(new IntPtr(p + 0x058), ReversePrism.DataModels.MstCostumeSet.FromPointer); // 0245A3B1FB28 0x58 MiniCharaStage2             ( 00018661D4F0 ModelClassType MstCostumeSet MstCostumeSet MstCostumeSet Pointer )
            value.RoomWearCostume                           = GetObject<MstCostumeSet>(new IntPtr(p + 0x060), ReversePrism.DataModels.MstCostumeSet.FromPointer); // 0245A3B1FB48 0x60 RoomWearCostume             ( 00018661D4F0 ModelClassType MstCostumeSet MstCostumeSet MstCostumeSet Pointer )
            value.MiniCharaTrainingWear                     = GetObject<MstCostumeSet>(new IntPtr(p + 0x068), ReversePrism.DataModels.MstCostumeSet.FromPointer); // 0245A3B1FB68 0x68 MiniCharaTrainingWear       ( 00018661D4F0 ModelClassType MstCostumeSet MstCostumeSet MstCostumeSet Pointer )
            value.SelectedMstSkillId                        = GetInt32(new IntPtr(p + 0x070)); // 0245A3B1FB88 0x70 SelectedMstSkillId          ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.ProduceIdol                               = GetObject<ProduceIdol>(new IntPtr(p + 0x078), ReversePrism.DataModels.ProduceIdol.FromPointer); // 0245A3B1FBA8 0x78 ProduceIdol                 ( 000186546A30 ModelClassType ProduceIdol ProduceIdol ProduceIdol Pointer )

            return value;
        }
    }
}
