using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Point                                    0001865F4260 ModelPrimitiveType int int int Int32
    // 014 PreviousGaugePoint                       0001865F4260 ModelPrimitiveType int int int Int32
    // 018 RewardList                               000185D03318 ModelClassListType IReadOnlyList`1<IMissionGaugeRewardStatus> IReadOnlyList`1<IMissionGaugeRewardStatus> List<IMissionGaugeRewardStatus> Pointer
    // 020 PreviousRate                             000186666CB0 ModelPrimitiveType float float float Single
    // 024 AfterRate                                000186666CB0 ModelPrimitiveType float float float Single
    // 028 IsAllReceived                            0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 029 IsClear                                  0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 02C GetGaugeMax                              0001865F4260 ModelPrimitiveType int int int Int32
    public partial class MissionListGaugeViewModel : DataModel
    {
        public int                                      Point                                   { get; set; }
        public int                                      PreviousGaugePoint                      { get; set; }
        public List<IMissionGaugeRewardStatus>?         RewardList                              { get; set; }
        public float                                    PreviousRate                            { get; set; }
        public float                                    AfterRate                               { get; set; }
        public bool                                     IsAllReceived                           { get; set; }
        public bool                                     IsClear                                 { get; set; }
        public int                                      GetGaugeMax                             { get; set; }

        public static MissionListGaugeViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MissionListGaugeViewModel() { Pointer= p0 };

            value.Point                                     = GetInt32(new IntPtr(p + 0x010)); // 0246655C9000 0x10 Point                       ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.PreviousGaugePoint                        = GetInt32(new IntPtr(p + 0x014)); // 0246655C9020 0x14 PreviousGaugePoint          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.RewardList                                = GetObjectList<IMissionGaugeRewardStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IMissionGaugeRewardStatus.FromPointer); // 0246655C9040 0x18 RewardList                  ( 000185D03318 ModelClassListType IReadOnlyList`1<IMissionGaugeRewardStatus> IReadOnlyList`1<IMissionGaugeRewardStatus> List<IMissionGaugeRewardStatus> Pointer )
            value.PreviousRate                              = GetSingle(new IntPtr(p + 0x020)); // 0246655C9060 0x20 PreviousRate                ( 000186666CB0 ModelPrimitiveType float float float Single )
            value.AfterRate                                 = GetSingle(new IntPtr(p + 0x024)); // 0246655C9080 0x24 AfterRate                   ( 000186666CB0 ModelPrimitiveType float float float Single )
            value.IsAllReceived                             = GetBool(new IntPtr(p + 0x028)); // 0246655C90A0 0x28 IsAllReceived               ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.IsClear                                   = GetBool(new IntPtr(p + 0x029)); // 0246655C90C0 0x29 IsClear                     ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.GetGaugeMax                               = GetInt32(new IntPtr(p + 0x02C)); // 0246655C90E0 0x2C GetGaugeMax                 ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
