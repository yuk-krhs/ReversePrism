using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 068 Root                                     ModelClassType SecurityElement SecurityElement SecurityElement Pointer
    // 070 Current                                  ModelClassType SecurityElement SecurityElement SecurityElement Pointer
    // 078 Stack                                    ModelClassType Stack Stack Stack Pointer
    public partial class SecurityParser : DataModel
    {
        public SecurityElement?                         Root                                    { get; set; }
        public SecurityElement?                         Current                                 { get; set; }
        public Stack?                                   Stack                                   { get; set; }

        public static SecurityParser? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SecurityParser() { Pointer= p0 };

            value.Root                                      = GetObject<SecurityElement>(new IntPtr(p + 0x068), ReversePrism.DataModels.SecurityElement.FromPointer); // 0x68 Root                        ( ModelClassType SecurityElement SecurityElement SecurityElement Pointer )
            value.Current                                   = GetObject<SecurityElement>(new IntPtr(p + 0x070), ReversePrism.DataModels.SecurityElement.FromPointer); // 0x70 Current                     ( ModelClassType SecurityElement SecurityElement SecurityElement Pointer )
            value.Stack                                     = GetObject<Stack>(new IntPtr(p + 0x078), ReversePrism.DataModels.Stack.FromPointer); // 0x78 Stack                       ( ModelClassType Stack Stack Stack Pointer )

            return value;
        }
    }
}
