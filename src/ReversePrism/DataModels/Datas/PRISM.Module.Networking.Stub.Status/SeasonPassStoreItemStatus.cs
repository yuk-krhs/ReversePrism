using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<SeasonPassStoreItemStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstSeasonMissionIdFieldNumber            int IL2CPP_TYPE_I4
    // 018 MstSeasonMissionId                       ModelPrimitiveType int int int Int32
    // 000 SeasonPeriodFieldNumber                  int IL2CPP_TYPE_I4
    // 020 SeasonPeriod                             ModelClassType PeriodStatus PeriodStatus PeriodStatus Pointer
    // 000 StoreItemFieldNumber                     int IL2CPP_TYPE_I4
    // 028 StoreItem                                ModelClassType StoreItemStatus StoreItemStatus StoreItemStatus Pointer
    // 000 SeasonMissionPlayablePeriodFieldNumber   int IL2CPP_TYPE_I4
    // 030 SeasonMissionPlayablePeriod              ModelClassType PeriodStatus PeriodStatus PeriodStatus Pointer
    public partial class SeasonPassStoreItemStatus : DataModel
    {
        public int                                      MstSeasonMissionId                      { get; set; }
        public PeriodStatus?                            SeasonPeriod                            { get; set; }
        public StoreItemStatus?                         StoreItem                               { get; set; }
        public PeriodStatus?                            SeasonMissionPlayablePeriod             { get; set; }

        public static SeasonPassStoreItemStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SeasonPassStoreItemStatus() { Pointer= p0 };

            value.MstSeasonMissionId                        = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstSeasonMissionId          ( ModelPrimitiveType int int int Int32 )
            value.SeasonPeriod                              = GetObject<PeriodStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.PeriodStatus.FromPointer); // 0x20 SeasonPeriod                ( ModelClassType PeriodStatus PeriodStatus PeriodStatus Pointer )
            value.StoreItem                                 = GetObject<StoreItemStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.StoreItemStatus.FromPointer); // 0x28 StoreItem                   ( ModelClassType StoreItemStatus StoreItemStatus StoreItemStatus Pointer )
            value.SeasonMissionPlayablePeriod               = GetObject<PeriodStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.PeriodStatus.FromPointer); // 0x30 SeasonMissionPlayablePeriod ( ModelClassType PeriodStatus PeriodStatus PeriodStatus Pointer )

            return value;
        }
    }
}
