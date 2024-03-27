using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 GetVersion                               Method`2<IGetVersionArgs, IGetVersionReply> IL2CPP_TYPE_GENERICINST
    // 018 GetDmmGamesAPIToken                      Method`2<IGetDmmGamesAPITokenArgs, IGetDmmGamesAPITokenReply> IL2CPP_TYPE_GENERICINST
    public partial class GameServiceMethods
    {

        public static GameServiceMethods? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GameServiceMethods();


            return value;
        }
    }
}
