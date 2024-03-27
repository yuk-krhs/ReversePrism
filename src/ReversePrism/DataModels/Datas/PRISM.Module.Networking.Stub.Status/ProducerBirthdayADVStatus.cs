using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ProducerBirthdayADVStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstProducerBirthdayAdvIdFieldNumber      int IL2CPP_TYPE_I4
    // 018 MstProducerBirthdayAdvId                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstIdolIdFieldNumber                     int IL2CPP_TYPE_I4
    // 01C MstIdolId                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ResourceIdFieldNumber                    int IL2CPP_TYPE_I4
    // 020 ResourceId                               000186671910 ModelPrimitiveType string string string String
    public partial class ProducerBirthdayADVStatus
    {
        public int                                      MstProducerBirthdayAdvId                { get; set; }
        public int                                      MstIdolId                               { get; set; }
        public string                                   ResourceId                              { get; set; }

        public static ProducerBirthdayADVStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProducerBirthdayADVStatus();

            value.MstProducerBirthdayAdvId                  = GetInt32(new IntPtr(p + 0x018)); // 0270D1989FA0 0x18 MstProducerBirthdayAdvId    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstIdolId                                 = GetInt32(new IntPtr(p + 0x01C)); // 0270D1989FE0 0x1C MstIdolId                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ResourceId                                = GetString(new IntPtr(p + 0x020)); // 0270D198A020 0x20 ResourceId                  ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
