using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 TitleTextFormat                          string IL2CPP_TYPE_STRING
    // 010 LocalSaveData                            ModelClassType ProducePreparationEpisodeSelectSaveData ProducePreparationEpisodeSelectSaveData ProducePreparationEpisodeSelectSaveData Pointer
    // 018 UnitEpisodeModels                        ModelClassListType ProducePreparationEpisodeSelectUnitEpisodeModel[] ProducePreparationEpisodeSelectUnitEpisodeModel[] List<ProducePreparationEpisodeSelectUnitEpisodeModel> Pointer
    // 020 Reply                                    ModelClassType IGetEpisodeListReply IGetEpisodeListReply IGetEpisodeListReply Pointer
    // 028 releasedDifficultyDic                    Dictionary`2<string, ProduceDifficultyType> IL2CPP_TYPE_GENERICINST
    // 030 TutorialEpisode                          ModelClassType IEpisodeStatus IEpisodeStatus IEpisodeStatus Pointer
    // 038 CurrentUnitId                            ModelPrimitiveType int int int Int32
    // 03C CurrentEpisodeId                         ModelPrimitiveType int int int Int32
    // 040 CurrentDifficulty                        ModelEnumType ProduceDifficultyType ProduceDifficultyType ProduceDifficultyType Int32
    // 044 CurrentEpisodeIndex                      ModelPrimitiveType int int int Int32
    // 048 CurrentDifficultyIndex                   ModelPrimitiveType int int int Int32
    public partial class ViewProducePreparationEpisodeSelectModel : DataModel
    {
        public ProducePreparationEpisodeSelectSaveData? LocalSaveData                           { get; set; }
        public List<ProducePreparationEpisodeSelectUnitEpisodeModel>? UnitEpisodeModels                       { get; set; }
        public IGetEpisodeListReply?                    Reply                                   { get; set; }
        public IEpisodeStatus?                          TutorialEpisode                         { get; set; }
        public int                                      CurrentUnitId                           { get; set; }
        public int                                      CurrentEpisodeId                        { get; set; }
        public ProduceDifficultyType                    CurrentDifficulty                       { get; set; }
        public int                                      CurrentEpisodeIndex                     { get; set; }
        public int                                      CurrentDifficultyIndex                  { get; set; }

        public static ViewProducePreparationEpisodeSelectModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ViewProducePreparationEpisodeSelectModel() { Pointer= p0 };

            value.LocalSaveData                             = GetObject<ProducePreparationEpisodeSelectSaveData>(new IntPtr(p + 0x010), ReversePrism.DataModels.ProducePreparationEpisodeSelectSaveData.FromPointer); // 0x10 LocalSaveData               ( ModelClassType ProducePreparationEpisodeSelectSaveData ProducePreparationEpisodeSelectSaveData ProducePreparationEpisodeSelectSaveData Pointer )
            value.UnitEpisodeModels                         = GetObjectList<ProducePreparationEpisodeSelectUnitEpisodeModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProducePreparationEpisodeSelectUnitEpisodeModel.FromPointer); // 0x18 UnitEpisodeModels           ( ModelClassListType ProducePreparationEpisodeSelectUnitEpisodeModel[] ProducePreparationEpisodeSelectUnitEpisodeModel[] List<ProducePreparationEpisodeSelectUnitEpisodeModel> Pointer )
            value.Reply                                     = GetObject<IGetEpisodeListReply>(new IntPtr(p + 0x020), ReversePrism.DataModels.IGetEpisodeListReply.FromPointer); // 0x20 Reply                       ( ModelClassType IGetEpisodeListReply IGetEpisodeListReply IGetEpisodeListReply Pointer )
            value.TutorialEpisode                           = GetObject<IEpisodeStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.IEpisodeStatus.FromPointer); // 0x30 TutorialEpisode             ( ModelClassType IEpisodeStatus IEpisodeStatus IEpisodeStatus Pointer )
            value.CurrentUnitId                             = GetInt32(new IntPtr(p + 0x038)); // 0x38 CurrentUnitId               ( ModelPrimitiveType int int int Int32 )
            value.CurrentEpisodeId                          = GetInt32(new IntPtr(p + 0x03C)); // 0x3C CurrentEpisodeId            ( ModelPrimitiveType int int int Int32 )
            value.CurrentDifficulty                         = (ProduceDifficultyType)GetInt32(new IntPtr(p + 0x040)); // 0x40 CurrentDifficulty           ( ModelEnumType ProduceDifficultyType ProduceDifficultyType ProduceDifficultyType Int32 )
            value.CurrentEpisodeIndex                       = GetInt32(new IntPtr(p + 0x044)); // 0x44 CurrentEpisodeIndex         ( ModelPrimitiveType int int int Int32 )
            value.CurrentDifficultyIndex                    = GetInt32(new IntPtr(p + 0x048)); // 0x48 CurrentDifficultyIndex      ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
