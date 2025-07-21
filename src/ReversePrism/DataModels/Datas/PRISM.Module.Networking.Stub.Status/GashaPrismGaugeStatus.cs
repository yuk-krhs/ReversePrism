using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EndDate                                  ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<GashaPrismGaugeStatus> IL2CPP_TYPE_GENERICINST
    // 020 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 PrismGaugeIdFieldNumber                  int IL2CPP_TYPE_I4
    // 028 PrismGaugeId                             ModelPrimitiveType string string string String
    // 000 PointFieldNumber                         int IL2CPP_TYPE_I4
    // 030 Point                                    ModelPrimitiveType int int int Int32
    // 000 RewardListFieldNumber                    int IL2CPP_TYPE_I4
    // 008 _repeated_rewardList_codec               FieldCodec`1<GashaPrismGaugeRewardStatus> IL2CPP_TYPE_GENERICINST
    // 038 RewardList                               ModelClassListType RepeatedField`1<GashaPrismGaugeRewardStatus> RepeatedField`1<GashaPrismGaugeRewardStatus> List<GashaPrismGaugeRewardStatus> Pointer
    // 000 EndDateFieldNumber                       int IL2CPP_TYPE_I4
    // 040 _EndDate                                 ModelClassType Timestamp Timestamp Timestamp Pointer
    public partial class GashaPrismGaugeStatus : DataModel
    {
        public DateTime                                 EndDate                                 { get; set; }
        public string                                   PrismGaugeId                            { get; set; }
        public int                                      Point                                   { get; set; }
        public List<GashaPrismGaugeRewardStatus>?       RewardList                              { get; set; }
        public Timestamp?                               _EndDate                                { get; set; }

        public static GashaPrismGaugeStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaPrismGaugeStatus() { Pointer= p0 };

            value.EndDate                                   = GetDateTime(new IntPtr(p + 0x010)); // 0x10 EndDate                     ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.PrismGaugeId                              = GetString(new IntPtr(p + 0x028)); // 0x28 PrismGaugeId                ( ModelPrimitiveType string string string String )
            value.Point                                     = GetInt32(new IntPtr(p + 0x030)); // 0x30 Point                       ( ModelPrimitiveType int int int Int32 )
            value.RewardList                                = GetObjectList<GashaPrismGaugeRewardStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.GashaPrismGaugeRewardStatus.FromPointer); // 0x38 RewardList                  ( ModelClassListType RepeatedField`1<GashaPrismGaugeRewardStatus> RepeatedField`1<GashaPrismGaugeRewardStatus> List<GashaPrismGaugeRewardStatus> Pointer )
            value._EndDate                                  = GetObject<Timestamp>(new IntPtr(p + 0x040), ReversePrism.DataModels.Timestamp.FromPointer); // 0x40 _EndDate                    ( ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.EndDate                       = ToDateTime(value._EndDate);

            return value;
        }
    }
}
