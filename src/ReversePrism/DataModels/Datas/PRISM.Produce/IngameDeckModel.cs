using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsFixSkillCard                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 018 StartTargetCardList                      000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 020 TargetCardList                           000185CECF28 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 028 MaxDefaultSelectCardLength               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 02C AddHandCountMaxOnDraw                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 030 RandomoModel                             0001866E6920 ModelClassType IngameRandomModel IngameRandomModel IngameRandomModel Pointer
    // 038 getStatusEffectManagerFunc               Func`1<ProduceInGameEffectManager> IL2CPP_TYPE_GENERICINST
    // 040 isMatchParameterTypeFunc                 Func`3<IngamePCardModel, ProduceParameterType, bool> IL2CPP_TYPE_GENERICINST
    // 048 DeckDataList                             000185CEBD78 ModelClassListType List`1<IngamePCardModel> List`1<IngamePCardModel> List<IngamePCardModel> Pointer
    // 050 HandList                                 000185CEBD78 ModelClassListType List`1<IngamePCardModel> List`1<IngamePCardModel> List<IngamePCardModel> Pointer
    // 058 Graveyard                                000185CEBD78 ModelClassListType List`1<IngamePCardModel> List`1<IngamePCardModel> List<IngamePCardModel> Pointer
    // 060 CopyCardList                             000185CEBD78 ModelClassListType List`1<IngamePCardModel> List`1<IngamePCardModel> List<IngamePCardModel> Pointer
    // 068 ExclusionCards                           000185CEBD78 ModelClassListType List`1<IngamePCardModel> List`1<IngamePCardModel> List<IngamePCardModel> Pointer
    // 070 ExceptHandAndGraveyards                  000185CEBD78 ModelClassListType List`1<IngamePCardModel> List`1<IngamePCardModel> List<IngamePCardModel> Pointer
    // 078 onSearchSubject                          Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 080 onChangeExclusionCardSubject             Subject`1<ValueTuple`2<int, bool>> IL2CPP_TYPE_GENERICINST
    // 088 onAddHandCardSubject                     Subject`1<IngamePCardModel> IL2CPP_TYPE_GENERICINST
    // 090 onUpdateHandStateSubject                 Subject`1<ValueTuple`2<int, IngamePCardModel>> IL2CPP_TYPE_GENERICINST
    // 098 onIncreaseMaxHandNumSubject              Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 0A0 parameterTypeUseCardCounts               Dictionary`2<ProduceParameterType, int> IL2CPP_TYPE_GENERICINST
    // 0A8 InitialDeckCount                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0AC TotalUseCardCount                        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0B0 ReleaseHandIndexes                       000185CED1B8 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    public partial class IngameDeckModel : DataModel
    {
        public bool                                     IsFixSkillCard                          { get; set; }
        public List<int>?                               StartTargetCardList                     { get; set; }
        public List<int>?                               TargetCardList                          { get; set; }
        public int                                      MaxDefaultSelectCardLength              { get; set; }
        public int                                      AddHandCountMaxOnDraw                   { get; set; }
        public IngameRandomModel?                       RandomoModel                            { get; set; }
        public List<IngamePCardModel>?                  DeckDataList                            { get; set; }
        public List<IngamePCardModel>?                  HandList                                { get; set; }
        public List<IngamePCardModel>?                  Graveyard                               { get; set; }
        public List<IngamePCardModel>?                  CopyCardList                            { get; set; }
        public List<IngamePCardModel>?                  ExclusionCards                          { get; set; }
        public List<IngamePCardModel>?                  ExceptHandAndGraveyards                 { get; set; }
        public int                                      InitialDeckCount                        { get; set; }
        public int                                      TotalUseCardCount                       { get; set; }
        public List<int>?                               ReleaseHandIndexes                      { get; set; }

        public static IngameDeckModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IngameDeckModel() { Pointer= p0 };

            value.IsFixSkillCard                            = GetBool(new IntPtr(p + 0x010)); // 024665BAE238 0x10 IsFixSkillCard              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.StartTargetCardList                       = GetInt32List(new IntPtr(p + 0x018)); // 024665BAE258 0x18 StartTargetCardList         ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.TargetCardList                            = GetInt32List(new IntPtr(p + 0x020)); // 024665BAE278 0x20 TargetCardList              ( 000185CECF28 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.MaxDefaultSelectCardLength                = GetInt32(new IntPtr(p + 0x028)); // 024665BAE298 0x28 MaxDefaultSelectCardLength  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.AddHandCountMaxOnDraw                     = GetInt32(new IntPtr(p + 0x02C)); // 024665BAE2B8 0x2C AddHandCountMaxOnDraw       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.RandomoModel                              = GetObject<IngameRandomModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.IngameRandomModel.FromPointer); // 024665BAE2D8 0x30 RandomoModel                ( 0001866E6920 ModelClassType IngameRandomModel IngameRandomModel IngameRandomModel Pointer )
            value.DeckDataList                              = GetObjectList<IngamePCardModel>(new IntPtr(p + 0x048), ReversePrism.DataModels.IngamePCardModel.FromPointer); // 024665BAE338 0x48 DeckDataList                ( 000185CEBD78 ModelClassListType List`1<IngamePCardModel> List`1<IngamePCardModel> List<IngamePCardModel> Pointer )
            value.HandList                                  = GetObjectList<IngamePCardModel>(new IntPtr(p + 0x050), ReversePrism.DataModels.IngamePCardModel.FromPointer); // 024665BAE358 0x50 HandList                    ( 000185CEBD78 ModelClassListType List`1<IngamePCardModel> List`1<IngamePCardModel> List<IngamePCardModel> Pointer )
            value.Graveyard                                 = GetObjectList<IngamePCardModel>(new IntPtr(p + 0x058), ReversePrism.DataModels.IngamePCardModel.FromPointer); // 024665BAE378 0x58 Graveyard                   ( 000185CEBD78 ModelClassListType List`1<IngamePCardModel> List`1<IngamePCardModel> List<IngamePCardModel> Pointer )
            value.CopyCardList                              = GetObjectList<IngamePCardModel>(new IntPtr(p + 0x060), ReversePrism.DataModels.IngamePCardModel.FromPointer); // 024665BAE398 0x60 CopyCardList                ( 000185CEBD78 ModelClassListType List`1<IngamePCardModel> List`1<IngamePCardModel> List<IngamePCardModel> Pointer )
            value.ExclusionCards                            = GetObjectList<IngamePCardModel>(new IntPtr(p + 0x068), ReversePrism.DataModels.IngamePCardModel.FromPointer); // 024665BAE3B8 0x68 ExclusionCards              ( 000185CEBD78 ModelClassListType List`1<IngamePCardModel> List`1<IngamePCardModel> List<IngamePCardModel> Pointer )
            value.ExceptHandAndGraveyards                   = GetObjectList<IngamePCardModel>(new IntPtr(p + 0x070), ReversePrism.DataModels.IngamePCardModel.FromPointer); // 024665BAE3D8 0x70 ExceptHandAndGraveyards     ( 000185CEBD78 ModelClassListType List`1<IngamePCardModel> List`1<IngamePCardModel> List<IngamePCardModel> Pointer )
            value.InitialDeckCount                          = GetInt32(new IntPtr(p + 0x0A8)); // 024665BAE4B8 0xA8 InitialDeckCount            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.TotalUseCardCount                         = GetInt32(new IntPtr(p + 0x0AC)); // 024665BAE4D8 0xAC TotalUseCardCount           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ReleaseHandIndexes                        = GetInt32List(new IntPtr(p + 0x0B0)); // 024665BAE4F8 0xB0 ReleaseHandIndexes          ( 000185CED1B8 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )

            return value;
        }
    }
}
