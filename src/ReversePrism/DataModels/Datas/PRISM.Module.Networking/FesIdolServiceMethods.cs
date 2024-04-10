using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 GetFesIdolList                           Method`2<IGetFesIdolListArgs, IGetFesIdolListReply> IL2CPP_TYPE_GENERICINST
    // 018 MarkFavoriteFesIdol                      Method`2<IMarkFavoriteFesIdolArgs, IMarkFavoriteFesIdolReply> IL2CPP_TYPE_GENERICINST
    // 030 TransferFesIdol                          Method`2<ITransferFesIdolArgs, ITransferFesIdolReply> IL2CPP_TYPE_GENERICINST
    public partial class FesIdolServiceMethods : DataModel
    {

        public static FesIdolServiceMethods? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FesIdolServiceMethods() { Pointer= p0 };


            return value;
        }
    }
}
