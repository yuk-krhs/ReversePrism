using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 __ServiceName                            string IL2CPP_TYPE_STRING
    // 008 __Marshaller_api_RecordTimeArgs          Marshaller`1<RecordTimeArgs> IL2CPP_TYPE_GENERICINST
    // 010 __Marshaller_api_RecordTimeReply         Marshaller`1<RecordTimeReply> IL2CPP_TYPE_GENERICINST
    // 018 __Marshaller_api_GetSelfArgs             Marshaller`1<GetSelfArgs> IL2CPP_TYPE_GENERICINST
    // 020 __Marshaller_api_GetSelfReply            Marshaller`1<GetSelfReply> IL2CPP_TYPE_GENERICINST
    // 028 __Marshaller_api_GetProfileArgs          Marshaller`1<GetProfileArgs> IL2CPP_TYPE_GENERICINST
    // 030 __Marshaller_api_GetProfileReply         Marshaller`1<GetProfileReply> IL2CPP_TYPE_GENERICINST
    // 038 __Marshaller_api_SearchUserArgs          Marshaller`1<SearchUserArgs> IL2CPP_TYPE_GENERICINST
    // 040 __Marshaller_api_SearchUserReply         Marshaller`1<SearchUserReply> IL2CPP_TYPE_GENERICINST
    // 048 __Method_RecordTime                      Method`2<RecordTimeArgs, RecordTimeReply> IL2CPP_TYPE_GENERICINST
    // 050 __Method_GetSelf                         Method`2<GetSelfArgs, GetSelfReply> IL2CPP_TYPE_GENERICINST
    // 058 __Method_GetProfile                      Method`2<GetProfileArgs, GetProfileReply> IL2CPP_TYPE_GENERICINST
    // 060 __Method_SearchUser                      Method`2<SearchUserArgs, SearchUserReply> IL2CPP_TYPE_GENERICINST
    public partial class UserService : DataModel
    {

        public static UserService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UserService() { Pointer= p0 };


            return value;
        }
    }
}
