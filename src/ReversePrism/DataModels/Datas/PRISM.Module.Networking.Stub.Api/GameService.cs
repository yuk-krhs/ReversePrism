using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 __ServiceName                            string IL2CPP_TYPE_STRING
    // 008 __Marshaller_api_GetVersionArgs          Marshaller`1<GetVersionArgs> IL2CPP_TYPE_GENERICINST
    // 010 __Marshaller_api_GetVersionReply         Marshaller`1<GetVersionReply> IL2CPP_TYPE_GENERICINST
    // 018 __Marshaller_api_GetDmmGamesAPITokenArgs Marshaller`1<GetDmmGamesAPITokenArgs> IL2CPP_TYPE_GENERICINST
    // 020 __Marshaller_api_GetDmmGamesAPITokenReply Marshaller`1<GetDmmGamesAPITokenReply> IL2CPP_TYPE_GENERICINST
    // 028 __Method_GetVersion                      Method`2<GetVersionArgs, GetVersionReply> IL2CPP_TYPE_GENERICINST
    // 030 __Method_GetDmmGamesAPIToken             Method`2<GetDmmGamesAPITokenArgs, GetDmmGamesAPITokenReply> IL2CPP_TYPE_GENERICINST
    public partial class GameService : DataModel
    {

        public static GameService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GameService() { Pointer= p0 };


            return value;
        }
    }
}
