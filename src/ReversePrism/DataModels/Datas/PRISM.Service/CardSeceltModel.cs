using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AiPatternDataScriptableObject            00018669DB80 ModelClassType AiPatternDataScriptableObject AiPatternDataScriptableObject AiPatternDataScriptableObject Pointer
    // 018 ProduceAutoSettingModel                  000186530A50 ModelClassType ProduceAutoSettingModel ProduceAutoSettingModel ProduceAutoSettingModel Pointer
    // 020 SelectScoreList                          000185D20788 ModelEnumListType List`1<ScoreData> List`1<ScoreData> List<ScoreData> Pointer
    // 028 SelectCardList                           000185CCE338 ModelClassListType List`1<AutoModePCardModel> List`1<AutoModePCardModel> List<AutoModePCardModel> Pointer
    // 030 Random                                   0001866093D0 ModelClassType Random Random Random Pointer
    // 038 LowCostRate                              000185B80D30 ModelPrimitiveListType float[] float[] List<float> Pointer
    // 040 MiddleCostRate                           000185B80D30 ModelPrimitiveListType float[] float[] List<float> Pointer
    // 048 HighCostRate                             000185B80D30 ModelPrimitiveListType float[] float[] List<float> Pointer
    // 050 BalanceCostRate                          000185B80D30 ModelPrimitiveListType float[] float[] List<float> Pointer
    // 000 ScoreBorderline                          int IL2CPP_TYPE_I4
    // 000 DeleteBorcerLine                         int IL2CPP_TYPE_I4
    // 058 UnitId                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 060 DeckList                                 000185CCE338 ModelClassListType List`1<AutoModePCardModel> List`1<AutoModePCardModel> List<AutoModePCardModel> Pointer
    // 068 CardList                                 000185CCE338 ModelClassListType List`1<AutoModePCardModel> List`1<AutoModePCardModel> List<AutoModePCardModel> Pointer
    // 070 CardIdStringList                         000185D0D518 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    // 078 RankUpSelectList                         000185CCE338 ModelClassListType List`1<AutoModePCardModel> List`1<AutoModePCardModel> List<AutoModePCardModel> Pointer
    public partial class CardSeceltModel
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
        public List<string>?                            CardIdStringList                        { get; set; }
        public List<AutoModePCardModel>?                RankUpSelectList                        { get; set; }

        public static CardSeceltModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CardSeceltModel();

            value.AiPatternDataScriptableObject             = GetObject<AiPatternDataScriptableObject>(new IntPtr(p + 0x010), ReversePrism.DataModels.AiPatternDataScriptableObject.FromPointer); // 0270D64690C8 0x10 AiPatternDataScriptableObject ( 00018669DB80 ModelClassType AiPatternDataScriptableObject AiPatternDataScriptableObject AiPatternDataScriptableObject Pointer )
            value.ProduceAutoSettingModel                   = GetObject<ProduceAutoSettingModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceAutoSettingModel.FromPointer); // 0270D64690E8 0x18 ProduceAutoSettingModel     ( 000186530A50 ModelClassType ProduceAutoSettingModel ProduceAutoSettingModel ProduceAutoSettingModel Pointer )
            value.SelectScoreList                           = GetEnumList<ScoreData>(new IntPtr(p + 0x020)); // 0270D6469108 0x20 SelectScoreList             ( 000185D20788 ModelEnumListType List`1<ScoreData> List`1<ScoreData> List<ScoreData> Pointer )
            value.SelectCardList                            = GetObjectList<AutoModePCardModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.AutoModePCardModel.FromPointer); // 0270D6469128 0x28 SelectCardList              ( 000185CCE338 ModelClassListType List`1<AutoModePCardModel> List`1<AutoModePCardModel> List<AutoModePCardModel> Pointer )
            value.Random                                    = GetObject<Random>(new IntPtr(p + 0x030), ReversePrism.DataModels.Random.FromPointer); // 0270D6469148 0x30 Random                      ( 0001866093D0 ModelClassType Random Random Random Pointer )
            value.LowCostRate                               = GetSingleList(new IntPtr(p + 0x038)); // 0270D6469168 0x38 LowCostRate                 ( 000185B80D30 ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.MiddleCostRate                            = GetSingleList(new IntPtr(p + 0x040)); // 0270D6469188 0x40 MiddleCostRate              ( 000185B80D30 ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.HighCostRate                              = GetSingleList(new IntPtr(p + 0x048)); // 0270D64691A8 0x48 HighCostRate                ( 000185B80D30 ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.BalanceCostRate                           = GetSingleList(new IntPtr(p + 0x050)); // 0270D64691C8 0x50 BalanceCostRate             ( 000185B80D30 ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.UnitId                                    = GetInt32(new IntPtr(p + 0x058)); // 0270D6469228 0x58 UnitId                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.DeckList                                  = GetObjectList<AutoModePCardModel>(new IntPtr(p + 0x060), ReversePrism.DataModels.AutoModePCardModel.FromPointer); // 0270D6469248 0x60 DeckList                    ( 000185CCE338 ModelClassListType List`1<AutoModePCardModel> List`1<AutoModePCardModel> List<AutoModePCardModel> Pointer )
            value.CardList                                  = GetObjectList<AutoModePCardModel>(new IntPtr(p + 0x068), ReversePrism.DataModels.AutoModePCardModel.FromPointer); // 0270D6469268 0x68 CardList                    ( 000185CCE338 ModelClassListType List`1<AutoModePCardModel> List`1<AutoModePCardModel> List<AutoModePCardModel> Pointer )
            value.CardIdStringList                          = GetStringList(new IntPtr(p + 0x070)); // 0270D6469288 0x70 CardIdStringList            ( 000185D0D518 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )
            value.RankUpSelectList                          = GetObjectList<AutoModePCardModel>(new IntPtr(p + 0x078), ReversePrism.DataModels.AutoModePCardModel.FromPointer); // 0270D64692A8 0x78 RankUpSelectList            ( 000185CCE338 ModelClassListType List`1<AutoModePCardModel> List`1<AutoModePCardModel> List<AutoModePCardModel> Pointer )

            return value;
        }
    }
}
