using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<SetDressUpRoomCostumeReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 DressUpRoomCostumeFieldNumber            int IL2CPP_TYPE_I4
    // 018 DressUpRoomCostume                       000186700050 ModelClassType DressUpRoomCostumeStatus DressUpRoomCostumeStatus DressUpRoomCostumeStatus Pointer
    public partial class SetDressUpRoomCostumeReply
    {
        public DressUpRoomCostumeStatus?                DressUpRoomCostume                      { get; set; }

        public static SetDressUpRoomCostumeReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SetDressUpRoomCostumeReply();

            value.DressUpRoomCostume                        = GetObject<DressUpRoomCostumeStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.DressUpRoomCostumeStatus.FromPointer); // 02700417EC78 0x18 DressUpRoomCostume          ( 000186700050 ModelClassType DressUpRoomCostumeStatus DressUpRoomCostumeStatus DressUpRoomCostumeStatus Pointer )

            return value;
        }
    }
}
