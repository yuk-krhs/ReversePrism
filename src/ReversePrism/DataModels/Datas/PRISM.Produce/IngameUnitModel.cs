using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CurrentStatus                            0001865E67C0 ModelClassType IngamePlayerStatusModel IngamePlayerStatusModel IngamePlayerStatusModel Pointer
    // 018 BaseStatus                               0001865E67C0 ModelClassType IngamePlayerStatusModel IngamePlayerStatusModel IngamePlayerStatusModel Pointer
    // 020 EffectManager                            000186557830 ModelClassType ProduceInGameEffectManager ProduceInGameEffectManager ProduceInGameEffectManager Pointer
    // 028 IsNeedCorrect                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 030 Disposable                               0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 038 UnitID                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 040 UnitMemberModels                         000185D11798 ModelClassListType IReadOnlyList`1<IngameUnitMemberModel> IReadOnlyList`1<IngameUnitMemberModel> List<IngameUnitMemberModel> Pointer
    // 048 DeckCards                                000185D05FD8 ModelClassListType IReadOnlyList`1<IProduceCardStatus> IReadOnlyList`1<IProduceCardStatus> List<IProduceCardStatus> Pointer
    // 050 SkillModels                              000185D112C8 ModelClassListType IReadOnlyList`1<IngameSkillModel> IReadOnlyList`1<IngameSkillModel> List<IngameSkillModel> Pointer
    // 058 SupportSkills                            000185D11558 ModelClassListType IReadOnlyList`1<IngameSupportSkillModel> IReadOnlyList`1<IngameSupportSkillModel> List<IngameSupportSkillModel> Pointer
    public partial class IngameUnitModel : DataModel
    {
        public IngamePlayerStatusModel?                 CurrentStatus                           { get; set; }
        public IngamePlayerStatusModel?                 BaseStatus                              { get; set; }
        public ProduceInGameEffectManager?              EffectManager                           { get; set; }
        public bool                                     IsNeedCorrect                           { get; set; }
        public CompositeDisposable?                     Disposable                              { get; set; }
        public int                                      UnitID                                  { get; set; }
        public List<IngameUnitMemberModel>?             UnitMemberModels                        { get; set; }
        public List<IProduceCardStatus>?                DeckCards                               { get; set; }
        public List<IngameSkillModel>?                  SkillModels                             { get; set; }
        public List<IngameSupportSkillModel>?           SupportSkills                           { get; set; }

        public static IngameUnitModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IngameUnitModel() { Pointer= p0 };

            value.CurrentStatus                             = GetObject<IngamePlayerStatusModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.IngamePlayerStatusModel.FromPointer); // 024664D4F7B0 0x10 CurrentStatus               ( 0001865E67C0 ModelClassType IngamePlayerStatusModel IngamePlayerStatusModel IngamePlayerStatusModel Pointer )
            value.BaseStatus                                = GetObject<IngamePlayerStatusModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.IngamePlayerStatusModel.FromPointer); // 024664D4F7D0 0x18 BaseStatus                  ( 0001865E67C0 ModelClassType IngamePlayerStatusModel IngamePlayerStatusModel IngamePlayerStatusModel Pointer )
            value.EffectManager                             = GetObject<ProduceInGameEffectManager>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProduceInGameEffectManager.FromPointer); // 024664D4F7F0 0x20 EffectManager               ( 000186557830 ModelClassType ProduceInGameEffectManager ProduceInGameEffectManager ProduceInGameEffectManager Pointer )
            value.IsNeedCorrect                             = GetBool(new IntPtr(p + 0x028)); // 024664D4F810 0x28 IsNeedCorrect               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Disposable                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x030), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 024664D4F830 0x30 Disposable                  ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.UnitID                                    = GetInt32(new IntPtr(p + 0x038)); // 024664D4F850 0x38 UnitID                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.UnitMemberModels                          = GetObjectList<IngameUnitMemberModel>(new IntPtr(p + 0x040), ReversePrism.DataModels.IngameUnitMemberModel.FromPointer); // 024664D4F870 0x40 UnitMemberModels            ( 000185D11798 ModelClassListType IReadOnlyList`1<IngameUnitMemberModel> IReadOnlyList`1<IngameUnitMemberModel> List<IngameUnitMemberModel> Pointer )
            value.DeckCards                                 = GetObjectList<IProduceCardStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.IProduceCardStatus.FromPointer); // 024664D4F890 0x48 DeckCards                   ( 000185D05FD8 ModelClassListType IReadOnlyList`1<IProduceCardStatus> IReadOnlyList`1<IProduceCardStatus> List<IProduceCardStatus> Pointer )
            value.SkillModels                               = GetObjectList<IngameSkillModel>(new IntPtr(p + 0x050), ReversePrism.DataModels.IngameSkillModel.FromPointer); // 024664D4F8B0 0x50 SkillModels                 ( 000185D112C8 ModelClassListType IReadOnlyList`1<IngameSkillModel> IReadOnlyList`1<IngameSkillModel> List<IngameSkillModel> Pointer )
            value.SupportSkills                             = GetObjectList<IngameSupportSkillModel>(new IntPtr(p + 0x058), ReversePrism.DataModels.IngameSupportSkillModel.FromPointer); // 024664D4F8D0 0x58 SupportSkills               ( 000185D11558 ModelClassListType IReadOnlyList`1<IngameSupportSkillModel> IReadOnlyList`1<IngameSupportSkillModel> List<IngameSupportSkillModel> Pointer )

            return value;
        }
    }
}
