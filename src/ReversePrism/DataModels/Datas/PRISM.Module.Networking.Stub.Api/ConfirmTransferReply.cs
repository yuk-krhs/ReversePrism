using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CreateDate                               000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<ConfirmTransferReply> IL2CPP_TYPE_GENERICINST
    // 020 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 SearchUserIdFieldNumber                  int IL2CPP_TYPE_I4
    // 028 SearchUserId                             000186671910 ModelPrimitiveType string string string String
    // 000 UserNameFieldNumber                      int IL2CPP_TYPE_I4
    // 030 UserName                                 000186671910 ModelPrimitiveType string string string String
    // 000 CreateDateFieldNumber                    int IL2CPP_TYPE_I4
    // 038 _CreateDate                              000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    public partial class ConfirmTransferReply
    {
        public DateTime                                 CreateDate                              { get; set; }
        public string                                   SearchUserId                            { get; set; }
        public string                                   UserName                                { get; set; }
        public Timestamp?                               _CreateDate                             { get; set; }

        public static ConfirmTransferReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ConfirmTransferReply();

            value.CreateDate                                = GetDateTime(new IntPtr(p + 0x010)); // 027003B0B3E0 0x10 CreateDate                  ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.SearchUserId                              = GetString(new IntPtr(p + 0x028)); // 027003B0B460 0x28 SearchUserId                ( 000186671910 ModelPrimitiveType string string string String )
            value.UserName                                  = GetString(new IntPtr(p + 0x030)); // 027003B0B4A0 0x30 UserName                    ( 000186671910 ModelPrimitiveType string string string String )
            value._CreateDate                               = GetObject<Timestamp>(new IntPtr(p + 0x038), ReversePrism.DataModels.Timestamp.FromPointer); // 027003B0B4E0 0x38 _CreateDate                 ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.CreateDate                    = ToDateTime(value._CreateDate);

            return value;
        }
    }
}
