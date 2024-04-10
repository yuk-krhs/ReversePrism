using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 GetFesUnitList                           Method`2<IGetFesUnitListArgs, IGetFesUnitListReply> IL2CPP_TYPE_GENERICINST
    // 018 MarkFavoriteFesUnit                      Method`2<IMarkFavoriteFesUnitArgs, IMarkFavoriteFesUnitReply> IL2CPP_TYPE_GENERICINST
    // 030 TransferFesUnit                          Method`2<ITransferFesUnitArgs, ITransferFesUnitReply> IL2CPP_TYPE_GENERICINST
    // 048 SetFesUnitName                           Method`2<ISetFesUnitNameArgs, ISetFesUnitNameReply> IL2CPP_TYPE_GENERICINST
    // 060 GetFesUnitIDListUsingForPvpEvent         Method`2<IGetFesUnitIDListUsingForPvpEventArgs, IGetFesUnitIDListUsingForPvpEventReply> IL2CPP_TYPE_GENERICINST
    public partial class FesUnitServiceMethods : DataModel
    {

        public static FesUnitServiceMethods? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FesUnitServiceMethods() { Pointer= p0 };


            return value;
        }
    }
}
