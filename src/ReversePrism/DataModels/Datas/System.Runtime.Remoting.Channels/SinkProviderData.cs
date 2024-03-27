using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SinkName                                 000186671910 ModelPrimitiveType string string string String
    // 018 Children                                 00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer
    // 020 Properties                               0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer
    public partial class SinkProviderData
    {
        public string                                   SinkName                                { get; set; }
        public ArrayList?                               Children                                { get; set; }
        public Hashtable?                               Properties                              { get; set; }

        public static SinkProviderData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SinkProviderData();

            value.SinkName                                  = GetString(new IntPtr(p + 0x010)); // 0270D6BE6028 0x10 SinkName                    ( 000186671910 ModelPrimitiveType string string string String )
            value.Children                                  = GetObject<ArrayList>(new IntPtr(p + 0x018), ReversePrism.DataModels.ArrayList.FromPointer); // 0270D6BE6048 0x18 Children                    ( 00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.Properties                                = GetObject<Hashtable>(new IntPtr(p + 0x020), ReversePrism.DataModels.Hashtable.FromPointer); // 0270D6BE6068 0x20 Properties                  ( 0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer )

            return value;
        }
    }
}
