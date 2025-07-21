using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AiPatternDataScriptableObject            ModelClassType AiPatternDataScriptableObject AiPatternDataScriptableObject AiPatternDataScriptableObject Pointer
    // 018 ProduceAutoSettingModel                  ModelClassType ProduceAutoSettingModel ProduceAutoSettingModel ProduceAutoSettingModel Pointer
    // 020 SelectScoreList                          ModelEnumListType List`1<ScoreData> List`1<ScoreData> List<ScoreData> Pointer
    // 028 SelectCardList                           ModelClassListType List`1<AutoModePCardModel> List`1<AutoModePCardModel> List<AutoModePCardModel> Pointer
    // 030 Random                                   ModelClassType Random Random Random Pointer
    // 038 LowCostRate                              ModelPrimitiveListType float[] float[] List<float> Pointer
    // 040 MiddleCostRate                           ModelPrimitiveListType float[] float[] List<float> Pointer
    // 048 HighCostRate                             ModelPrimitiveListType float[] float[] List<float> Pointer
    // 050 BalanceCostRate                          ModelPrimitiveListType float[] float[] List<float> Pointer
    // 000 ScoreBorderline                          int IL2CPP_TYPE_I4
    // 000 DeleteBorcerLine                         int IL2CPP_TYPE_I4
    // 058 UnitId                                   ModelPrimitiveType int int int Int32
    // 060 DeckList                                 ModelClassListType List`1<AutoModePCardModel> List`1<AutoModePCardModel> List<AutoModePCardModel> Pointer
    // 068 CardList                                 ModelClassListType List`1<AutoModePCardModel> List`1<AutoModePCardModel> List<AutoModePCardModel> Pointer
    // 070 RankUpSelectList                         ModelClassListType List`1<AutoModePCardModel> List`1<AutoModePCardModel> List<AutoModePCardModel> Pointer
    // 078 DeleteCardNum                            ModelPrimitiveType int int int Int32
    public partial class CardSeceltModel : DataModel
    {
        public AiPatternDataScriptableObject?           AiPatternDataScriptableObject           { get; set; }
        public ProduceAutoSettingModel?                 ProduceAutoSettingModel                 { get; set; }
        public List<ScoreData>?                         SelectScoreList                         { get; set; }
        public List<AutoModePCardModel>?                SelectCardList                          { get; set; }
        public Random?                                  Random                                  { get; set; }
        public List<float>?                             LowCostRate                             { get; set; }
        public List<float>?                             MiddleCostRate                          { get; set; }
        public List<float>?                             HighCostRate                            { get; set; }
        public List<float>?                             BalanceCostRate                         { get; set; }
        public int                                      UnitId                                  { get; set; }
        public List<AutoModePCardModel>?                DeckList                                { get; set; }
        public List<AutoModePCardModel>?                CardList                                { get; set; }
        public List<AutoModePCardModel>?                RankUpSelectList                        { get; set; }
        public int                                      DeleteCardNum                           { get; set; }

        public static CardSeceltModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CardSeceltModel() { Pointer= p0 };

            value.AiPatternDataScriptableObject             = GetObject<AiPatternDataScriptableObject>(new IntPtr(p + 0x010), ReversePrism.DataModels.AiPatternDataScriptableObject.FromPointer); // 0x10 AiPatternDataScriptableObject ( ModelClassType AiPatternDataScriptableObject AiPatternDataScriptableObject AiPatternDataScriptableObject Pointer )
            value.ProduceAutoSettingModel                   = GetObject<ProduceAutoSettingModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceAutoSettingModel.FromPointer); // 0x18 ProduceAutoSettingModel     ( ModelClassType ProduceAutoSettingModel ProduceAutoSettingModel ProduceAutoSettingModel Pointer )
            value.SelectScoreList                           = GetEnumList<ScoreData>(new IntPtr(p + 0x020)); // 0x20 SelectScoreList             ( ModelEnumListType List`1<ScoreData> List`1<ScoreData> List<ScoreData> Pointer )
            value.SelectCardList                            = GetObjectList<AutoModePCardModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.AutoModePCardModel.FromPointer); // 0x28 SelectCardList              ( ModelClassListType List`1<AutoModePCardModel> List`1<AutoModePCardModel> List<AutoModePCardModel> Pointer )
            value.Random                                    = GetObject<Random>(new IntPtr(p + 0x030), ReversePrism.DataModels.Random.FromPointer); // 0x30 Random                      ( ModelClassType Random Random Random Pointer )
            value.LowCostRate                               = GetSingleList(new IntPtr(p + 0x038)); // 0x38 LowCostRate                 ( ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.MiddleCostRate                            = GetSingleList(new IntPtr(p + 0x040)); // 0x40 MiddleCostRate              ( ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.HighCostRate                              = GetSingleList(new IntPtr(p + 0x048)); // 0x48 HighCostRate                ( ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.BalanceCostRate                           = GetSingleList(new IntPtr(p + 0x050)); // 0x50 BalanceCostRate             ( ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.UnitId                                    = GetInt32(new IntPtr(p + 0x058)); // 0x58 UnitId                      ( ModelPrimitiveType int int int Int32 )
            value.DeckList                                  = GetObjectList<AutoModePCardModel>(new IntPtr(p + 0x060), ReversePrism.DataModels.AutoModePCardModel.FromPointer); // 0x60 DeckList                    ( ModelClassListType List`1<AutoModePCardModel> List`1<AutoModePCardModel> List<AutoModePCardModel> Pointer )
            value.CardList                                  = GetObjectList<AutoModePCardModel>(new IntPtr(p + 0x068), ReversePrism.DataModels.AutoModePCardModel.FromPointer); // 0x68 CardList                    ( ModelClassListType List`1<AutoModePCardModel> List`1<AutoModePCardModel> List<AutoModePCardModel> Pointer )
            value.RankUpSelectList                          = GetObjectList<AutoModePCardModel>(new IntPtr(p + 0x070), ReversePrism.DataModels.AutoModePCardModel.FromPointer); // 0x70 RankUpSelectList            ( ModelClassListType List`1<AutoModePCardModel> List`1<AutoModePCardModel> List<AutoModePCardModel> Pointer )
            value.DeleteCardNum                             = GetInt32(new IntPtr(p + 0x078)); // 0x78 DeleteCardNum               ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
