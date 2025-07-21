using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EndDate                                  ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<GashaExchangeStatus> IL2CPP_TYPE_GENERICINST
    // 020 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 GashaExchangeIdFieldNumber               int IL2CPP_TYPE_I4
    // 028 GashaExchangeId                          ModelPrimitiveType string string string String
    // 000 PointFieldNumber                         int IL2CPP_TYPE_I4
    // 030 Point                                    ModelPrimitiveType int int int Int32
    // 000 EndDateFieldNumber                       int IL2CPP_TYPE_I4
    // 038 _EndDate                                 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 RewardListFieldNumber                    int IL2CPP_TYPE_I4
    // 008 _repeated_rewardList_codec               FieldCodec`1<GashaExchangeRewardStatus> IL2CPP_TYPE_GENERICINST
    // 040 RewardList                               ModelClassListType RepeatedField`1<GashaExchangeRewardStatus> RepeatedField`1<GashaExchangeRewardStatus> List<GashaExchangeRewardStatus> Pointer
    public partial class GashaExchangeStatus : DataModel
    {
        public DateTime                                 EndDate                                 { get; set; }
        public string                                   GashaExchangeId                         { get; set; }
        public int                                      Point                                   { get; set; }
        public Timestamp?                               _EndDate                                { get; set; }
        public List<GashaExchangeRewardStatus>?         RewardList                              { get; set; }

        public static GashaExchangeStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaExchangeStatus() { Pointer= p0 };

            value.EndDate                                   = GetDateTime(new IntPtr(p + 0x010)); // 0x10 EndDate                     ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.GashaExchangeId                           = GetString(new IntPtr(p + 0x028)); // 0x28 GashaExchangeId             ( ModelPrimitiveType string string string String )
            value.Point                                     = GetInt32(new IntPtr(p + 0x030)); // 0x30 Point                       ( ModelPrimitiveType int int int Int32 )
            value._EndDate                                  = GetObject<Timestamp>(new IntPtr(p + 0x038), ReversePrism.DataModels.Timestamp.FromPointer); // 0x38 _EndDate                    ( ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.RewardList                                = GetObjectList<GashaExchangeRewardStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.GashaExchangeRewardStatus.FromPointer); // 0x40 RewardList                  ( ModelClassListType RepeatedField`1<GashaExchangeRewardStatus> RepeatedField`1<GashaExchangeRewardStatus> List<GashaExchangeRewardStatus> Pointer )
            value.EndDate                       = ToDateTime(value._EndDate);

            return value;
        }
    }
}
