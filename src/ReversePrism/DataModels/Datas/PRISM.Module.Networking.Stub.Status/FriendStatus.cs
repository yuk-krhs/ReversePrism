using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FollowedDate                             000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<FriendStatus> IL2CPP_TYPE_GENERICINST
    // 020 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 TargetUserFieldNumber                    int IL2CPP_TYPE_I4
    // 028 TargetUser                               0001865C39B0 ModelClassType ProfileStatus ProfileStatus ProfileStatus Pointer
    // 000 FriendStateFieldNumber                   int IL2CPP_TYPE_I4
    // 030 FriendState                              0001865CB0A0 ModelEnumType FriendState FriendState FriendState Int32
    // 000 FollowedDateFieldNumber                  int IL2CPP_TYPE_I4
    // 038 _FollowedDate                            000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 ProduceIdolStatusForIconFieldNumber      int IL2CPP_TYPE_I4
    // 040 ProduceIdolStatusForIcon                 000186550070 ModelClassType ProduceIdolStatus ProduceIdolStatus ProduceIdolStatus Pointer
    public partial class FriendStatus : DataModel
    {
        public DateTime                                 FollowedDate                            { get; set; }
        public ProfileStatus?                           TargetUser                              { get; set; }
        public FriendState                              FriendState                             { get; set; }
        public Timestamp?                               _FollowedDate                           { get; set; }
        public ProduceIdolStatus?                       ProduceIdolStatusForIcon                { get; set; }

        public static FriendStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FriendStatus() { Pointer= p0 };

            value.FollowedDate                              = GetDateTime(new IntPtr(p + 0x010)); // 0246613AE9D0 0x10 FollowedDate                ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.TargetUser                                = GetObject<ProfileStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProfileStatus.FromPointer); // 0246613AEA50 0x28 TargetUser                  ( 0001865C39B0 ModelClassType ProfileStatus ProfileStatus ProfileStatus Pointer )
            value.FriendState                               = (FriendState)GetInt32(new IntPtr(p + 0x030)); // 0246613AEA90 0x30 FriendState                 ( 0001865CB0A0 ModelEnumType FriendState FriendState FriendState Int32 )
            value._FollowedDate                             = GetObject<Timestamp>(new IntPtr(p + 0x038), ReversePrism.DataModels.Timestamp.FromPointer); // 0246613AEAD0 0x38 _FollowedDate               ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.ProduceIdolStatusForIcon                  = GetObject<ProduceIdolStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.ProduceIdolStatus.FromPointer); // 0246613AEB10 0x40 ProduceIdolStatusForIcon    ( 000186550070 ModelClassType ProduceIdolStatus ProduceIdolStatus ProduceIdolStatus Pointer )
            value.FollowedDate                  = ToDateTime(value._FollowedDate);

            return value;
        }
    }
}
