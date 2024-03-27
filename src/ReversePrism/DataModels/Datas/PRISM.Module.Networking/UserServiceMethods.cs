using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 RecordTime                               Method`2<IRecordTimeArgs, IRecordTimeReply> IL2CPP_TYPE_GENERICINST
    // 018 GetSelf                                  Method`2<IGetSelfArgs, IGetSelfReply> IL2CPP_TYPE_GENERICINST
    // 030 GetProfile                               Method`2<IGetProfileArgs, IGetProfileReply> IL2CPP_TYPE_GENERICINST
    // 048 SearchUser                               Method`2<ISearchUserArgs, ISearchUserReply> IL2CPP_TYPE_GENERICINST
    public partial class UserServiceMethods
    {

        public static UserServiceMethods? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UserServiceMethods();


            return value;
        }
    }
}
