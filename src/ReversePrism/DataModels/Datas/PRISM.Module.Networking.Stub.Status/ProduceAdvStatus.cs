using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ProduceAdvStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 IdFieldNumber                            int IL2CPP_TYPE_I4
    // 018 Id                                       0001865277D0 ModelClassType ProduceAdvIDStatus ProduceAdvIDStatus ProduceAdvIDStatus Pointer
    // 000 IsReadFieldNumber                        int IL2CPP_TYPE_I4
    // 020 IsRead                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class ProduceAdvStatus
    {
        public ProduceAdvIDStatus?                      Id                                      { get; set; }
        public bool                                     IsRead                                  { get; set; }

        public static ProduceAdvStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceAdvStatus();

            value.Id                                        = GetObject<ProduceAdvIDStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceAdvIDStatus.FromPointer); // 0270D11040B8 0x18 Id                          ( 0001865277D0 ModelClassType ProduceAdvIDStatus ProduceAdvIDStatus ProduceAdvIDStatus Pointer )
            value.IsRead                                    = GetBool(new IntPtr(p + 0x020)); // 0270D11040F8 0x20 IsRead                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
