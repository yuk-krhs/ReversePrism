using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MissionGroupMaster                       ModelClassType MstMissionGroup MstMissionGroup MstMissionGroup Pointer
    // 018 MissionGroup                             ModelClassListType List`1<MissionGroup> List`1<MissionGroup> List<MissionGroup> Pointer
    // 020 IMissionController                       ModelClassType IMissionController IMissionController IMissionController Pointer
    // 028 previousGaugePoint                       Dictionary`2<int, int> IL2CPP_TYPE_GENERICINST
    // 030 SortFilterModel                          ModelClassType MissionSortFilterModel MissionSortFilterModel MissionSortFilterModel Pointer
    // 038 SaveData                                 ModelClassType MissionFilterSaveData MissionFilterSaveData MissionFilterSaveData Pointer
    // 040 NoneFilterMissionGroupTypeList           ModelEnumListType List`1<MissionGroupType> List`1<MissionGroupType> List<MissionGroupType> Pointer
    public partial class MissionModel : DataModel
    {
        public MstMissionGroup?                         MissionGroupMaster                      { get; set; }
        public List<MissionGroup>?                      MissionGroup                            { get; set; }
        public IMissionController?                      IMissionController                      { get; set; }
        public MissionSortFilterModel?                  SortFilterModel                         { get; set; }
        public MissionFilterSaveData?                   SaveData                                { get; set; }
        public List<MissionGroupType>?                  NoneFilterMissionGroupTypeList          { get; set; }

        public static MissionModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MissionModel() { Pointer= p0 };

            value.MissionGroupMaster                        = GetObject<MstMissionGroup>(new IntPtr(p + 0x010), ReversePrism.DataModels.MstMissionGroup.FromPointer); // 0x10 MissionGroupMaster          ( ModelClassType MstMissionGroup MstMissionGroup MstMissionGroup Pointer )
            value.MissionGroup                              = GetObjectList<MissionGroup>(new IntPtr(p + 0x018), ReversePrism.DataModels.MissionGroup.FromPointer); // 0x18 MissionGroup                ( ModelClassListType List`1<MissionGroup> List`1<MissionGroup> List<MissionGroup> Pointer )
            value.IMissionController                        = GetObject<IMissionController>(new IntPtr(p + 0x020), ReversePrism.DataModels.IMissionController.FromPointer); // 0x20 IMissionController          ( ModelClassType IMissionController IMissionController IMissionController Pointer )
            value.SortFilterModel                           = GetObject<MissionSortFilterModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.MissionSortFilterModel.FromPointer); // 0x30 SortFilterModel             ( ModelClassType MissionSortFilterModel MissionSortFilterModel MissionSortFilterModel Pointer )
            value.SaveData                                  = GetObject<MissionFilterSaveData>(new IntPtr(p + 0x038), ReversePrism.DataModels.MissionFilterSaveData.FromPointer); // 0x38 SaveData                    ( ModelClassType MissionFilterSaveData MissionFilterSaveData MissionFilterSaveData Pointer )
            value.NoneFilterMissionGroupTypeList            = GetEnumList<MissionGroupType>(new IntPtr(p + 0x040)); // 0x40 NoneFilterMissionGroupTypeList ( ModelEnumListType List`1<MissionGroupType> List`1<MissionGroupType> List<MissionGroupType> Pointer )

            return value;
        }
    }
}
