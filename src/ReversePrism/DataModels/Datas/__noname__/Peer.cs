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
    // 018 Ip                                       ModelPrimitiveType string string string String
    // 000 PortFieldNumber                          int IL2CPP_TYPE_I4
    // 020 Port                                     ModelPrimitiveType long long long Int64
    // 000 LabelsFieldNumber                        int IL2CPP_TYPE_I4
    // 008 _map_labels_codec                        Codec<string, string> IL2CPP_TYPE_GENERICINST
    // 028 labels_                                  MapField`2<string, string> IL2CPP_TYPE_GENERICINST
    // 000 PrincipalFieldNumber                     int IL2CPP_TYPE_I4
    // 030 Principal                                ModelPrimitiveType string string string String
    // 000 RegionCodeFieldNumber                    int IL2CPP_TYPE_I4
    // 038 RegionCode                               ModelPrimitiveType string string string String
    public partial class Peer : DataModel
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
            var value   = new Peer() { Pointer= p0 };

            value.Ip                                        = GetString(new IntPtr(p + 0x018)); // 0x18 Ip                          ( ModelPrimitiveType string string string String )
            value.Port                                      = GetInt64(new IntPtr(p + 0x020)); // 0x20 Port                        ( ModelPrimitiveType long long long Int64 )
            value.Principal                                 = GetString(new IntPtr(p + 0x030)); // 0x30 Principal                   ( ModelPrimitiveType string string string String )
            value.RegionCode                                = GetString(new IntPtr(p + 0x038)); // 0x38 RegionCode                  ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
