using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<Request> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 IdFieldNumber                            int IL2CPP_TYPE_I4
    // 018 Id                                       ModelPrimitiveType string string string String
    // 000 MethodFieldNumber                        int IL2CPP_TYPE_I4
    // 020 Method                                   ModelPrimitiveType string string string String
    // 000 HeadersFieldNumber                       int IL2CPP_TYPE_I4
    // 008 _map_headers_codec                       Codec<string, string> IL2CPP_TYPE_GENERICINST
    // 028 headers_                                 MapField`2<string, string> IL2CPP_TYPE_GENERICINST
    // 000 PathFieldNumber                          int IL2CPP_TYPE_I4
    // 030 Path                                     ModelPrimitiveType string string string String
    // 000 HostFieldNumber                          int IL2CPP_TYPE_I4
    // 038 Host                                     ModelPrimitiveType string string string String
    // 000 SchemeFieldNumber                        int IL2CPP_TYPE_I4
    // 040 Scheme                                   ModelPrimitiveType string string string String
    // 000 QueryFieldNumber                         int IL2CPP_TYPE_I4
    // 048 Query                                    ModelPrimitiveType string string string String
    // 000 TimeFieldNumber                          int IL2CPP_TYPE_I4
    // 050 _Time                                    ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 SizeFieldNumber                          int IL2CPP_TYPE_I4
    // 058 Size                                     ModelPrimitiveType long long long Int64
    // 000 ProtocolFieldNumber                      int IL2CPP_TYPE_I4
    // 060 Protocol                                 ModelPrimitiveType string string string String
    // 000 ReasonFieldNumber                        int IL2CPP_TYPE_I4
    // 068 Reason                                   ModelPrimitiveType string string string String
    // 000 AuthFieldNumber                          int IL2CPP_TYPE_I4
    // 070 Auth                                     ModelClassType Auth Auth Auth Pointer
    public partial class Request : DataModel
    {
        public string                                   Id                                      { get; set; }
        public string                                   Method                                  { get; set; }
        public string                                   Path                                    { get; set; }
        public string                                   Host                                    { get; set; }
        public string                                   Scheme                                  { get; set; }
        public string                                   Query                                   { get; set; }
        public Timestamp?                               _Time                                   { get; set; }
        public long                                     Size                                    { get; set; }
        public string                                   Protocol                                { get; set; }
        public string                                   Reason                                  { get; set; }
        public Auth?                                    Auth                                    { get; set; }

        public static Request? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Request() { Pointer= p0 };

            value.Id                                        = GetString(new IntPtr(p + 0x018)); // 0x18 Id                          ( ModelPrimitiveType string string string String )
            value.Method                                    = GetString(new IntPtr(p + 0x020)); // 0x20 Method                      ( ModelPrimitiveType string string string String )
            value.Path                                      = GetString(new IntPtr(p + 0x030)); // 0x30 Path                        ( ModelPrimitiveType string string string String )
            value.Host                                      = GetString(new IntPtr(p + 0x038)); // 0x38 Host                        ( ModelPrimitiveType string string string String )
            value.Scheme                                    = GetString(new IntPtr(p + 0x040)); // 0x40 Scheme                      ( ModelPrimitiveType string string string String )
            value.Query                                     = GetString(new IntPtr(p + 0x048)); // 0x48 Query                       ( ModelPrimitiveType string string string String )
            value._Time                                     = GetObject<Timestamp>(new IntPtr(p + 0x050), ReversePrism.DataModels.Timestamp.FromPointer); // 0x50 _Time                       ( ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.Size                                      = GetInt64(new IntPtr(p + 0x058)); // 0x58 Size                        ( ModelPrimitiveType long long long Int64 )
            value.Protocol                                  = GetString(new IntPtr(p + 0x060)); // 0x60 Protocol                    ( ModelPrimitiveType string string string String )
            value.Reason                                    = GetString(new IntPtr(p + 0x068)); // 0x68 Reason                      ( ModelPrimitiveType string string string String )
            value.Auth                                      = GetObject<Auth>(new IntPtr(p + 0x070), ReversePrism.DataModels.Auth.FromPointer); // 0x70 Auth                        ( ModelClassType Auth Auth Auth Pointer )

            return value;
        }
    }
}
