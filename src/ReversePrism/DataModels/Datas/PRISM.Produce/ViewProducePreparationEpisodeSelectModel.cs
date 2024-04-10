using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 TitleTextFormat                          string IL2CPP_TYPE_STRING
    // 010 LocalSaveData                            00018656B100 ModelClassType ProducePreparationEpisodeSelectSaveData ProducePreparationEpisodeSelectSaveData ProducePreparationEpisodeSelectSaveData Pointer
    // 018 UnitEpisodeModels                        000185B9D730 ModelClassListType ProducePreparationEpisodeSelectUnitEpisodeModel[] ProducePreparationEpisodeSelectUnitEpisodeModel[] List<ProducePreparationEpisodeSelectUnitEpisodeModel> Pointer
    // 020 Reply                                    000186532070 ModelClassType IGetEpisodeListReply IGetEpisodeListReply IGetEpisodeListReply Pointer
    // 028 releasedDifficultyDic                    Dictionary`2<string, ProduceDifficultyType> IL2CPP_TYPE_GENERICINST
    // 030 TutorialEpisode                          0001867618B0 ModelClassType IEpisodeStatus IEpisodeStatus IEpisodeStatus Pointer
    // 038 CurrentUnitId                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 03C CurrentEpisodeId                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 040 CurrentDifficulty                        00018660BEF0 ModelEnumType ProduceDifficultyType ProduceDifficultyType ProduceDifficultyType Int32
    // 044 CurrentEpisodeIndex                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 048 CurrentDifficultyIndex                   0001865F2AF0 ModelPrimitiveType int int int Int32
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

            value.LocalSaveData                             = GetObject<ProducePreparationEpisodeSelectSaveData>(new IntPtr(p + 0x010), ReversePrism.DataModels.ProducePreparationEpisodeSelectSaveData.FromPointer); // 024664D66E80 0x10 LocalSaveData               ( 00018656B100 ModelClassType ProducePreparationEpisodeSelectSaveData ProducePreparationEpisodeSelectSaveData ProducePreparationEpisodeSelectSaveData Pointer )
            value.UnitEpisodeModels                         = GetObjectList<ProducePreparationEpisodeSelectUnitEpisodeModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProducePreparationEpisodeSelectUnitEpisodeModel.FromPointer); // 024664D66EA0 0x18 UnitEpisodeModels           ( 000185B9D730 ModelClassListType ProducePreparationEpisodeSelectUnitEpisodeModel[] ProducePreparationEpisodeSelectUnitEpisodeModel[] List<ProducePreparationEpisodeSelectUnitEpisodeModel> Pointer )
            value.Reply                                     = GetObject<IGetEpisodeListReply>(new IntPtr(p + 0x020), ReversePrism.DataModels.IGetEpisodeListReply.FromPointer); // 024664D66EC0 0x20 Reply                       ( 000186532070 ModelClassType IGetEpisodeListReply IGetEpisodeListReply IGetEpisodeListReply Pointer )
            value.TutorialEpisode                           = GetObject<IEpisodeStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.IEpisodeStatus.FromPointer); // 024664D66F00 0x30 TutorialEpisode             ( 0001867618B0 ModelClassType IEpisodeStatus IEpisodeStatus IEpisodeStatus Pointer )
            value.CurrentUnitId                             = GetInt32(new IntPtr(p + 0x038)); // 024664D66F20 0x38 CurrentUnitId               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CurrentEpisodeId                          = GetInt32(new IntPtr(p + 0x03C)); // 024664D66F40 0x3C CurrentEpisodeId            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CurrentDifficulty                         = (ProduceDifficultyType)GetInt32(new IntPtr(p + 0x040)); // 024664D66F60 0x40 CurrentDifficulty           ( 00018660BEF0 ModelEnumType ProduceDifficultyType ProduceDifficultyType ProduceDifficultyType Int32 )
            value.CurrentEpisodeIndex                       = GetInt32(new IntPtr(p + 0x044)); // 024664D66F80 0x44 CurrentEpisodeIndex         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CurrentDifficultyIndex                    = GetInt32(new IntPtr(p + 0x048)); // 024664D66FA0 0x48 CurrentDifficultyIndex      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
