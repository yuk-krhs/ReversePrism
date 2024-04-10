using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 __ServiceName                            string IL2CPP_TYPE_STRING
    // 008 __Marshaller_api_GetDressUpRoomCostumeListArgs Marshaller`1<GetDressUpRoomCostumeListArgs> IL2CPP_TYPE_GENERICINST
    // 010 __Marshaller_api_GetDressUpRoomCostumeListReply Marshaller`1<GetDressUpRoomCostumeListReply> IL2CPP_TYPE_GENERICINST
    // 018 __Marshaller_api_SetDressUpRoomCostumeArgs Marshaller`1<SetDressUpRoomCostumeArgs> IL2CPP_TYPE_GENERICINST
    // 020 __Marshaller_api_SetDressUpRoomCostumeReply Marshaller`1<SetDressUpRoomCostumeReply> IL2CPP_TYPE_GENERICINST
    // 028 __Method_GetDressUpRoomCostumeList       Method`2<GetDressUpRoomCostumeListArgs, GetDressUpRoomCostumeListReply> IL2CPP_TYPE_GENERICINST
    // 030 __Method_SetDressUpRoomCostume           Method`2<SetDressUpRoomCostumeArgs, SetDressUpRoomCostumeReply> IL2CPP_TYPE_GENERICINST
    public partial class DressUpRoomService : DataModel
    {

        public static DressUpRoomService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DressUpRoomService() { Pointer= p0 };


            return value;
        }
    }
}
