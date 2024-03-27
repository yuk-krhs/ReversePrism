using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<Peer> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 IpFieldNumber                            int IL2CPP_TYPE_I4
    // 018 Ip                                       000186671910 ModelPrimitiveType string string string String
    // 000 PortFieldNumber                          int IL2CPP_TYPE_I4
    // 020 Port                                     0001865F7700 ModelPrimitiveType long long long Int64
    // 000 LabelsFieldNumber                        int IL2CPP_TYPE_I4
    // 008 _map_labels_codec                        Codec<string, string> IL2CPP_TYPE_GENERICINST
    // 028 labels_                                  MapField`2<string, string> IL2CPP_TYPE_GENERICINST
    // 000 PrincipalFieldNumber                     int IL2CPP_TYPE_I4
    // 030 Principal                                000186671910 ModelPrimitiveType string string string String
    // 000 RegionCodeFieldNumber                    int IL2CPP_TYPE_I4
    // 038 RegionCode                               000186671910 ModelPrimitiveType string string string String
    public partial class Peer
    {
        public string                                   Ip                                      { get; set; }
        public long                                     Port                                    { get; set; }
        public string                                   Principal                               { get; set; }
        public string                                   RegionCode                              { get; set; }

        public static Peer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Peer();

            value.Ip                                        = GetString(new IntPtr(p + 0x018)); // 0270DA7169A0 0x18 Ip                          ( 000186671910 ModelPrimitiveType string string string String )
            value.Port                                      = GetInt64(new IntPtr(p + 0x020)); // 0270DA7169E0 0x20 Port                        ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.Principal                                 = GetString(new IntPtr(p + 0x030)); // 0270DA716A80 0x30 Principal                   ( 000186671910 ModelPrimitiveType string string string String )
            value.RegionCode                                = GetString(new IntPtr(p + 0x038)); // 0270DA716AC0 0x38 RegionCode                  ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
