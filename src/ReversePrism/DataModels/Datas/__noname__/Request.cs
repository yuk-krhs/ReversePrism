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
    // 018 Id                                       000186671910 ModelPrimitiveType string string string String
    // 000 MethodFieldNumber                        int IL2CPP_TYPE_I4
    // 020 Method                                   000186671910 ModelPrimitiveType string string string String
    // 000 HeadersFieldNumber                       int IL2CPP_TYPE_I4
    // 008 _map_headers_codec                       Codec<string, string> IL2CPP_TYPE_GENERICINST
    // 028 headers_                                 MapField`2<string, string> IL2CPP_TYPE_GENERICINST
    // 000 PathFieldNumber                          int IL2CPP_TYPE_I4
    // 030 Path                                     000186671910 ModelPrimitiveType string string string String
    // 000 HostFieldNumber                          int IL2CPP_TYPE_I4
    // 038 Host                                     000186671910 ModelPrimitiveType string string string String
    // 000 SchemeFieldNumber                        int IL2CPP_TYPE_I4
    // 040 Scheme                                   000186671910 ModelPrimitiveType string string string String
    // 000 QueryFieldNumber                         int IL2CPP_TYPE_I4
    // 048 Query                                    000186671910 ModelPrimitiveType string string string String
    // 000 TimeFieldNumber                          int IL2CPP_TYPE_I4
    // 050 _Time                                    000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 SizeFieldNumber                          int IL2CPP_TYPE_I4
    // 058 Size                                     0001865F7700 ModelPrimitiveType long long long Int64
    // 000 ProtocolFieldNumber                      int IL2CPP_TYPE_I4
    // 060 Protocol                                 000186671910 ModelPrimitiveType string string string String
    // 000 ReasonFieldNumber                        int IL2CPP_TYPE_I4
    // 068 Reason                                   000186671910 ModelPrimitiveType string string string String
    // 000 AuthFieldNumber                          int IL2CPP_TYPE_I4
    // 070 Auth                                     0001867645A0 ModelClassType Auth Auth Auth Pointer
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

            value.Id                                        = GetString(new IntPtr(p + 0x018)); // 02466A770BC8 0x18 Id                          ( 000186671910 ModelPrimitiveType string string string String )
            value.Method                                    = GetString(new IntPtr(p + 0x020)); // 02466A770C08 0x20 Method                      ( 000186671910 ModelPrimitiveType string string string String )
            value.Path                                      = GetString(new IntPtr(p + 0x030)); // 02466A770CA8 0x30 Path                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Host                                      = GetString(new IntPtr(p + 0x038)); // 02466A770CE8 0x38 Host                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Scheme                                    = GetString(new IntPtr(p + 0x040)); // 02466A770D28 0x40 Scheme                      ( 000186671910 ModelPrimitiveType string string string String )
            value.Query                                     = GetString(new IntPtr(p + 0x048)); // 02466A770D68 0x48 Query                       ( 000186671910 ModelPrimitiveType string string string String )
            value._Time                                     = GetObject<Timestamp>(new IntPtr(p + 0x050), ReversePrism.DataModels.Timestamp.FromPointer); // 02466A770DA8 0x50 _Time                       ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.Size                                      = GetInt64(new IntPtr(p + 0x058)); // 02466A770DE8 0x58 Size                        ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.Protocol                                  = GetString(new IntPtr(p + 0x060)); // 02466A770E28 0x60 Protocol                    ( 000186671910 ModelPrimitiveType string string string String )
            value.Reason                                    = GetString(new IntPtr(p + 0x068)); // 02466A770E68 0x68 Reason                      ( 000186671910 ModelPrimitiveType string string string String )
            value.Auth                                      = GetObject<Auth>(new IntPtr(p + 0x070), ReversePrism.DataModels.Auth.FromPointer); // 02466A770EA8 0x70 Auth                        ( 0001867645A0 ModelClassType Auth Auth Auth Pointer )

            return value;
        }
    }
}
