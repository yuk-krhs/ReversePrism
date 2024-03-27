using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CreateDate                               000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<DirectMessageStatus> IL2CPP_TYPE_GENERICINST
    // 020 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 DirectMessageIdFieldNumber               int IL2CPP_TYPE_I4
    // 028 DirectMessageId                          000186671910 ModelPrimitiveType string string string String
    // 000 TitleFieldNumber                         int IL2CPP_TYPE_I4
    // 030 Title                                    000186671910 ModelPrimitiveType string string string String
    // 000 BodyFieldNumber                          int IL2CPP_TYPE_I4
    // 038 Body                                     000186671910 ModelPrimitiveType string string string String
    // 000 CreateDateFieldNumber                    int IL2CPP_TYPE_I4
    // 040 _CreateDate                              000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 IsNewFieldNumber                         int IL2CPP_TYPE_I4
    // 048 IsNew                                    000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class DirectMessageStatus
    {
        public DateTime                                 CreateDate                              { get; set; }
        public string                                   DirectMessageId                         { get; set; }
        public string                                   Title                                   { get; set; }
        public string                                   Body                                    { get; set; }
        public Timestamp?                               _CreateDate                             { get; set; }
        public bool                                     IsNew                                   { get; set; }

        public static DirectMessageStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DirectMessageStatus();

            value.CreateDate                                = GetDateTime(new IntPtr(p + 0x010)); // 0270D0F49F00 0x10 CreateDate                  ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.DirectMessageId                           = GetString(new IntPtr(p + 0x028)); // 0270D0F49F80 0x28 DirectMessageId             ( 000186671910 ModelPrimitiveType string string string String )
            value.Title                                     = GetString(new IntPtr(p + 0x030)); // 0270D0F49FC0 0x30 Title                       ( 000186671910 ModelPrimitiveType string string string String )
            value.Body                                      = GetString(new IntPtr(p + 0x038)); // 0270D0F4A000 0x38 Body                        ( 000186671910 ModelPrimitiveType string string string String )
            value._CreateDate                               = GetObject<Timestamp>(new IntPtr(p + 0x040), ReversePrism.DataModels.Timestamp.FromPointer); // 0270D0F4A040 0x40 _CreateDate                 ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.IsNew                                     = GetBool(new IntPtr(p + 0x048)); // 0270D0F4A080 0x48 IsNew                       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CreateDate                    = ToDateTime(value._CreateDate);

            return value;
        }
    }
}
