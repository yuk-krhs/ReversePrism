using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<Mixin> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 NameFieldNumber                          int IL2CPP_TYPE_I4
    // 018 Name                                     ModelPrimitiveType string string string String
    // 000 RootFieldNumber                          int IL2CPP_TYPE_I4
    // 020 Root                                     ModelPrimitiveType string string string String
    public partial class Mixin : DataModel
    {
        public string                                   Name                                    { get; set; }
        public string                                   Root                                    { get; set; }

        public static Mixin? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Mixin() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x018)); // 0x18 Name                        ( ModelPrimitiveType string string string String )
            value.Root                                      = GetString(new IntPtr(p + 0x020)); // 0x20 Root                        ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
