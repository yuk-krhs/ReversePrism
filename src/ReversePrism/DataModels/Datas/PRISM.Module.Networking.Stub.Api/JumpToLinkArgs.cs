using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<JumpToLinkArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 JumpFieldNumber                          int IL2CPP_TYPE_I4
    // 018 Jump                                     000186768670 ModelClassType JumpStatus JumpStatus JumpStatus Pointer
    public partial class JumpToLinkArgs : DataModel
    {
        public JumpStatus?                              Jump                                    { get; set; }

        public static JumpToLinkArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JumpToLinkArgs() { Pointer= p0 };

            value.Jump                                      = GetObject<JumpStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.JumpStatus.FromPointer); // 024662250358 0x18 Jump                        ( 000186768670 ModelClassType JumpStatus JumpStatus JumpStatus Pointer )

            return value;
        }
    }
}
