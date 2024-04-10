using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Ref                                      000186671BA0 ModelPrimitiveType string string string String
    // 018 Type                                     000186671BA0 ModelPrimitiveType string string string String
    // 020 Id                                       000186671BA0 ModelPrimitiveType string string string String
    // 028 DelayLoadAsClientChannel                 000186671BA0 ModelPrimitiveType string string string String
    // 030 ServerProviders                          00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer
    // 038 ClientProviders                          00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer
    // 040 CustomProperties                         0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer
    public partial class ChannelData : DataModel
    {
        public string                                   Ref                                     { get; set; }
        public string                                   Type                                    { get; set; }
        public string                                   Id                                      { get; set; }
        public string                                   DelayLoadAsClientChannel                { get; set; }
        public ArrayList?                               ServerProviders                         { get; set; }
        public ArrayList?                               ClientProviders                         { get; set; }
        public Hashtable?                               CustomProperties                        { get; set; }

        public static ChannelData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChannelData() { Pointer= p0 };

            value.Ref                                       = GetString(new IntPtr(p + 0x010)); // 024666C2CCE0 0x10 Ref                         ( 000186671BA0 ModelPrimitiveType string string string String )
            value.Type                                      = GetString(new IntPtr(p + 0x018)); // 024666C2CD00 0x18 Type                        ( 000186671BA0 ModelPrimitiveType string string string String )
            value.Id                                        = GetString(new IntPtr(p + 0x020)); // 024666C2CD20 0x20 Id                          ( 000186671BA0 ModelPrimitiveType string string string String )
            value.DelayLoadAsClientChannel                  = GetString(new IntPtr(p + 0x028)); // 024666C2CD40 0x28 DelayLoadAsClientChannel    ( 000186671BA0 ModelPrimitiveType string string string String )
            value.ServerProviders                           = GetObject<ArrayList>(new IntPtr(p + 0x030), ReversePrism.DataModels.ArrayList.FromPointer); // 024666C2CD60 0x30 ServerProviders             ( 00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.ClientProviders                           = GetObject<ArrayList>(new IntPtr(p + 0x038), ReversePrism.DataModels.ArrayList.FromPointer); // 024666C2CD80 0x38 ClientProviders             ( 00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.CustomProperties                          = GetObject<Hashtable>(new IntPtr(p + 0x040), ReversePrism.DataModels.Hashtable.FromPointer); // 024666C2CDA0 0x40 CustomProperties            ( 0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer )

            return value;
        }
    }
}
