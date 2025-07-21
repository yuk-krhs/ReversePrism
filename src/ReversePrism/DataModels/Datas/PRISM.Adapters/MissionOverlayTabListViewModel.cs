using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 onUpdateModel                            Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 018 Status                                   ModelClassType IMissionGroupStatus IMissionGroupStatus IMissionGroupStatus Pointer
    // 020 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 028 saveData                                 SavableJsonObject`1<MissionFilterSaveData> IL2CPP_TYPE_GENERICINST
    // 030 MissionGroupMaster                       ModelClassType MstMissionGroup MstMissionGroup MstMissionGroup Pointer
    // 038 GroupId                                  ModelPrimitiveType int int int Int32
    // 03C GroupType                                ModelEnumType MissionGroupType MissionGroupType MissionGroupType Int32
    // 040 IsNew                                    ModelPrimitiveType bool bool bool Bool
    // 044 ReceivableCount                          ModelPrimitiveType int int int Int32
    // 048 GaugeViewModel                           ModelClassType MissionGaugeViewModel MissionGaugeViewModel MissionGaugeViewModel Pointer
    // 050 ListCategory                             ModelEnumType ListCategory ListCategory ListCategory Int32
    // 058 EventViewModels                          ModelClassListType MissionOverlayTabListViewModel[] MissionOverlayTabListViewModel[] List<MissionOverlayTabListViewModel> Pointer
    // 060 ListViewModels                           ModelClassListType MissionListViewModel[] MissionListViewModel[] List<MissionListViewModel> Pointer
    // 068 SortFilterModel                          ModelClassType MissionSortFilterModel MissionSortFilterModel MissionSortFilterModel Pointer
    // 070 RewardReceiveStatusViewModel             ModelClassType MissionRewardReceiveStatusViewModel MissionRewardReceiveStatusViewModel MissionRewardReceiveStatusViewModel Pointer
    // 078 CurrentEventListIndex                    ModelPrimitiveType int int int Int32
    public partial class MissionOverlayTabListViewModel : DataModel
    {
        public IMissionGroupStatus?                     Status                                  { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public MstMissionGroup?                         MissionGroupMaster                      { get; set; }
        public int                                      GroupId                                 { get; set; }
        public MissionGroupType                         GroupType                               { get; set; }
        public bool                                     IsNew                                   { get; set; }
        public int                                      ReceivableCount                         { get; set; }
        public MissionGaugeViewModel?                   GaugeViewModel                          { get; set; }
        public ListCategory                             ListCategory                            { get; set; }
        public List<MissionOverlayTabListViewModel>?    EventViewModels                         { get; set; }
        public List<MissionListViewModel>?              ListViewModels                          { get; set; }
        public MissionSortFilterModel?                  SortFilterModel                         { get; set; }
        public MissionRewardReceiveStatusViewModel?     RewardReceiveStatusViewModel            { get; set; }
        public int                                      CurrentEventListIndex                   { get; set; }

        public static MissionOverlayTabListViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MissionOverlayTabListViewModel() { Pointer= p0 };

            value.Status                                    = GetObject<IMissionGroupStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IMissionGroupStatus.FromPointer); // 0x18 Status                      ( ModelClassType IMissionGroupStatus IMissionGroupStatus IMissionGroupStatus Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x020), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x20 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.MissionGroupMaster                        = GetObject<MstMissionGroup>(new IntPtr(p + 0x030), ReversePrism.DataModels.MstMissionGroup.FromPointer); // 0x30 MissionGroupMaster          ( ModelClassType MstMissionGroup MstMissionGroup MstMissionGroup Pointer )
            value.GroupId                                   = GetInt32(new IntPtr(p + 0x038)); // 0x38 GroupId                     ( ModelPrimitiveType int int int Int32 )
            value.GroupType                                 = (MissionGroupType)GetInt32(new IntPtr(p + 0x03C)); // 0x3C GroupType                   ( ModelEnumType MissionGroupType MissionGroupType MissionGroupType Int32 )
            value.IsNew                                     = GetBool(new IntPtr(p + 0x040)); // 0x40 IsNew                       ( ModelPrimitiveType bool bool bool Bool )
            value.ReceivableCount                           = GetInt32(new IntPtr(p + 0x044)); // 0x44 ReceivableCount             ( ModelPrimitiveType int int int Int32 )
            value.GaugeViewModel                            = GetObject<MissionGaugeViewModel>(new IntPtr(p + 0x048), ReversePrism.DataModels.MissionGaugeViewModel.FromPointer); // 0x48 GaugeViewModel              ( ModelClassType MissionGaugeViewModel MissionGaugeViewModel MissionGaugeViewModel Pointer )
            value.ListCategory                              = (ListCategory)GetInt32(new IntPtr(p + 0x050)); // 0x50 ListCategory                ( ModelEnumType ListCategory ListCategory ListCategory Int32 )
            value.EventViewModels                           = GetObjectList<MissionOverlayTabListViewModel>(new IntPtr(p + 0x058), ReversePrism.DataModels.MissionOverlayTabListViewModel.FromPointer); // 0x58 EventViewModels             ( ModelClassListType MissionOverlayTabListViewModel[] MissionOverlayTabListViewModel[] List<MissionOverlayTabListViewModel> Pointer )
            value.ListViewModels                            = GetObjectList<MissionListViewModel>(new IntPtr(p + 0x060), ReversePrism.DataModels.MissionListViewModel.FromPointer); // 0x60 ListViewModels              ( ModelClassListType MissionListViewModel[] MissionListViewModel[] List<MissionListViewModel> Pointer )
            value.SortFilterModel                           = GetObject<MissionSortFilterModel>(new IntPtr(p + 0x068), ReversePrism.DataModels.MissionSortFilterModel.FromPointer); // 0x68 SortFilterModel             ( ModelClassType MissionSortFilterModel MissionSortFilterModel MissionSortFilterModel Pointer )
            value.RewardReceiveStatusViewModel              = GetObject<MissionRewardReceiveStatusViewModel>(new IntPtr(p + 0x070), ReversePrism.DataModels.MissionRewardReceiveStatusViewModel.FromPointer); // 0x70 RewardReceiveStatusViewModel ( ModelClassType MissionRewardReceiveStatusViewModel MissionRewardReceiveStatusViewModel MissionRewardReceiveStatusViewModel Pointer )
            value.CurrentEventListIndex                     = GetInt32(new IntPtr(p + 0x078)); // 0x78 CurrentEventListIndex       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
