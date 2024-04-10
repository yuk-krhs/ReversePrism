using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     000186692F60 ModelClassType Type Type Type Pointer
    // 018 AssemblyName                             0001866722E0 ModelPrimitiveType string string string String
    public partial class TypeNAssembly : DataModel
    {
        public Type?                                    Type                                    { get; set; }
        public string                                   AssemblyName                            { get; set; }

        public static TypeNAssembly? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TypeNAssembly() { Pointer= p0 };

            value.Type                                      = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 024666CC4880 0x10 Type                        ( 000186692F60 ModelClassType Type Type Type Pointer )
            value.AssemblyName                              = GetString(new IntPtr(p + 0x018)); // 024666CC48A0 0x18 AssemblyName                ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
