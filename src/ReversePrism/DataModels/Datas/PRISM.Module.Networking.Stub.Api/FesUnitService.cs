using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 __ServiceName                            string IL2CPP_TYPE_STRING
    // 008 __Marshaller_api_GetFesUnitListArgs      Marshaller`1<GetFesUnitListArgs> IL2CPP_TYPE_GENERICINST
    // 010 __Marshaller_api_GetFesUnitListReply     Marshaller`1<GetFesUnitListReply> IL2CPP_TYPE_GENERICINST
    // 018 __Marshaller_api_MarkFavoriteFesUnitArgs Marshaller`1<MarkFavoriteFesUnitArgs> IL2CPP_TYPE_GENERICINST
    // 020 __Marshaller_api_MarkFavoriteFesUnitReply Marshaller`1<MarkFavoriteFesUnitReply> IL2CPP_TYPE_GENERICINST
    // 028 __Marshaller_api_TransferFesUnitArgs     Marshaller`1<TransferFesUnitArgs> IL2CPP_TYPE_GENERICINST
    // 030 __Marshaller_api_TransferFesUnitReply    Marshaller`1<TransferFesUnitReply> IL2CPP_TYPE_GENERICINST
    // 038 __Marshaller_api_SetFesUnitNameArgs      Marshaller`1<SetFesUnitNameArgs> IL2CPP_TYPE_GENERICINST
    // 040 __Marshaller_api_SetFesUnitNameReply     Marshaller`1<SetFesUnitNameReply> IL2CPP_TYPE_GENERICINST
    // 048 __Marshaller_api_GetFesUnitIDListUsingForPvpEventArgs Marshaller`1<GetFesUnitIDListUsingForPvpEventArgs> IL2CPP_TYPE_GENERICINST
    // 050 __Marshaller_api_GetFesUnitIDListUsingForPvpEventReply Marshaller`1<GetFesUnitIDListUsingForPvpEventReply> IL2CPP_TYPE_GENERICINST
    // 058 __Method_GetFesUnitList                  Method`2<GetFesUnitListArgs, GetFesUnitListReply> IL2CPP_TYPE_GENERICINST
    // 060 __Method_MarkFavoriteFesUnit             Method`2<MarkFavoriteFesUnitArgs, MarkFavoriteFesUnitReply> IL2CPP_TYPE_GENERICINST
    // 068 __Method_TransferFesUnit                 Method`2<TransferFesUnitArgs, TransferFesUnitReply> IL2CPP_TYPE_GENERICINST
    // 070 __Method_SetFesUnitName                  Method`2<SetFesUnitNameArgs, SetFesUnitNameReply> IL2CPP_TYPE_GENERICINST
    // 078 __Method_GetFesUnitIDListUsingForPvpEvent Method`2<GetFesUnitIDListUsingForPvpEventArgs, GetFesUnitIDListUsingForPvpEventReply> IL2CPP_TYPE_GENERICINST
    public partial class FesUnitService
    {

        public static FesUnitService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FesUnitService();


            return value;
        }
    }
}
