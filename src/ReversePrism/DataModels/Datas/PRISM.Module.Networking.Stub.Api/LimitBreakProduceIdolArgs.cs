using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<LimitBreakProduceIdolArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstProduceIdolIdFieldNumber              int IL2CPP_TYPE_I4
    // 018 MstProduceIdolId                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 StarFieldNumber                          int IL2CPP_TYPE_I4
    // 01C Star                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class LimitBreakProduceIdolArgs
    {
        public int                                      MstProduceIdolId                        { get; set; }
        public int                                      Star                                    { get; set; }

        public static LimitBreakProduceIdolArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LimitBreakProduceIdolArgs();

            value.MstProduceIdolId                          = GetInt32(new IntPtr(p + 0x018)); // 0270D25F8B40 0x18 MstProduceIdolId            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Star                                      = GetInt32(new IntPtr(p + 0x01C)); // 0270D25F8B80 0x1C Star                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
