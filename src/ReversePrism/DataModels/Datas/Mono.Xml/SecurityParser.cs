using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 068 Root                                     0001867114A0 ModelClassType SecurityElement SecurityElement SecurityElement Pointer
    // 070 Current                                  0001867114A0 ModelClassType SecurityElement SecurityElement SecurityElement Pointer
    // 078 Stack                                    00018655EBF0 ModelClassType Stack Stack Stack Pointer
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

            value.Root                                      = GetObject<SecurityElement>(new IntPtr(p + 0x068), ReversePrism.DataModels.SecurityElement.FromPointer); // 0246669A8AA8 0x68 Root                        ( 0001867114A0 ModelClassType SecurityElement SecurityElement SecurityElement Pointer )
            value.Current                                   = GetObject<SecurityElement>(new IntPtr(p + 0x070), ReversePrism.DataModels.SecurityElement.FromPointer); // 0246669A8AC8 0x70 Current                     ( 0001867114A0 ModelClassType SecurityElement SecurityElement SecurityElement Pointer )
            value.Stack                                     = GetObject<Stack>(new IntPtr(p + 0x078), ReversePrism.DataModels.Stack.FromPointer); // 0246669A8AE8 0x78 Stack                       ( 00018655EBF0 ModelClassType Stack Stack Stack Pointer )

            return value;
        }
    }
}
