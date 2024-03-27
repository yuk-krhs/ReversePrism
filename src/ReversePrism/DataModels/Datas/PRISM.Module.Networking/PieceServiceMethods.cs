using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 GetPieceList                             Method`2<IGetPieceListArgs, IGetPieceListReply> IL2CPP_TYPE_GENERICINST
    // 018 ConvertPieceList                         Method`2<IConvertPieceListArgs, IConvertPieceListReply> IL2CPP_TYPE_GENERICINST
    public partial class PieceServiceMethods
    {

        public static PieceServiceMethods? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PieceServiceMethods();


            return value;
        }
    }
}
