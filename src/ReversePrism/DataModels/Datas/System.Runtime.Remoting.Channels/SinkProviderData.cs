using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SinkName                                 ModelPrimitiveType string string string String
    // 018 Children                                 ModelClassType ArrayList ArrayList ArrayList Pointer
    // 020 Properties                               ModelClassType Hashtable Hashtable Hashtable Pointer
    public partial class SinkProviderData : DataModel
    {
        public string                                   SinkName                                { get; set; }
        public ArrayList?                               Children                                { get; set; }
        public Hashtable?                               Properties                              { get; set; }

        public static SinkProviderData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SinkProviderData() { Pointer= p0 };

            value.SinkName                                  = GetString(new IntPtr(p + 0x010)); // 0x10 SinkName                    ( ModelPrimitiveType string string string String )
            value.Children                                  = GetObject<ArrayList>(new IntPtr(p + 0x018), ReversePrism.DataModels.ArrayList.FromPointer); // 0x18 Children                    ( ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.Properties                                = GetObject<Hashtable>(new IntPtr(p + 0x020), ReversePrism.DataModels.Hashtable.FromPointer); // 0x20 Properties                  ( ModelClassType Hashtable Hashtable Hashtable Pointer )

            return value;
        }
    }
}
