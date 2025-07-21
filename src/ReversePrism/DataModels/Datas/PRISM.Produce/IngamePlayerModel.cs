using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsPlayer                                 ModelPrimitiveType bool bool bool Bool
    // 014 UnitId                                   ModelPrimitiveType int int int Int32
    // 018 getGameLimitTimeFunc                     Func`1<float> IL2CPP_TYPE_GENERICINST
    // 020 updateMentalCallback                     Action`5<int, int, bool, bool, int> IL2CPP_TYPE_GENERICINST
    // 028 getProduceInGameEffectManagerFunc        Func`1<ProduceInGameEffectManager> IL2CPP_TYPE_GENERICINST
    // 030 ProduceInGameEffectManager               ModelClassType ProduceInGameEffectManager ProduceInGameEffectManager ProduceInGameEffectManager Pointer
    // 038 Opponent                                 ModelClassType IngamePlayerModel IngamePlayerModel IngamePlayerModel Pointer
    // 040 SkillActionModel                         ModelClassType IngameSkillActionModel IngameSkillActionModel IngameSkillActionModel Pointer
    // 048 CopyExecResult                           ModelClassType CardAndSkillExecResult CardAndSkillExecResult CardAndSkillExecResult Pointer
    // 050 UseTypeCountersMentalRec                 ModelEnumListType List`1<ProduceParameterType> List`1<ProduceParameterType> List<ProduceParameterType> Pointer
    // 058 SelfDamageValue                          ModelPrimitiveType int int int Int32
    // 05C CacheDamageMental                        ModelPrimitiveType int int int Int32
    // 060 onChangeSkillStateSubject                Subject`1<ValueTuple`2<int, SkillAvailableState>> IL2CPP_TYPE_GENERICINST
    // 068 onChangeSkillCostSubject                 Subject`1<ValueTuple`3<int, int, int>> IL2CPP_TYPE_GENERICINST
    // 070 RandomModel                              ModelClassType IngameRandomModel IngameRandomModel IngameRandomModel Pointer
    // 078 Disposable                               ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 080 SkillSubscribers                         ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 088 TallyModel                               ModelClassType IngameTallyModel IngameTallyModel IngameTallyModel Pointer
    // 090 AddIdolAppealEffectType                  ModelEnumListType ProduceInGameEffectType[] ProduceInGameEffectType[] List<ProduceInGameEffectType> Pointer
    // 098 UnitModel                                ModelClassType IngameUnitModel IngameUnitModel IngameUnitModel Pointer
    // 0A0 AppealModel                              ModelClassType IngameAppealModel IngameAppealModel IngameAppealModel Pointer
    // 0A8 AvoidModel                               ModelClassType IngameAvoidModel IngameAvoidModel IngameAvoidModel Pointer
    // 0B0 DeckModel                                ModelClassType IngameDeckModel IngameDeckModel IngameDeckModel Pointer
    // 0B8 MentalModel                              ModelClassType IngameMentalModel IngameMentalModel IngameMentalModel Pointer
    // 0C0 ProducePointModel                        ModelClassType IngameProducePointModel IngameProducePointModel IngameProducePointModel Pointer
    // 0C8 SkillListModel                           ModelClassType IngameSkillListModel IngameSkillListModel IngameSkillListModel Pointer
    // 0D0 TypeCounterModel                         ModelClassType IngameTypeCounterModel IngameTypeCounterModel IngameTypeCounterModel Pointer
    // 0D8 IngamePhaseModel                         ModelClassType IngamePhaseModel IngamePhaseModel IngamePhaseModel Pointer
    public partial class IngamePlayerModel : DataModel
    {
        public bool                                     IsPlayer                                { get; set; }
        public int                                      UnitId                                  { get; set; }
        public ProduceInGameEffectManager?              ProduceInGameEffectManager              { get; set; }
        public IngamePlayerModel?                       Opponent                                { get; set; }
        public IngameSkillActionModel?                  SkillActionModel                        { get; set; }
        public CardAndSkillExecResult?                  CopyExecResult                          { get; set; }
        public List<ProduceParameterType>?              UseTypeCountersMentalRec                { get; set; }
        public int                                      SelfDamageValue                         { get; set; }
        public int                                      CacheDamageMental                       { get; set; }
        public IngameRandomModel?                       RandomModel                             { get; set; }
        public CompositeDisposable?                     Disposable                              { get; set; }
        public CompositeDisposable?                     SkillSubscribers                        { get; set; }
        public IngameTallyModel?                        TallyModel                              { get; set; }
        public List<ProduceInGameEffectType>?           AddIdolAppealEffectType                 { get; set; }
        public IngameUnitModel?                         UnitModel                               { get; set; }
        public IngameAppealModel?                       AppealModel                             { get; set; }
        public IngameAvoidModel?                        AvoidModel                              { get; set; }
        public IngameDeckModel?                         DeckModel                               { get; set; }
        public IngameMentalModel?                       MentalModel                             { get; set; }
        public IngameProducePointModel?                 ProducePointModel                       { get; set; }
        public IngameSkillListModel?                    SkillListModel                          { get; set; }
        public IngameTypeCounterModel?                  TypeCounterModel                        { get; set; }
        public IngamePhaseModel?                        IngamePhaseModel                        { get; set; }

        public static IngamePlayerModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IngamePlayerModel() { Pointer= p0 };

            value.IsPlayer                                  = GetBool(new IntPtr(p + 0x010)); // 0x10 IsPlayer                    ( ModelPrimitiveType bool bool bool Bool )
            value.UnitId                                    = GetInt32(new IntPtr(p + 0x014)); // 0x14 UnitId                      ( ModelPrimitiveType int int int Int32 )
            value.ProduceInGameEffectManager                = GetObject<ProduceInGameEffectManager>(new IntPtr(p + 0x030), ReversePrism.DataModels.ProduceInGameEffectManager.FromPointer); // 0x30 ProduceInGameEffectManager  ( ModelClassType ProduceInGameEffectManager ProduceInGameEffectManager ProduceInGameEffectManager Pointer )
            value.Opponent                                  = GetObject<IngamePlayerModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.IngamePlayerModel.FromPointer); // 0x38 Opponent                    ( ModelClassType IngamePlayerModel IngamePlayerModel IngamePlayerModel Pointer )
            value.SkillActionModel                          = GetObject<IngameSkillActionModel>(new IntPtr(p + 0x040), ReversePrism.DataModels.IngameSkillActionModel.FromPointer); // 0x40 SkillActionModel            ( ModelClassType IngameSkillActionModel IngameSkillActionModel IngameSkillActionModel Pointer )
            value.CopyExecResult                            = GetObject<CardAndSkillExecResult>(new IntPtr(p + 0x048), ReversePrism.DataModels.CardAndSkillExecResult.FromPointer); // 0x48 CopyExecResult              ( ModelClassType CardAndSkillExecResult CardAndSkillExecResult CardAndSkillExecResult Pointer )
            value.UseTypeCountersMentalRec                  = GetEnumList<ProduceParameterType>(new IntPtr(p + 0x050)); // 0x50 UseTypeCountersMentalRec    ( ModelEnumListType List`1<ProduceParameterType> List`1<ProduceParameterType> List<ProduceParameterType> Pointer )
            value.SelfDamageValue                           = GetInt32(new IntPtr(p + 0x058)); // 0x58 SelfDamageValue             ( ModelPrimitiveType int int int Int32 )
            value.CacheDamageMental                         = GetInt32(new IntPtr(p + 0x05C)); // 0x5C CacheDamageMental           ( ModelPrimitiveType int int int Int32 )
            value.RandomModel                               = GetObject<IngameRandomModel>(new IntPtr(p + 0x070), ReversePrism.DataModels.IngameRandomModel.FromPointer); // 0x70 RandomModel                 ( ModelClassType IngameRandomModel IngameRandomModel IngameRandomModel Pointer )
            value.Disposable                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x078), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x78 Disposable                  ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.SkillSubscribers                          = GetObject<CompositeDisposable>(new IntPtr(p + 0x080), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x80 SkillSubscribers            ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.TallyModel                                = GetObject<IngameTallyModel>(new IntPtr(p + 0x088), ReversePrism.DataModels.IngameTallyModel.FromPointer); // 0x88 TallyModel                  ( ModelClassType IngameTallyModel IngameTallyModel IngameTallyModel Pointer )
            value.AddIdolAppealEffectType                   = GetEnumList<ProduceInGameEffectType>(new IntPtr(p + 0x090)); // 0x90 AddIdolAppealEffectType     ( ModelEnumListType ProduceInGameEffectType[] ProduceInGameEffectType[] List<ProduceInGameEffectType> Pointer )
            value.UnitModel                                 = GetObject<IngameUnitModel>(new IntPtr(p + 0x098), ReversePrism.DataModels.IngameUnitModel.FromPointer); // 0x98 UnitModel                   ( ModelClassType IngameUnitModel IngameUnitModel IngameUnitModel Pointer )
            value.AppealModel                               = GetObject<IngameAppealModel>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.IngameAppealModel.FromPointer); // 0xA0 AppealModel                 ( ModelClassType IngameAppealModel IngameAppealModel IngameAppealModel Pointer )
            value.AvoidModel                                = GetObject<IngameAvoidModel>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.IngameAvoidModel.FromPointer); // 0xA8 AvoidModel                  ( ModelClassType IngameAvoidModel IngameAvoidModel IngameAvoidModel Pointer )
            value.DeckModel                                 = GetObject<IngameDeckModel>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.IngameDeckModel.FromPointer); // 0xB0 DeckModel                   ( ModelClassType IngameDeckModel IngameDeckModel IngameDeckModel Pointer )
            value.MentalModel                               = GetObject<IngameMentalModel>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.IngameMentalModel.FromPointer); // 0xB8 MentalModel                 ( ModelClassType IngameMentalModel IngameMentalModel IngameMentalModel Pointer )
            value.ProducePointModel                         = GetObject<IngameProducePointModel>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.IngameProducePointModel.FromPointer); // 0xC0 ProducePointModel           ( ModelClassType IngameProducePointModel IngameProducePointModel IngameProducePointModel Pointer )
            value.SkillListModel                            = GetObject<IngameSkillListModel>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.IngameSkillListModel.FromPointer); // 0xC8 SkillListModel              ( ModelClassType IngameSkillListModel IngameSkillListModel IngameSkillListModel Pointer )
            value.TypeCounterModel                          = GetObject<IngameTypeCounterModel>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.IngameTypeCounterModel.FromPointer); // 0xD0 TypeCounterModel            ( ModelClassType IngameTypeCounterModel IngameTypeCounterModel IngameTypeCounterModel Pointer )
            value.IngamePhaseModel                          = GetObject<IngamePhaseModel>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.IngamePhaseModel.FromPointer); // 0xD8 IngamePhaseModel            ( ModelClassType IngamePhaseModel IngamePhaseModel IngamePhaseModel Pointer )

            return value;
        }
    }
}
