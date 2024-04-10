using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 InfoReply                                0001865482D0 ModelClassType IGetProducerInfoReply IGetProducerInfoReply IGetProducerInfoReply Pointer
    // 018 FirstWorkDateTime                        0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 020 StoryReadTotalCount                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 024 StoryMainReadCount                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 StoryIdolReadCount                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 02C LiveClearTotalCount                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 030 LiveClearCounts                          000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 038 FullComboTotalCount                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 040 FullComboCounts                          000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 048 GrateTotalCount                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 050 GrateCounts                              000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 058 PerfectTotalCount                        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 060 PerfectCounts                            000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 068 ProduceFinishTotalCount                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 070 ProduceFinishCounts                      000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 078 FesUnitRankTotalCount                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 080 FesUnitRanks                             000185B8A350 ModelClassListType IUserProfileProduceTotalParameterRankStatus[] IUserProfileProduceTotalParameterRankStatus[] List<IUserProfileProduceTotalParameterRankStatus> Pointer
    // 088 ProduceCardSummaryViewModels             000185B9E990 ModelClassListType ProfileProduceCardSummaryViewModel[] ProfileProduceCardSummaryViewModel[] List<ProfileProduceCardSummaryViewModel> Pointer
    // 090 EventArchiveViewModels                   000185B9E5E0 ModelClassListType ProfileEventArchiveViewModel[] ProfileEventArchiveViewModel[] List<ProfileEventArchiveViewModel> Pointer
    // 098 SeasonArchiveViewModels                  000185B9EF80 ModelClassListType ProfileSeasonArchiveViewModel[] ProfileSeasonArchiveViewModel[] List<ProfileSeasonArchiveViewModel> Pointer
    public partial class ProfileHistoryPanelViewModel : DataModel
    {
        public IGetProducerInfoReply?                   InfoReply                               { get; set; }
        public DateTime                                 FirstWorkDateTime                       { get; set; }
        public int                                      StoryReadTotalCount                     { get; set; }
        public int                                      StoryMainReadCount                      { get; set; }
        public int                                      StoryIdolReadCount                      { get; set; }
        public int                                      LiveClearTotalCount                     { get; set; }
        public List<int>?                               LiveClearCounts                         { get; set; }
        public int                                      FullComboTotalCount                     { get; set; }
        public List<int>?                               FullComboCounts                         { get; set; }
        public int                                      GrateTotalCount                         { get; set; }
        public List<int>?                               GrateCounts                             { get; set; }
        public int                                      PerfectTotalCount                       { get; set; }
        public List<int>?                               PerfectCounts                           { get; set; }
        public int                                      ProduceFinishTotalCount                 { get; set; }
        public List<int>?                               ProduceFinishCounts                     { get; set; }
        public int                                      FesUnitRankTotalCount                   { get; set; }
        public List<IUserProfileProduceTotalParameterRankStatus>? FesUnitRanks                            { get; set; }
        public List<ProfileProduceCardSummaryViewModel>? ProduceCardSummaryViewModels            { get; set; }
        public List<ProfileEventArchiveViewModel>?      EventArchiveViewModels                  { get; set; }
        public List<ProfileSeasonArchiveViewModel>?     SeasonArchiveViewModels                 { get; set; }

        public static ProfileHistoryPanelViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileHistoryPanelViewModel() { Pointer= p0 };

            value.InfoReply                                 = GetObject<IGetProducerInfoReply>(new IntPtr(p + 0x010), ReversePrism.DataModels.IGetProducerInfoReply.FromPointer); // 0246666D92D8 0x10 InfoReply                   ( 0001865482D0 ModelClassType IGetProducerInfoReply IGetProducerInfoReply IGetProducerInfoReply Pointer )
            value.FirstWorkDateTime                         = GetDateTime(new IntPtr(p + 0x018)); // 0246666D92F8 0x18 FirstWorkDateTime           ( 0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.StoryReadTotalCount                       = GetInt32(new IntPtr(p + 0x020)); // 0246666D9318 0x20 StoryReadTotalCount         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.StoryMainReadCount                        = GetInt32(new IntPtr(p + 0x024)); // 0246666D9338 0x24 StoryMainReadCount          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.StoryIdolReadCount                        = GetInt32(new IntPtr(p + 0x028)); // 0246666D9358 0x28 StoryIdolReadCount          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.LiveClearTotalCount                       = GetInt32(new IntPtr(p + 0x02C)); // 0246666D9378 0x2C LiveClearTotalCount         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.LiveClearCounts                           = GetInt32List(new IntPtr(p + 0x030)); // 0246666D9398 0x30 LiveClearCounts             ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.FullComboTotalCount                       = GetInt32(new IntPtr(p + 0x038)); // 0246666D93B8 0x38 FullComboTotalCount         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.FullComboCounts                           = GetInt32List(new IntPtr(p + 0x040)); // 0246666D93D8 0x40 FullComboCounts             ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.GrateTotalCount                           = GetInt32(new IntPtr(p + 0x048)); // 0246666D93F8 0x48 GrateTotalCount             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.GrateCounts                               = GetInt32List(new IntPtr(p + 0x050)); // 0246666D9418 0x50 GrateCounts                 ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.PerfectTotalCount                         = GetInt32(new IntPtr(p + 0x058)); // 0246666D9438 0x58 PerfectTotalCount           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.PerfectCounts                             = GetInt32List(new IntPtr(p + 0x060)); // 0246666D9458 0x60 PerfectCounts               ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.ProduceFinishTotalCount                   = GetInt32(new IntPtr(p + 0x068)); // 0246666D9478 0x68 ProduceFinishTotalCount     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ProduceFinishCounts                       = GetInt32List(new IntPtr(p + 0x070)); // 0246666D9498 0x70 ProduceFinishCounts         ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.FesUnitRankTotalCount                     = GetInt32(new IntPtr(p + 0x078)); // 0246666D94B8 0x78 FesUnitRankTotalCount       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.FesUnitRanks                              = GetObjectList<IUserProfileProduceTotalParameterRankStatus>(new IntPtr(p + 0x080), ReversePrism.DataModels.IUserProfileProduceTotalParameterRankStatus.FromPointer); // 0246666D94D8 0x80 FesUnitRanks                ( 000185B8A350 ModelClassListType IUserProfileProduceTotalParameterRankStatus[] IUserProfileProduceTotalParameterRankStatus[] List<IUserProfileProduceTotalParameterRankStatus> Pointer )
            value.ProduceCardSummaryViewModels              = GetObjectList<ProfileProduceCardSummaryViewModel>(new IntPtr(p + 0x088), ReversePrism.DataModels.ProfileProduceCardSummaryViewModel.FromPointer); // 0246666D94F8 0x88 ProduceCardSummaryViewModels ( 000185B9E990 ModelClassListType ProfileProduceCardSummaryViewModel[] ProfileProduceCardSummaryViewModel[] List<ProfileProduceCardSummaryViewModel> Pointer )
            value.EventArchiveViewModels                    = GetObjectList<ProfileEventArchiveViewModel>(new IntPtr(p + 0x090), ReversePrism.DataModels.ProfileEventArchiveViewModel.FromPointer); // 0246666D9518 0x90 EventArchiveViewModels      ( 000185B9E5E0 ModelClassListType ProfileEventArchiveViewModel[] ProfileEventArchiveViewModel[] List<ProfileEventArchiveViewModel> Pointer )
            value.SeasonArchiveViewModels                   = GetObjectList<ProfileSeasonArchiveViewModel>(new IntPtr(p + 0x098), ReversePrism.DataModels.ProfileSeasonArchiveViewModel.FromPointer); // 0246666D9538 0x98 SeasonArchiveViewModels     ( 000185B9EF80 ModelClassListType ProfileSeasonArchiveViewModel[] ProfileSeasonArchiveViewModel[] List<ProfileSeasonArchiveViewModel> Pointer )

            return value;
        }
    }
}
