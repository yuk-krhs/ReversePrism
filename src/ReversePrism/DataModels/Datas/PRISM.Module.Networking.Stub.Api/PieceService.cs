using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 __ServiceName                            string IL2CPP_TYPE_STRING
    // 008 __Marshaller_api_GetPieceListArgs        Marshaller`1<GetPieceListArgs> IL2CPP_TYPE_GENERICINST
    // 010 __Marshaller_api_GetPieceListReply       Marshaller`1<GetPieceListReply> IL2CPP_TYPE_GENERICINST
    // 018 __Marshaller_api_ConvertPieceListArgs    Marshaller`1<ConvertPieceListArgs> IL2CPP_TYPE_GENERICINST
    // 020 __Marshaller_api_ConvertPieceListReply   Marshaller`1<ConvertPieceListReply> IL2CPP_TYPE_GENERICINST
    // 028 __Method_GetPieceList                    Method`2<GetPieceListArgs, GetPieceListReply> IL2CPP_TYPE_GENERICINST
    // 030 __Method_ConvertPieceList                Method`2<ConvertPieceListArgs, ConvertPieceListReply> IL2CPP_TYPE_GENERICINST
    public partial class PieceService
    {

        public static PieceService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PieceService();


            return value;
        }
    }
}
