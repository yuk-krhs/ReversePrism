using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Ref                                      ModelPrimitiveType string string string String
    // 018 Type                                     ModelPrimitiveType string string string String
    // 020 Id                                       ModelPrimitiveType string string string String
    // 028 DelayLoadAsClientChannel                 ModelPrimitiveType string string string String
    // 030 ServerProviders                          ModelClassType ArrayList ArrayList ArrayList Pointer
    // 038 ClientProviders                          ModelClassType ArrayList ArrayList ArrayList Pointer
    // 040 CustomProperties                         ModelClassType Hashtable Hashtable Hashtable Pointer
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

            value.Ref                                       = GetString(new IntPtr(p + 0x010)); // 0x10 Ref                         ( ModelPrimitiveType string string string String )
            value.Type                                      = GetString(new IntPtr(p + 0x018)); // 0x18 Type                        ( ModelPrimitiveType string string string String )
            value.Id                                        = GetString(new IntPtr(p + 0x020)); // 0x20 Id                          ( ModelPrimitiveType string string string String )
            value.DelayLoadAsClientChannel                  = GetString(new IntPtr(p + 0x028)); // 0x28 DelayLoadAsClientChannel    ( ModelPrimitiveType string string string String )
            value.ServerProviders                           = GetObject<ArrayList>(new IntPtr(p + 0x030), ReversePrism.DataModels.ArrayList.FromPointer); // 0x30 ServerProviders             ( ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.ClientProviders                           = GetObject<ArrayList>(new IntPtr(p + 0x038), ReversePrism.DataModels.ArrayList.FromPointer); // 0x38 ClientProviders             ( ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.CustomProperties                          = GetObject<Hashtable>(new IntPtr(p + 0x040), ReversePrism.DataModels.Hashtable.FromPointer); // 0x40 CustomProperties            ( ModelClassType Hashtable Hashtable Hashtable Pointer )

            return value;
        }
    }
}
