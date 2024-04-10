using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 M_Path                                   000186671BA0 ModelPrimitiveType string string string String
    // 028 M_Type                                   000186692A80 ModelClassType Type Type Type Pointer
    public partial class ResourceRequest : DataModel
    {
        public string                                   M_Path                                  { get; set; }
        public Type?                                    M_Type                                  { get; set; }

        public static ResourceRequest? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ResourceRequest() { Pointer= p0 };

            value.M_Path                                    = GetString(new IntPtr(p + 0x020)); // 0245A20D5E00 0x20 M_Path                      ( 000186671BA0 ModelPrimitiveType string string string String )
            value.M_Type                                    = GetObject<Type>(new IntPtr(p + 0x028), ReversePrism.DataModels.Type.FromPointer); // 0245A20D5E20 0x28 M_Type                      ( 000186692A80 ModelClassType Type Type Type Pointer )

            return value;
        }
    }
}
