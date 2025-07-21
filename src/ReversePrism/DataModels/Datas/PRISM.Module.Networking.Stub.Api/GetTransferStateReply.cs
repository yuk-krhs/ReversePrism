using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CreateDate                               ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 020 ReleasableDate                           ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<GetTransferStateReply> IL2CPP_TYPE_GENERICINST
    // 030 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 IsConnectedFieldNumber                   int IL2CPP_TYPE_I4
    // 038 IsConnected                              ModelPrimitiveType bool bool bool Bool
    // 000 SearchUserIdFieldNumber                  int IL2CPP_TYPE_I4
    // 040 SearchUserId                             ModelPrimitiveType string string string String
    // 000 UserNameFieldNumber                      int IL2CPP_TYPE_I4
    // 048 UserName                                 ModelPrimitiveType string string string String
    // 000 CreateDateFieldNumber                    int IL2CPP_TYPE_I4
    // 050 _CreateDate                              ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 ReleasableDateFieldNumber                int IL2CPP_TYPE_I4
    // 058 _ReleasableDate                          ModelClassType Timestamp Timestamp Timestamp Pointer
    public partial class GetTransferStateReply : DataModel
    {
        public DateTime                                 CreateDate                              { get; set; }
        public DateTime                                 ReleasableDate                          { get; set; }
        public bool                                     IsConnected                             { get; set; }
        public string                                   SearchUserId                            { get; set; }
        public string                                   UserName                                { get; set; }
        public Timestamp?                               _CreateDate                             { get; set; }
        public Timestamp?                               _ReleasableDate                         { get; set; }

        public static GetTransferStateReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetTransferStateReply() { Pointer= p0 };

            value.CreateDate                                = GetDateTime(new IntPtr(p + 0x010)); // 0x10 CreateDate                  ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.ReleasableDate                            = GetDateTime(new IntPtr(p + 0x020)); // 0x20 ReleasableDate              ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.IsConnected                               = GetBool(new IntPtr(p + 0x038)); // 0x38 IsConnected                 ( ModelPrimitiveType bool bool bool Bool )
            value.SearchUserId                              = GetString(new IntPtr(p + 0x040)); // 0x40 SearchUserId                ( ModelPrimitiveType string string string String )
            value.UserName                                  = GetString(new IntPtr(p + 0x048)); // 0x48 UserName                    ( ModelPrimitiveType string string string String )
            value._CreateDate                               = GetObject<Timestamp>(new IntPtr(p + 0x050), ReversePrism.DataModels.Timestamp.FromPointer); // 0x50 _CreateDate                 ( ModelClassType Timestamp Timestamp Timestamp Pointer )
            value._ReleasableDate                           = GetObject<Timestamp>(new IntPtr(p + 0x058), ReversePrism.DataModels.Timestamp.FromPointer); // 0x58 _ReleasableDate             ( ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.CreateDate                    = ToDateTime(value._CreateDate);
            value.ReleasableDate                = ToDateTime(value._ReleasableDate);

            return value;
        }
    }
}
