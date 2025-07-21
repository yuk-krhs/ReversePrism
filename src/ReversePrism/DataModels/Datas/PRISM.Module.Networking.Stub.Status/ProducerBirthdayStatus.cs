using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ProducerBirthdayStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstProducerBirthdayAdvGroupIdFieldNumber int IL2CPP_TYPE_I4
    // 018 MstProducerBirthdayAdvGroupId            ModelPrimitiveType int int int Int32
    // 000 AdvListFieldNumber                       int IL2CPP_TYPE_I4
    // 008 _repeated_advList_codec                  FieldCodec`1<ProducerBirthdayADVStatus> IL2CPP_TYPE_GENERICINST
    // 020 AdvList                                  ModelClassListType RepeatedField`1<ProducerBirthdayADVStatus> RepeatedField`1<ProducerBirthdayADVStatus> List<ProducerBirthdayADVStatus> Pointer
    public partial class ProducerBirthdayStatus : DataModel
    {
        public int                                      MstProducerBirthdayAdvGroupId           { get; set; }
        public List<ProducerBirthdayADVStatus>?         AdvList                                 { get; set; }

        public static ProducerBirthdayStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProducerBirthdayStatus() { Pointer= p0 };

            value.MstProducerBirthdayAdvGroupId             = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstProducerBirthdayAdvGroupId ( ModelPrimitiveType int int int Int32 )
            value.AdvList                                   = GetObjectList<ProducerBirthdayADVStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProducerBirthdayADVStatus.FromPointer); // 0x20 AdvList                     ( ModelClassListType RepeatedField`1<ProducerBirthdayADVStatus> RepeatedField`1<ProducerBirthdayADVStatus> List<ProducerBirthdayADVStatus> Pointer )

            return value;
        }
    }
}
