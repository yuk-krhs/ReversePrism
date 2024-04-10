using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetTutorialProduceUnitReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProduceUnitFieldNumber                   int IL2CPP_TYPE_I4
    // 018 ProduceUnit                              000186552890 ModelClassType ProduceIdolUnitStatus ProduceIdolUnitStatus ProduceIdolUnitStatus Pointer
    // 000 FriendSupportFieldNumber                 int IL2CPP_TYPE_I4
    // 020 FriendSupport                            0001865CC600 ModelClassType FriendSupportStatus FriendSupportStatus FriendSupportStatus Pointer
    public partial class GetTutorialProduceUnitReply : DataModel
    {
        public ProduceIdolUnitStatus?                   ProduceUnit                             { get; set; }
        public FriendSupportStatus?                     FriendSupport                           { get; set; }

        public static GetTutorialProduceUnitReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetTutorialProduceUnitReply() { Pointer= p0 };

            value.ProduceUnit                               = GetObject<ProduceIdolUnitStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceIdolUnitStatus.FromPointer); // 024662BDD818 0x18 ProduceUnit                 ( 000186552890 ModelClassType ProduceIdolUnitStatus ProduceIdolUnitStatus ProduceIdolUnitStatus Pointer )
            value.FriendSupport                             = GetObject<FriendSupportStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.FriendSupportStatus.FromPointer); // 024662BDD858 0x20 FriendSupport               ( 0001865CC600 ModelClassType FriendSupportStatus FriendSupportStatus FriendSupportStatus Pointer )

            return value;
        }
    }
}
