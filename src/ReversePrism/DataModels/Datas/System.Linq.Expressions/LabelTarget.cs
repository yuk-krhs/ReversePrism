using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     000186672F10 ModelPrimitiveType string string string String
    // 018 Type                                     0001866936B0 ModelClassType Type Type Type Pointer
    public partial class LabelTarget
    {
        public string                                   Name                                    { get; set; }
        public Type?                                    Type                                    { get; set; }

        public static LabelTarget? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LabelTarget();

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0270D9F31208 0x10 Name                        ( 000186672F10 ModelPrimitiveType string string string String )
            value.Type                                      = GetObject<Type>(new IntPtr(p + 0x018), ReversePrism.DataModels.Type.FromPointer); // 0270D9F31228 0x18 Type                        ( 0001866936B0 ModelClassType Type Type Type Pointer )

            return value;
        }
    }
}
