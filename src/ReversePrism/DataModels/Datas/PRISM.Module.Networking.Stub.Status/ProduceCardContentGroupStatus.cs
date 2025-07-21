using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ProduceCardContentGroupStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstProduceCardContentGroupIdFieldNumber  int IL2CPP_TYPE_I4
    // 018 MstProduceCardContentGroupId             ModelPrimitiveType int int int Int32
    // 000 MstProduceCardContentGroupTypeIdFieldNumber int IL2CPP_TYPE_I4
    // 01C MstProduceCardContentGroupTypeId         ModelPrimitiveType int int int Int32
    // 000 ProduceCardContentListFieldNumber        int IL2CPP_TYPE_I4
    // 008 _repeated_produceCardContentList_codec   FieldCodec`1<ProduceCardContentStatus> IL2CPP_TYPE_GENERICINST
    // 020 ProduceCardContentList                   ModelClassListType RepeatedField`1<ProduceCardContentStatus> RepeatedField`1<ProduceCardContentStatus> List<ProduceCardContentStatus> Pointer
    public partial class ProduceCardContentGroupStatus : DataModel
    {
        public int                                      MstProduceCardContentGroupId            { get; set; }
        public int                                      MstProduceCardContentGroupTypeId        { get; set; }
        public List<ProduceCardContentStatus>?          ProduceCardContentList                  { get; set; }

        public static ProduceCardContentGroupStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceCardContentGroupStatus() { Pointer= p0 };

            value.MstProduceCardContentGroupId              = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstProduceCardContentGroupId ( ModelPrimitiveType int int int Int32 )
            value.MstProduceCardContentGroupTypeId          = GetInt32(new IntPtr(p + 0x01C)); // 0x1C MstProduceCardContentGroupTypeId ( ModelPrimitiveType int int int Int32 )
            value.ProduceCardContentList                    = GetObjectList<ProduceCardContentStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProduceCardContentStatus.FromPointer); // 0x20 ProduceCardContentList      ( ModelClassListType RepeatedField`1<ProduceCardContentStatus> RepeatedField`1<ProduceCardContentStatus> List<ProduceCardContentStatus> Pointer )

            return value;
        }
    }
}
