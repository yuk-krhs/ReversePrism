using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<BackendRule> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 SelectorFieldNumber                      int IL2CPP_TYPE_I4
    // 018 Selector                                 ModelPrimitiveType string string string String
    // 000 AddressFieldNumber                       int IL2CPP_TYPE_I4
    // 020 Address                                  ModelPrimitiveType string string string String
    // 000 DeadlineFieldNumber                      int IL2CPP_TYPE_I4
    // 028 Deadline                                 ModelPrimitiveType double double double Double
    // 000 MinDeadlineFieldNumber                   int IL2CPP_TYPE_I4
    // 030 MinDeadline                              ModelPrimitiveType double double double Double
    // 000 OperationDeadlineFieldNumber             int IL2CPP_TYPE_I4
    // 038 OperationDeadline                        ModelPrimitiveType double double double Double
    // 000 PathTranslationFieldNumber               int IL2CPP_TYPE_I4
    // 040 PathTranslation                          ModelEnumType PathTranslation PathTranslation PathTranslation Int32
    // 000 JwtAudienceFieldNumber                   int IL2CPP_TYPE_I4
    // 000 DisableAuthFieldNumber                   int IL2CPP_TYPE_I4
    // 000 ProtocolFieldNumber                      int IL2CPP_TYPE_I4
    // 048 Protocol                                 ModelPrimitiveType string string string String
    // 050 authentication_                          <object> IL2CPP_TYPE_OBJECT
    // 058 AuthenticationCase                       ModelEnumType AuthenticationOneofCase AuthenticationOneofCase AuthenticationOneofCase Int32
    public partial class BackendRule : DataModel
    {
        public string                                   Selector                                { get; set; }
        public string                                   Address                                 { get; set; }
        public double                                   Deadline                                { get; set; }
        public double                                   MinDeadline                             { get; set; }
        public double                                   OperationDeadline                       { get; set; }
        public PathTranslation                          PathTranslation                         { get; set; }
        public string                                   Protocol                                { get; set; }
        public AuthenticationOneofCase                  AuthenticationCase                      { get; set; }

        public static BackendRule? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BackendRule() { Pointer= p0 };

            value.Selector                                  = GetString(new IntPtr(p + 0x018)); // 0x18 Selector                    ( ModelPrimitiveType string string string String )
            value.Address                                   = GetString(new IntPtr(p + 0x020)); // 0x20 Address                     ( ModelPrimitiveType string string string String )
            value.Deadline                                  = GetDouble(new IntPtr(p + 0x028)); // 0x28 Deadline                    ( ModelPrimitiveType double double double Double )
            value.MinDeadline                               = GetDouble(new IntPtr(p + 0x030)); // 0x30 MinDeadline                 ( ModelPrimitiveType double double double Double )
            value.OperationDeadline                         = GetDouble(new IntPtr(p + 0x038)); // 0x38 OperationDeadline           ( ModelPrimitiveType double double double Double )
            value.PathTranslation                           = (PathTranslation)GetInt32(new IntPtr(p + 0x040)); // 0x40 PathTranslation             ( ModelEnumType PathTranslation PathTranslation PathTranslation Int32 )
            value.Protocol                                  = GetString(new IntPtr(p + 0x048)); // 0x48 Protocol                    ( ModelPrimitiveType string string string String )
            value.AuthenticationCase                        = (AuthenticationOneofCase)GetInt32(new IntPtr(p + 0x058)); // 0x58 AuthenticationCase          ( ModelEnumType AuthenticationOneofCase AuthenticationOneofCase AuthenticationOneofCase Int32 )

            return value;
        }
    }
}
