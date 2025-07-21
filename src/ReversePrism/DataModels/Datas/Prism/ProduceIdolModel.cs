using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CharaId                                  ModelPrimitiveType int int int Int32
    // 018 BaseStatus                               ModelClassType IdolStatusData IdolStatusData IdolStatusData Pointer
    // 020 CurrentStatus                            ModelClassType IdolStatusData IdolStatusData IdolStatusData Pointer
    // 028 ActiveSkill                              ModelClassType IInProduceIdolSkillStatus IInProduceIdolSkillStatus IInProduceIdolSkillStatus Pointer
    // 030 BaseIdolVo                               ModelPrimitiveType int int int Int32
    // 034 BaseIdolDa                               ModelPrimitiveType int int int Int32
    // 038 BaseIdolVi                               ModelPrimitiveType int int int Int32
    // 03C BaseIdolMe                               ModelPrimitiveType int int int Int32
    // 040 TrainingWearCostume                      ModelClassType UnitIdol UnitIdol UnitIdol Pointer
    // 048 StageCostume                             ModelClassType UnitIdol UnitIdol UnitIdol Pointer
    // 050 MiniCharaStage1                          ModelClassType UnitIdol UnitIdol UnitIdol Pointer
    // 058 MiniCharaStage2                          ModelClassType UnitIdol UnitIdol UnitIdol Pointer
    // 060 DefaultRoomWearCostume                   ModelClassType UnitIdol UnitIdol UnitIdol Pointer
    // 068 CustomRoomWearCostume                    ModelClassType UnitIdol UnitIdol UnitIdol Pointer
    // 070 MiniCharaTrainingWear                    ModelClassType UnitIdol UnitIdol UnitIdol Pointer
    // 078 SelectedMstSkillId                       ModelPrimitiveType int int int Int32
    // 080 ProduceIdol                              ModelClassType ProduceIdol ProduceIdol ProduceIdol Pointer
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
        public UnitIdol?                                TrainingWearCostume                     { get; set; }
        public UnitIdol?                                StageCostume                            { get; set; }
        public UnitIdol?                                MiniCharaStage1                         { get; set; }
        public UnitIdol?                                MiniCharaStage2                         { get; set; }
        public UnitIdol?                                DefaultRoomWearCostume                  { get; set; }
        public UnitIdol?                                CustomRoomWearCostume                   { get; set; }
        public UnitIdol?                                MiniCharaTrainingWear                   { get; set; }
        public int                                      SelectedMstSkillId                      { get; set; }
        public ProduceIdol?                             ProduceIdol                             { get; set; }

        public static ProduceIdolModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceIdolModel() { Pointer= p0 };

            value.CharaId                                   = GetInt32(new IntPtr(p + 0x010)); // 0x10 CharaId                     ( ModelPrimitiveType int int int Int32 )
            value.BaseStatus                                = GetObject<IdolStatusData>(new IntPtr(p + 0x018), ReversePrism.DataModels.IdolStatusData.FromPointer); // 0x18 BaseStatus                  ( ModelClassType IdolStatusData IdolStatusData IdolStatusData Pointer )
            value.CurrentStatus                             = GetObject<IdolStatusData>(new IntPtr(p + 0x020), ReversePrism.DataModels.IdolStatusData.FromPointer); // 0x20 CurrentStatus               ( ModelClassType IdolStatusData IdolStatusData IdolStatusData Pointer )
            value.ActiveSkill                               = GetObject<IInProduceIdolSkillStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.IInProduceIdolSkillStatus.FromPointer); // 0x28 ActiveSkill                 ( ModelClassType IInProduceIdolSkillStatus IInProduceIdolSkillStatus IInProduceIdolSkillStatus Pointer )
            value.BaseIdolVo                                = GetInt32(new IntPtr(p + 0x030)); // 0x30 BaseIdolVo                  ( ModelPrimitiveType int int int Int32 )
            value.BaseIdolDa                                = GetInt32(new IntPtr(p + 0x034)); // 0x34 BaseIdolDa                  ( ModelPrimitiveType int int int Int32 )
            value.BaseIdolVi                                = GetInt32(new IntPtr(p + 0x038)); // 0x38 BaseIdolVi                  ( ModelPrimitiveType int int int Int32 )
            value.BaseIdolMe                                = GetInt32(new IntPtr(p + 0x03C)); // 0x3C BaseIdolMe                  ( ModelPrimitiveType int int int Int32 )
            value.TrainingWearCostume                       = GetObject<UnitIdol>(new IntPtr(p + 0x040), ReversePrism.DataModels.UnitIdol.FromPointer); // 0x40 TrainingWearCostume         ( ModelClassType UnitIdol UnitIdol UnitIdol Pointer )
            value.StageCostume                              = GetObject<UnitIdol>(new IntPtr(p + 0x048), ReversePrism.DataModels.UnitIdol.FromPointer); // 0x48 StageCostume                ( ModelClassType UnitIdol UnitIdol UnitIdol Pointer )
            value.MiniCharaStage1                           = GetObject<UnitIdol>(new IntPtr(p + 0x050), ReversePrism.DataModels.UnitIdol.FromPointer); // 0x50 MiniCharaStage1             ( ModelClassType UnitIdol UnitIdol UnitIdol Pointer )
            value.MiniCharaStage2                           = GetObject<UnitIdol>(new IntPtr(p + 0x058), ReversePrism.DataModels.UnitIdol.FromPointer); // 0x58 MiniCharaStage2             ( ModelClassType UnitIdol UnitIdol UnitIdol Pointer )
            value.DefaultRoomWearCostume                    = GetObject<UnitIdol>(new IntPtr(p + 0x060), ReversePrism.DataModels.UnitIdol.FromPointer); // 0x60 DefaultRoomWearCostume      ( ModelClassType UnitIdol UnitIdol UnitIdol Pointer )
            value.CustomRoomWearCostume                     = GetObject<UnitIdol>(new IntPtr(p + 0x068), ReversePrism.DataModels.UnitIdol.FromPointer); // 0x68 CustomRoomWearCostume       ( ModelClassType UnitIdol UnitIdol UnitIdol Pointer )
            value.MiniCharaTrainingWear                     = GetObject<UnitIdol>(new IntPtr(p + 0x070), ReversePrism.DataModels.UnitIdol.FromPointer); // 0x70 MiniCharaTrainingWear       ( ModelClassType UnitIdol UnitIdol UnitIdol Pointer )
            value.SelectedMstSkillId                        = GetInt32(new IntPtr(p + 0x078)); // 0x78 SelectedMstSkillId          ( ModelPrimitiveType int int int Int32 )
            value.ProduceIdol                               = GetObject<ProduceIdol>(new IntPtr(p + 0x080), ReversePrism.DataModels.ProduceIdol.FromPointer); // 0x80 ProduceIdol                 ( ModelClassType ProduceIdol ProduceIdol ProduceIdol Pointer )

            return value;
        }
    }
}
