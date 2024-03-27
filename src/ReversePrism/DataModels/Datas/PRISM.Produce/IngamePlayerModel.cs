using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsPlayer                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 014 UnitId                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 getGameLimitTimeFunc                     Func`1<float> IL2CPP_TYPE_GENERICINST
    // 020 updateMentalCallback                     Action`3<int, int, bool> IL2CPP_TYPE_GENERICINST
    // 028 getProduceInGameEffectManagerFunc        Func`1<ProduceInGameEffectManager> IL2CPP_TYPE_GENERICINST
    // 030 ProduceInGameEffectManager               000186557830 ModelClassType ProduceInGameEffectManager ProduceInGameEffectManager ProduceInGameEffectManager Pointer
    // 038 Opponent                                 0001866E5D10 ModelClassType IngamePlayerModel IngamePlayerModel IngamePlayerModel Pointer
    // 040 SkillActionModel                         0001866E7070 ModelClassType IngameSkillActionModel IngameSkillActionModel IngameSkillActionModel Pointer
    // 048 CopyExecResult                           000186544B20 ModelClassType CardAndSkillExecResult CardAndSkillExecResult CardAndSkillExecResult Pointer
    // 050 UseTypeCountersMentalRec                 000185D22D68 ModelEnumListType List`1<ProduceParameterType> List`1<ProduceParameterType> List<ProduceParameterType> Pointer
    // 058 SelfDamageValue                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 05C CacheDamageMental                        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 060 onChangeSkillStateSubject                Subject`1<ValueTuple`2<int, SkillAvailableState>> IL2CPP_TYPE_GENERICINST
    // 068 onChangeSkillCostSubject                 Subject`1<ValueTuple`3<int, int, int>> IL2CPP_TYPE_GENERICINST
    // 070 RandomModel                              0001866E6920 ModelClassType IngameRandomModel IngameRandomModel IngameRandomModel Pointer
    // 078 Disposable                               0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 080 SkillSubscribers                         0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 088 TallyModel                               0001866E8E10 ModelClassType IngameTallyModel IngameTallyModel IngameTallyModel Pointer
    // 090 AddIdolAppealEffectType                  000185B9D290 ModelEnumListType ProduceInGameEffectType[] ProduceInGameEffectType[] List<ProduceInGameEffectType> Pointer
    // 098 UnitModel                                0001866EA830 ModelClassType IngameUnitModel IngameUnitModel IngameUnitModel Pointer
    // 0A0 AppealModel                              0001866E2290 ModelClassType IngameAppealModel IngameAppealModel IngameAppealModel Pointer
    // 0A8 AvoidModel                               0001866E2730 ModelClassType IngameAvoidModel IngameAvoidModel IngameAvoidModel Pointer
    // 0B0 DeckModel                                0001866E3900 ModelClassType IngameDeckModel IngameDeckModel IngameDeckModel Pointer
    // 0B8 MentalModel                              0001866E3FF0 ModelClassType IngameMentalModel IngameMentalModel IngameMentalModel Pointer
    // 0C0 ProducePointModel                        0001866E6440 ModelClassType IngameProducePointModel IngameProducePointModel IngameProducePointModel Pointer
    // 0C8 SkillListModel                           0001866E7CB0 ModelClassType IngameSkillListModel IngameSkillListModel IngameSkillListModel Pointer
    // 0D0 TypeCounterModel                         0001866E9F40 ModelClassType IngameTypeCounterModel IngameTypeCounterModel IngameTypeCounterModel Pointer
    // 0D8 IngamePhaseModel                         0001866E5330 ModelClassType IngamePhaseModel IngamePhaseModel IngamePhaseModel Pointer
    public partial class IngamePlayerModel
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
            var value   = new IngamePlayerModel();

            value.IsPlayer                                  = GetBool(new IntPtr(p + 0x010)); // 0270D59C08E8 0x10 IsPlayer                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.UnitId                                    = GetInt32(new IntPtr(p + 0x014)); // 0270D59C0908 0x14 UnitId                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ProduceInGameEffectManager                = GetObject<ProduceInGameEffectManager>(new IntPtr(p + 0x030), ReversePrism.DataModels.ProduceInGameEffectManager.FromPointer); // 0270D59C0988 0x30 ProduceInGameEffectManager  ( 000186557830 ModelClassType ProduceInGameEffectManager ProduceInGameEffectManager ProduceInGameEffectManager Pointer )
            value.Opponent                                  = GetObject<IngamePlayerModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.IngamePlayerModel.FromPointer); // 0270D59C09A8 0x38 Opponent                    ( 0001866E5D10 ModelClassType IngamePlayerModel IngamePlayerModel IngamePlayerModel Pointer )
            value.SkillActionModel                          = GetObject<IngameSkillActionModel>(new IntPtr(p + 0x040), ReversePrism.DataModels.IngameSkillActionModel.FromPointer); // 0270D59C09C8 0x40 SkillActionModel            ( 0001866E7070 ModelClassType IngameSkillActionModel IngameSkillActionModel IngameSkillActionModel Pointer )
            value.CopyExecResult                            = GetObject<CardAndSkillExecResult>(new IntPtr(p + 0x048), ReversePrism.DataModels.CardAndSkillExecResult.FromPointer); // 0270D59C09E8 0x48 CopyExecResult              ( 000186544B20 ModelClassType CardAndSkillExecResult CardAndSkillExecResult CardAndSkillExecResult Pointer )
            value.UseTypeCountersMentalRec                  = GetEnumList<ProduceParameterType>(new IntPtr(p + 0x050)); // 0270D59C0A08 0x50 UseTypeCountersMentalRec    ( 000185D22D68 ModelEnumListType List`1<ProduceParameterType> List`1<ProduceParameterType> List<ProduceParameterType> Pointer )
            value.SelfDamageValue                           = GetInt32(new IntPtr(p + 0x058)); // 0270D59C0A28 0x58 SelfDamageValue             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CacheDamageMental                         = GetInt32(new IntPtr(p + 0x05C)); // 0270D59C0A48 0x5C CacheDamageMental           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.RandomModel                               = GetObject<IngameRandomModel>(new IntPtr(p + 0x070), ReversePrism.DataModels.IngameRandomModel.FromPointer); // 0270D59C0AA8 0x70 RandomModel                 ( 0001866E6920 ModelClassType IngameRandomModel IngameRandomModel IngameRandomModel Pointer )
            value.Disposable                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x078), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0270D59C0AC8 0x78 Disposable                  ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.SkillSubscribers                          = GetObject<CompositeDisposable>(new IntPtr(p + 0x080), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0270D59C0AE8 0x80 SkillSubscribers            ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.TallyModel                                = GetObject<IngameTallyModel>(new IntPtr(p + 0x088), ReversePrism.DataModels.IngameTallyModel.FromPointer); // 0270D59C0B08 0x88 TallyModel                  ( 0001866E8E10 ModelClassType IngameTallyModel IngameTallyModel IngameTallyModel Pointer )
            value.AddIdolAppealEffectType                   = GetEnumList<ProduceInGameEffectType>(new IntPtr(p + 0x090)); // 0270D59C0B28 0x90 AddIdolAppealEffectType     ( 000185B9D290 ModelEnumListType ProduceInGameEffectType[] ProduceInGameEffectType[] List<ProduceInGameEffectType> Pointer )
            value.UnitModel                                 = GetObject<IngameUnitModel>(new IntPtr(p + 0x098), ReversePrism.DataModels.IngameUnitModel.FromPointer); // 0270D59C0B48 0x98 UnitModel                   ( 0001866EA830 ModelClassType IngameUnitModel IngameUnitModel IngameUnitModel Pointer )
            value.AppealModel                               = GetObject<IngameAppealModel>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.IngameAppealModel.FromPointer); // 0270D59C0B68 0xA0 AppealModel                 ( 0001866E2290 ModelClassType IngameAppealModel IngameAppealModel IngameAppealModel Pointer )
            value.AvoidModel                                = GetObject<IngameAvoidModel>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.IngameAvoidModel.FromPointer); // 0270D59C0B88 0xA8 AvoidModel                  ( 0001866E2730 ModelClassType IngameAvoidModel IngameAvoidModel IngameAvoidModel Pointer )
            value.DeckModel                                 = GetObject<IngameDeckModel>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.IngameDeckModel.FromPointer); // 0270D59C0BA8 0xB0 DeckModel                   ( 0001866E3900 ModelClassType IngameDeckModel IngameDeckModel IngameDeckModel Pointer )
            value.MentalModel                               = GetObject<IngameMentalModel>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.IngameMentalModel.FromPointer); // 0270D59C0BC8 0xB8 MentalModel                 ( 0001866E3FF0 ModelClassType IngameMentalModel IngameMentalModel IngameMentalModel Pointer )
            value.ProducePointModel                         = GetObject<IngameProducePointModel>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.IngameProducePointModel.FromPointer); // 0270D59C0BE8 0xC0 ProducePointModel           ( 0001866E6440 ModelClassType IngameProducePointModel IngameProducePointModel IngameProducePointModel Pointer )
            value.SkillListModel                            = GetObject<IngameSkillListModel>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.IngameSkillListModel.FromPointer); // 0270D59C0C08 0xC8 SkillListModel              ( 0001866E7CB0 ModelClassType IngameSkillListModel IngameSkillListModel IngameSkillListModel Pointer )
            value.TypeCounterModel                          = GetObject<IngameTypeCounterModel>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.IngameTypeCounterModel.FromPointer); // 0270D59C0C28 0xD0 TypeCounterModel            ( 0001866E9F40 ModelClassType IngameTypeCounterModel IngameTypeCounterModel IngameTypeCounterModel Pointer )
            value.IngamePhaseModel                          = GetObject<IngamePhaseModel>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.IngamePhaseModel.FromPointer); // 0270D59C0C48 0xD8 IngamePhaseModel            ( 0001866E5330 ModelClassType IngamePhaseModel IngamePhaseModel IngamePhaseModel Pointer )

            return value;
        }
    }
}
