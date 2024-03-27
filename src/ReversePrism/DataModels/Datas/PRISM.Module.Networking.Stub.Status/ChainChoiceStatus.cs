using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ChainChoiceStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ChoiceFieldNumber                        int IL2CPP_TYPE_I4
    // 018 Choice                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class ChainChoiceStatus
    {
        public int                                      Choice                                  { get; set; }

        public static ChainChoiceStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChainChoiceStatus();

            value.Choice                                    = GetInt32(new IntPtr(p + 0x018)); // 0270D2303B30 0x18 Choice                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
