using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<SetIdolBaseCostumeReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 IdolBaseFieldNumber                      int IL2CPP_TYPE_I4
    // 018 IdolBase                                 0001866AD5B0 ModelClassType IdolBaseStatus IdolBaseStatus IdolBaseStatus Pointer
    public partial class SetIdolBaseCostumeReply
    {
        public IdolBaseStatus?                          IdolBase                                { get; set; }

        public static SetIdolBaseCostumeReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SetIdolBaseCostumeReply();

            value.IdolBase                                  = GetObject<IdolBaseStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IdolBaseStatus.FromPointer); // 0270D20FFF70 0x18 IdolBase                    ( 0001866AD5B0 ModelClassType IdolBaseStatus IdolBaseStatus IdolBaseStatus Pointer )

            return value;
        }
    }
}
