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
    public partial class ProduceIdolModel
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
            var value   = new ProduceIdolModel();

            value.CharaId                                   = GetInt32(new IntPtr(p + 0x010)); // 027003B34B40 0x10 CharaId                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.BaseStatus                                = GetObject<IdolStatusData>(new IntPtr(p + 0x018), ReversePrism.DataModels.IdolStatusData.FromPointer); // 027003B34B60 0x18 BaseStatus                  ( 0001866C4130 ModelClassType IdolStatusData IdolStatusData IdolStatusData Pointer )
            value.CurrentStatus                             = GetObject<IdolStatusData>(new IntPtr(p + 0x020), ReversePrism.DataModels.IdolStatusData.FromPointer); // 027003B34B80 0x20 CurrentStatus               ( 0001866C4420 ModelClassType IdolStatusData IdolStatusData IdolStatusData Pointer )
            value.ActiveSkill                               = GetObject<IInProduceIdolSkillStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.IInProduceIdolSkillStatus.FromPointer); // 027003B34BA0 0x28 ActiveSkill                 ( 00018657CEF0 ModelClassType IInProduceIdolSkillStatus IInProduceIdolSkillStatus IInProduceIdolSkillStatus Pointer )
            value.BaseIdolVo                                = GetInt32(new IntPtr(p + 0x030)); // 027003B34BC0 0x30 BaseIdolVo                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.BaseIdolDa                                = GetInt32(new IntPtr(p + 0x034)); // 027003B34BE0 0x34 BaseIdolDa                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.BaseIdolVi                                = GetInt32(new IntPtr(p + 0x038)); // 027003B34C00 0x38 BaseIdolVi                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.BaseIdolMe                                = GetInt32(new IntPtr(p + 0x03C)); // 027003B34C20 0x3C BaseIdolMe                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.TrainingWearCostume                       = GetObject<MstCostumeSet>(new IntPtr(p + 0x040), ReversePrism.DataModels.MstCostumeSet.FromPointer); // 027003B34C40 0x40 TrainingWearCostume         ( 00018661D250 ModelClassType MstCostumeSet MstCostumeSet MstCostumeSet Pointer )
            value.StageCostume                              = GetObject<MstCostumeSet>(new IntPtr(p + 0x048), ReversePrism.DataModels.MstCostumeSet.FromPointer); // 027003B34C60 0x48 StageCostume                ( 00018661D4F0 ModelClassType MstCostumeSet MstCostumeSet MstCostumeSet Pointer )
            value.MiniCharaStage1                           = GetObject<MstCostumeSet>(new IntPtr(p + 0x050), ReversePrism.DataModels.MstCostumeSet.FromPointer); // 027003B34C80 0x50 MiniCharaStage1             ( 00018661D4F0 ModelClassType MstCostumeSet MstCostumeSet MstCostumeSet Pointer )
            value.MiniCharaStage2                           = GetObject<MstCostumeSet>(new IntPtr(p + 0x058), ReversePrism.DataModels.MstCostumeSet.FromPointer); // 027003B34CA0 0x58 MiniCharaStage2             ( 00018661D4F0 ModelClassType MstCostumeSet MstCostumeSet MstCostumeSet Pointer )
            value.RoomWearCostume                           = GetObject<MstCostumeSet>(new IntPtr(p + 0x060), ReversePrism.DataModels.MstCostumeSet.FromPointer); // 027003B34CC0 0x60 RoomWearCostume             ( 00018661D4F0 ModelClassType MstCostumeSet MstCostumeSet MstCostumeSet Pointer )
            value.MiniCharaTrainingWear                     = GetObject<MstCostumeSet>(new IntPtr(p + 0x068), ReversePrism.DataModels.MstCostumeSet.FromPointer); // 027003B34CE0 0x68 MiniCharaTrainingWear       ( 00018661D4F0 ModelClassType MstCostumeSet MstCostumeSet MstCostumeSet Pointer )
            value.SelectedMstSkillId                        = GetInt32(new IntPtr(p + 0x070)); // 027003B34D00 0x70 SelectedMstSkillId          ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.ProduceIdol                               = GetObject<ProduceIdol>(new IntPtr(p + 0x078), ReversePrism.DataModels.ProduceIdol.FromPointer); // 027003B34D20 0x78 ProduceIdol                 ( 000186546A30 ModelClassType ProduceIdol ProduceIdol ProduceIdol Pointer )

            return value;
        }
    }
}
