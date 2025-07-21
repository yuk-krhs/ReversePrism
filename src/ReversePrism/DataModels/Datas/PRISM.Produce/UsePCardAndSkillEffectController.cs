using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 DisplayEffectMax                         int IL2CPP_TYPE_I4
    // 020 PlayerEffectPoints                       ModelClassListType Transform[] Transform[] List<Transform> Pointer
    // 028 EnemyEffectPoints                        ModelClassListType Transform[] Transform[] List<Transform> Pointer
    // 030 AppealEffectModels                       ModelClassListType PCardAndSkillAppealEffectModel[] PCardAndSkillAppealEffectModel[] List<PCardAndSkillAppealEffectModel> Pointer
    // 038 OtherEffectModels                        ModelClassListType PCardAndSkillUIEffectModel[] PCardAndSkillUIEffectModel[] List<PCardAndSkillUIEffectModel> Pointer
    // 040 MoveFrame                                ModelPrimitiveType int int int Int32
    // 044 DisplayEffectCount                       ModelPrimitiveType int int int Int32
    // 048 AnimationSpeed                           ModelPrimitiveType float float float Single
    // 050 TokenSource                              ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    public partial class UsePCardAndSkillEffectController : DataModel
    {
        public List<Transform>?                         PlayerEffectPoints                      { get; set; }
        public List<Transform>?                         EnemyEffectPoints                       { get; set; }
        public List<PCardAndSkillAppealEffectModel>?    AppealEffectModels                      { get; set; }
        public List<PCardAndSkillUIEffectModel>?        OtherEffectModels                       { get; set; }
        public int                                      MoveFrame                               { get; set; }
        public int                                      DisplayEffectCount                      { get; set; }
        public float                                    AnimationSpeed                          { get; set; }
        public CancellationTokenSource?                 TokenSource                             { get; set; }

        public static UsePCardAndSkillEffectController? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UsePCardAndSkillEffectController() { Pointer= p0 };

            value.PlayerEffectPoints                        = GetObjectList<Transform>(new IntPtr(p + 0x020), ReversePrism.DataModels.Transform.FromPointer); // 0x20 PlayerEffectPoints          ( ModelClassListType Transform[] Transform[] List<Transform> Pointer )
            value.EnemyEffectPoints                         = GetObjectList<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 0x28 EnemyEffectPoints           ( ModelClassListType Transform[] Transform[] List<Transform> Pointer )
            value.AppealEffectModels                        = GetObjectList<PCardAndSkillAppealEffectModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.PCardAndSkillAppealEffectModel.FromPointer); // 0x30 AppealEffectModels          ( ModelClassListType PCardAndSkillAppealEffectModel[] PCardAndSkillAppealEffectModel[] List<PCardAndSkillAppealEffectModel> Pointer )
            value.OtherEffectModels                         = GetObjectList<PCardAndSkillUIEffectModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.PCardAndSkillUIEffectModel.FromPointer); // 0x38 OtherEffectModels           ( ModelClassListType PCardAndSkillUIEffectModel[] PCardAndSkillUIEffectModel[] List<PCardAndSkillUIEffectModel> Pointer )
            value.MoveFrame                                 = GetInt32(new IntPtr(p + 0x040)); // 0x40 MoveFrame                   ( ModelPrimitiveType int int int Int32 )
            value.DisplayEffectCount                        = GetInt32(new IntPtr(p + 0x044)); // 0x44 DisplayEffectCount          ( ModelPrimitiveType int int int Int32 )
            value.AnimationSpeed                            = GetSingle(new IntPtr(p + 0x048)); // 0x48 AnimationSpeed              ( ModelPrimitiveType float float float Single )
            value.TokenSource                               = GetObject<CancellationTokenSource>(new IntPtr(p + 0x050), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x50 TokenSource                 ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )

            return value;
        }
    }
}
