using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 __ServiceName                            string IL2CPP_TYPE_STRING
    // 008 __Marshaller_api_GetFesIdolListArgs      Marshaller`1<GetFesIdolListArgs> IL2CPP_TYPE_GENERICINST
    // 010 __Marshaller_api_GetFesIdolListReply     Marshaller`1<GetFesIdolListReply> IL2CPP_TYPE_GENERICINST
    // 018 __Marshaller_api_MarkFavoriteFesIdolArgs Marshaller`1<MarkFavoriteFesIdolArgs> IL2CPP_TYPE_GENERICINST
    // 020 __Marshaller_api_MarkFavoriteFesIdolReply Marshaller`1<MarkFavoriteFesIdolReply> IL2CPP_TYPE_GENERICINST
    // 028 __Marshaller_api_TransferFesIdolArgs     Marshaller`1<TransferFesIdolArgs> IL2CPP_TYPE_GENERICINST
    // 030 __Marshaller_api_TransferFesIdolReply    Marshaller`1<TransferFesIdolReply> IL2CPP_TYPE_GENERICINST
    // 038 __Method_GetFesIdolList                  Method`2<GetFesIdolListArgs, GetFesIdolListReply> IL2CPP_TYPE_GENERICINST
    // 040 __Method_MarkFavoriteFesIdol             Method`2<MarkFavoriteFesIdolArgs, MarkFavoriteFesIdolReply> IL2CPP_TYPE_GENERICINST
    // 048 __Method_TransferFesIdol                 Method`2<TransferFesIdolArgs, TransferFesIdolReply> IL2CPP_TYPE_GENERICINST
    public partial class FesIdolService
    {

        public static FesIdolService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FesIdolService();


            return value;
        }
    }
}
