using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MissionGroup                             000185CF3A38 ModelClassListType List`1<MissionGroup> List`1<MissionGroup> List<MissionGroup> Pointer
    // 018 IMissionController                       0001865B40C0 ModelClassType IMissionController IMissionController IMissionController Pointer
    // 020 previousGaugePoint                       Dictionary`2<int, int> IL2CPP_TYPE_GENERICINST
    // 028 SortFilterModel                          000186629770 ModelClassType MissionSortFilterModel MissionSortFilterModel MissionSortFilterModel Pointer
    // 030 SaveData                                 000186620D80 ModelClassType MissionFilterSaveData MissionFilterSaveData MissionFilterSaveData Pointer
    // 038 NoneFilterMissionGroupTypeList           000185D22928 ModelEnumListType List`1<MissionGroupType> List`1<MissionGroupType> List<MissionGroupType> Pointer
    public partial class MissionModel : DataModel
    {
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

            value.MissionGroup                              = GetObjectList<MissionGroup>(new IntPtr(p + 0x010), ReversePrism.DataModels.MissionGroup.FromPointer); // 0246655CB2C8 0x10 MissionGroup                ( 000185CF3A38 ModelClassListType List`1<MissionGroup> List`1<MissionGroup> List<MissionGroup> Pointer )
            value.IMissionController                        = GetObject<IMissionController>(new IntPtr(p + 0x018), ReversePrism.DataModels.IMissionController.FromPointer); // 0246655CB2E8 0x18 IMissionController          ( 0001865B40C0 ModelClassType IMissionController IMissionController IMissionController Pointer )
            value.SortFilterModel                           = GetObject<MissionSortFilterModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.MissionSortFilterModel.FromPointer); // 0246655CB328 0x28 SortFilterModel             ( 000186629770 ModelClassType MissionSortFilterModel MissionSortFilterModel MissionSortFilterModel Pointer )
            value.SaveData                                  = GetObject<MissionFilterSaveData>(new IntPtr(p + 0x030), ReversePrism.DataModels.MissionFilterSaveData.FromPointer); // 0246655CB348 0x30 SaveData                    ( 000186620D80 ModelClassType MissionFilterSaveData MissionFilterSaveData MissionFilterSaveData Pointer )
            value.NoneFilterMissionGroupTypeList            = GetEnumList<MissionGroupType>(new IntPtr(p + 0x038)); // 0246655CB368 0x38 NoneFilterMissionGroupTypeList ( 000185D22928 ModelEnumListType List`1<MissionGroupType> List`1<MissionGroupType> List<MissionGroupType> Pointer )

            return value;
        }
    }
}
