using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsFixSkillCard                           ModelPrimitiveType bool bool bool Bool
    // 018 StartTargetCardList                      ModelPrimitiveListType int[] int[] List<int> Pointer
    // 020 TargetCardList                           ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 028 CreateCardIdCount                        ModelPrimitiveType int int int Int32
    // 02C MaxDefaultSelectCardLength               ModelPrimitiveType int int int Int32
    // 030 AddHandCountMaxOnDraw                    ModelPrimitiveType int int int Int32
    // 038 RandomoModel                             ModelClassType IngameRandomModel IngameRandomModel IngameRandomModel Pointer
    // 040 getStatusEffectManagerFunc               Func`1<ProduceInGameEffectManager> IL2CPP_TYPE_GENERICINST
    // 048 AllCardList                              ModelClassListType List`1<IngamePCardModel> List`1<IngamePCardModel> List<IngamePCardModel> Pointer
    // 050 DeckDataList                             ModelClassListType List`1<IngamePCardModel> List`1<IngamePCardModel> List<IngamePCardModel> Pointer
    // 058 HandList                                 ModelClassListType List`1<IngamePCardModel> List`1<IngamePCardModel> List<IngamePCardModel> Pointer
    // 060 Graveyard                                ModelClassListType List`1<IngamePCardModel> List`1<IngamePCardModel> List<IngamePCardModel> Pointer
    // 068 CopyCardList                             ModelClassListType List`1<IngamePCardModel> List`1<IngamePCardModel> List<IngamePCardModel> Pointer
    // 070 ExclusionCards                           ModelClassListType List`1<IngamePCardModel> List`1<IngamePCardModel> List<IngamePCardModel> Pointer
    // 078 ExceptHandAndGraveyards                  ModelClassListType List`1<IngamePCardModel> List`1<IngamePCardModel> List<IngamePCardModel> Pointer
    // 080 onChangeExclusionCardSubject             Subject`1<ValueTuple`2<int, bool>> IL2CPP_TYPE_GENERICINST
    // 088 onAddHandCardSubject                     Subject`1<IngamePCardModel> IL2CPP_TYPE_GENERICINST
    // 090 onUpdateHandStateSubject                 Subject`1<ValueTuple`2<int, IngamePCardModel>> IL2CPP_TYPE_GENERICINST
    // 098 onIncreaseMaxHandNumSubject              Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 0A0 parameterTypeUseCardCounts               Dictionary`2<ProduceParameterType, int> IL2CPP_TYPE_GENERICINST
    // 0A8 InitialDeckCount                         ModelPrimitiveType int int int Int32
    // 0AC TotalUseCardCount                        ModelPrimitiveType int int int Int32
    // 0B0 ReleaseHandIndexes                       ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 0B8 RemoveList                               ModelClassListType List`1<IngamePCardModel> List`1<IngamePCardModel> List<IngamePCardModel> Pointer
    public partial class IngameDeckModel : DataModel
    {
        public bool                                     IsFixSkillCard                          { get; set; }
        public List<int>?                               StartTargetCardList                     { get; set; }
        public List<int>?                               TargetCardList                          { get; set; }
        public int                                      CreateCardIdCount                       { get; set; }
        public int                                      MaxDefaultSelectCardLength              { get; set; }
        public int                                      AddHandCountMaxOnDraw                   { get; set; }
        public IngameRandomModel?                       RandomoModel                            { get; set; }
        public List<IngamePCardModel>?                  AllCardList                             { get; set; }
        public List<IngamePCardModel>?                  DeckDataList                            { get; set; }
        public List<IngamePCardModel>?                  HandList                                { get; set; }
        public List<IngamePCardModel>?                  Graveyard                               { get; set; }
        public List<IngamePCardModel>?                  CopyCardList                            { get; set; }
        public List<IngamePCardModel>?                  ExclusionCards                          { get; set; }
        public List<IngamePCardModel>?                  ExceptHandAndGraveyards                 { get; set; }
        public int                                      InitialDeckCount                        { get; set; }
        public int                                      TotalUseCardCount                       { get; set; }
        public List<int>?                               ReleaseHandIndexes                      { get; set; }
        public List<IngamePCardModel>?                  RemoveList                              { get; set; }

        public static IngameDeckModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IngameDeckModel() { Pointer= p0 };

            value.IsFixSkillCard                            = GetBool(new IntPtr(p + 0x010)); // 0x10 IsFixSkillCard              ( ModelPrimitiveType bool bool bool Bool )
            value.StartTargetCardList                       = GetInt32List(new IntPtr(p + 0x018)); // 0x18 StartTargetCardList         ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.TargetCardList                            = GetInt32List(new IntPtr(p + 0x020)); // 0x20 TargetCardList              ( ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.CreateCardIdCount                         = GetInt32(new IntPtr(p + 0x028)); // 0x28 CreateCardIdCount           ( ModelPrimitiveType int int int Int32 )
            value.MaxDefaultSelectCardLength                = GetInt32(new IntPtr(p + 0x02C)); // 0x2C MaxDefaultSelectCardLength  ( ModelPrimitiveType int int int Int32 )
            value.AddHandCountMaxOnDraw                     = GetInt32(new IntPtr(p + 0x030)); // 0x30 AddHandCountMaxOnDraw       ( ModelPrimitiveType int int int Int32 )
            value.RandomoModel                              = GetObject<IngameRandomModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.IngameRandomModel.FromPointer); // 0x38 RandomoModel                ( ModelClassType IngameRandomModel IngameRandomModel IngameRandomModel Pointer )
            value.AllCardList                               = GetObjectList<IngamePCardModel>(new IntPtr(p + 0x048), ReversePrism.DataModels.IngamePCardModel.FromPointer); // 0x48 AllCardList                 ( ModelClassListType List`1<IngamePCardModel> List`1<IngamePCardModel> List<IngamePCardModel> Pointer )
            value.DeckDataList                              = GetObjectList<IngamePCardModel>(new IntPtr(p + 0x050), ReversePrism.DataModels.IngamePCardModel.FromPointer); // 0x50 DeckDataList                ( ModelClassListType List`1<IngamePCardModel> List`1<IngamePCardModel> List<IngamePCardModel> Pointer )
            value.HandList                                  = GetObjectList<IngamePCardModel>(new IntPtr(p + 0x058), ReversePrism.DataModels.IngamePCardModel.FromPointer); // 0x58 HandList                    ( ModelClassListType List`1<IngamePCardModel> List`1<IngamePCardModel> List<IngamePCardModel> Pointer )
            value.Graveyard                                 = GetObjectList<IngamePCardModel>(new IntPtr(p + 0x060), ReversePrism.DataModels.IngamePCardModel.FromPointer); // 0x60 Graveyard                   ( ModelClassListType List`1<IngamePCardModel> List`1<IngamePCardModel> List<IngamePCardModel> Pointer )
            value.CopyCardList                              = GetObjectList<IngamePCardModel>(new IntPtr(p + 0x068), ReversePrism.DataModels.IngamePCardModel.FromPointer); // 0x68 CopyCardList                ( ModelClassListType List`1<IngamePCardModel> List`1<IngamePCardModel> List<IngamePCardModel> Pointer )
            value.ExclusionCards                            = GetObjectList<IngamePCardModel>(new IntPtr(p + 0x070), ReversePrism.DataModels.IngamePCardModel.FromPointer); // 0x70 ExclusionCards              ( ModelClassListType List`1<IngamePCardModel> List`1<IngamePCardModel> List<IngamePCardModel> Pointer )
            value.ExceptHandAndGraveyards                   = GetObjectList<IngamePCardModel>(new IntPtr(p + 0x078), ReversePrism.DataModels.IngamePCardModel.FromPointer); // 0x78 ExceptHandAndGraveyards     ( ModelClassListType List`1<IngamePCardModel> List`1<IngamePCardModel> List<IngamePCardModel> Pointer )
            value.InitialDeckCount                          = GetInt32(new IntPtr(p + 0x0A8)); // 0xA8 InitialDeckCount            ( ModelPrimitiveType int int int Int32 )
            value.TotalUseCardCount                         = GetInt32(new IntPtr(p + 0x0AC)); // 0xAC TotalUseCardCount           ( ModelPrimitiveType int int int Int32 )
            value.ReleaseHandIndexes                        = GetInt32List(new IntPtr(p + 0x0B0)); // 0xB0 ReleaseHandIndexes          ( ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.RemoveList                                = GetObjectList<IngamePCardModel>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.IngamePCardModel.FromPointer); // 0xB8 RemoveList                  ( ModelClassListType List`1<IngamePCardModel> List`1<IngamePCardModel> List<IngamePCardModel> Pointer )

            return value;
        }
    }
}
