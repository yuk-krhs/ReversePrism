using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ChildType                                000186693B90 ModelClassType Type Type Type Pointer
    // 018 Levels                                   0001865F4940 ModelPrimitiveType int int int Int32
    public partial class SupportsChildTracksAttribute
    {
        public Type?                                    ChildType                               { get; set; }
        public int                                      Levels                                  { get; set; }

        public static SupportsChildTracksAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportsChildTracksAttribute();

            value.ChildType                                 = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 0270DB2A4790 0x10 ChildType                   ( 000186693B90 ModelClassType Type Type Type Pointer )
            value.Levels                                    = GetInt32(new IntPtr(p + 0x018)); // 0270DB2A47B0 0x18 Levels                      ( 0001865F4940 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
