using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 InfoReply                                ModelClassType IGetProducerInfoReply IGetProducerInfoReply IGetProducerInfoReply Pointer
    // 018 FirstWorkDateTime                        ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 020 StoryReadTotalCount                      ModelPrimitiveType int int int Int32
    // 024 StoryMainReadCount                       ModelPrimitiveType int int int Int32
    // 028 StoryIdolReadCount                       ModelPrimitiveType int int int Int32
    // 02C IsShinyEnabled                           ModelPrimitiveType bool bool bool Bool
    // 030 ProduceFinishTotalCount                  ModelPrimitiveType int int int Int32
    // 038 ProduceFinishCounts                      ModelPrimitiveListType int[] int[] List<int> Pointer
    // 040 FesUnitRankTotalCount                    ModelPrimitiveType int int int Int32
    // 048 FesUnitRanks                             ModelClassListType IUserProfileProduceTotalParameterRankStatus[] IUserProfileProduceTotalParameterRankStatus[] List<IUserProfileProduceTotalParameterRankStatus> Pointer
    // 050 ProduceCardSummaryViewModels             ModelClassListType ProfileProduceCardSummaryViewModel[] ProfileProduceCardSummaryViewModel[] List<ProfileProduceCardSummaryViewModel> Pointer
    // 058 EventArchiveViewModels                   ModelClassListType ProfileEventArchiveViewModel[] ProfileEventArchiveViewModel[] List<ProfileEventArchiveViewModel> Pointer
    // 060 SeasonArchiveViewModels                  ModelClassListType ProfileSeasonArchiveViewModel[] ProfileSeasonArchiveViewModel[] List<ProfileSeasonArchiveViewModel> Pointer
    public partial class ProfileHistoryPanelViewModel : DataModel
    {
        public IGetProducerInfoReply?                   InfoReply                               { get; set; }
        public DateTime                                 FirstWorkDateTime                       { get; set; }
        public int                                      StoryReadTotalCount                     { get; set; }
        public int                                      StoryMainReadCount                      { get; set; }
        public int                                      StoryIdolReadCount                      { get; set; }
        public bool                                     IsShinyEnabled                          { get; set; }
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

            value.InfoReply                                 = GetObject<IGetProducerInfoReply>(new IntPtr(p + 0x010), ReversePrism.DataModels.IGetProducerInfoReply.FromPointer); // 0x10 InfoReply                   ( ModelClassType IGetProducerInfoReply IGetProducerInfoReply IGetProducerInfoReply Pointer )
            value.FirstWorkDateTime                         = GetDateTime(new IntPtr(p + 0x018)); // 0x18 FirstWorkDateTime           ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.StoryReadTotalCount                       = GetInt32(new IntPtr(p + 0x020)); // 0x20 StoryReadTotalCount         ( ModelPrimitiveType int int int Int32 )
            value.StoryMainReadCount                        = GetInt32(new IntPtr(p + 0x024)); // 0x24 StoryMainReadCount          ( ModelPrimitiveType int int int Int32 )
            value.StoryIdolReadCount                        = GetInt32(new IntPtr(p + 0x028)); // 0x28 StoryIdolReadCount          ( ModelPrimitiveType int int int Int32 )
            value.IsShinyEnabled                            = GetBool(new IntPtr(p + 0x02C)); // 0x2C IsShinyEnabled              ( ModelPrimitiveType bool bool bool Bool )
            value.ProduceFinishTotalCount                   = GetInt32(new IntPtr(p + 0x030)); // 0x30 ProduceFinishTotalCount     ( ModelPrimitiveType int int int Int32 )
            value.ProduceFinishCounts                       = GetInt32List(new IntPtr(p + 0x038)); // 0x38 ProduceFinishCounts         ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.FesUnitRankTotalCount                     = GetInt32(new IntPtr(p + 0x040)); // 0x40 FesUnitRankTotalCount       ( ModelPrimitiveType int int int Int32 )
            value.FesUnitRanks                              = GetObjectList<IUserProfileProduceTotalParameterRankStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.IUserProfileProduceTotalParameterRankStatus.FromPointer); // 0x48 FesUnitRanks                ( ModelClassListType IUserProfileProduceTotalParameterRankStatus[] IUserProfileProduceTotalParameterRankStatus[] List<IUserProfileProduceTotalParameterRankStatus> Pointer )
            value.ProduceCardSummaryViewModels              = GetObjectList<ProfileProduceCardSummaryViewModel>(new IntPtr(p + 0x050), ReversePrism.DataModels.ProfileProduceCardSummaryViewModel.FromPointer); // 0x50 ProduceCardSummaryViewModels ( ModelClassListType ProfileProduceCardSummaryViewModel[] ProfileProduceCardSummaryViewModel[] List<ProfileProduceCardSummaryViewModel> Pointer )
            value.EventArchiveViewModels                    = GetObjectList<ProfileEventArchiveViewModel>(new IntPtr(p + 0x058), ReversePrism.DataModels.ProfileEventArchiveViewModel.FromPointer); // 0x58 EventArchiveViewModels      ( ModelClassListType ProfileEventArchiveViewModel[] ProfileEventArchiveViewModel[] List<ProfileEventArchiveViewModel> Pointer )
            value.SeasonArchiveViewModels                   = GetObjectList<ProfileSeasonArchiveViewModel>(new IntPtr(p + 0x060), ReversePrism.DataModels.ProfileSeasonArchiveViewModel.FromPointer); // 0x60 SeasonArchiveViewModels     ( ModelClassListType ProfileSeasonArchiveViewModel[] ProfileSeasonArchiveViewModel[] List<ProfileSeasonArchiveViewModel> Pointer )

            return value;
        }
    }
}
