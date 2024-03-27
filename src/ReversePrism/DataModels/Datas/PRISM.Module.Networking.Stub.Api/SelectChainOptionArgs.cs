using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<SelectChainOptionArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstChainTalkIdFieldNumber                int IL2CPP_TYPE_I4
    // 018 MstChainTalkId                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ChoiceFieldNumber                        int IL2CPP_TYPE_I4
    // 01C Choice                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class SelectChainOptionArgs
    {
        public int                                      MstChainTalkId                          { get; set; }
        public int                                      Choice                                  { get; set; }

        public static SelectChainOptionArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SelectChainOptionArgs();

            value.MstChainTalkId                            = GetInt32(new IntPtr(p + 0x018)); // 0270D22F93A8 0x18 MstChainTalkId              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Choice                                    = GetInt32(new IntPtr(p + 0x01C)); // 0270D22F93E8 0x1C Choice                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
