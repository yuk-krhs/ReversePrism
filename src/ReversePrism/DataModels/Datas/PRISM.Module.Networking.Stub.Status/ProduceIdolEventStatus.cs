using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ProduceIdolEventStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstProduceIdolEventIdFieldNumber         int IL2CPP_TYPE_I4
    // 018 MstProduceIdolEventId                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstAdvInfoIdFieldNumber                  int IL2CPP_TYPE_I4
    // 020 MstAdvInfoId                             000186671910 ModelPrimitiveType string string string String
    public partial class ProduceIdolEventStatus : DataModel
    {
        public int                                      MstProduceIdolEventId                   { get; set; }
        public string                                   MstAdvInfoId                            { get; set; }

        public static ProduceIdolEventStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceIdolEventStatus() { Pointer= p0 };

            value.MstProduceIdolEventId                     = GetInt32(new IntPtr(p + 0x018)); // 024660FC95C0 0x18 MstProduceIdolEventId       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstAdvInfoId                              = GetString(new IntPtr(p + 0x020)); // 024660FC9600 0x20 MstAdvInfoId                ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
