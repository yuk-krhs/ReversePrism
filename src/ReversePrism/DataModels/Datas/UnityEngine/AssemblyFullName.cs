using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     0001866722E0 ModelPrimitiveType string string string String
    // 018 Version                                  0001866E2110 ModelEnumType AssemblyVersion AssemblyVersion AssemblyVersion Int32
    // 020 PublicKeyToken                           0001866722E0 ModelPrimitiveType string string string String
    // 028 Culture                                  0001866722E0 ModelPrimitiveType string string string String
    public partial class AssemblyFullName : DataModel
    {
        public string                                   Name                                    { get; set; }
        public AssemblyVersion                          Version                                 { get; set; }
        public string                                   PublicKeyToken                          { get; set; }
        public string                                   Culture                                 { get; set; }

        public static AssemblyFullName? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AssemblyFullName() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0245A2322AF8 0x10 Name                        ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Version                                   = (AssemblyVersion)GetInt32(new IntPtr(p + 0x018)); // 0245A2322B18 0x18 Version                     ( 0001866E2110 ModelEnumType AssemblyVersion AssemblyVersion AssemblyVersion Int32 )
            value.PublicKeyToken                            = GetString(new IntPtr(p + 0x020)); // 0245A2322B38 0x20 PublicKeyToken              ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Culture                                   = GetString(new IntPtr(p + 0x028)); // 0245A2322B58 0x28 Culture                     ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
