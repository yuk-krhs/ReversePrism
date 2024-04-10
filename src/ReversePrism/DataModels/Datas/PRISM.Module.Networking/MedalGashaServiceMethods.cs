using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 GetMedalGasha                            Method`2<IGetMedalGashaArgs, IGetMedalGashaReply> IL2CPP_TYPE_GENERICINST
    // 018 DrawMedalGasha                           Method`2<IDrawMedalGashaArgs, IDrawMedalGashaReply> IL2CPP_TYPE_GENERICINST
    // 030 NextMedalGashaBox                        Method`2<INextMedalGashaBoxArgs, INextMedalGashaBoxReply> IL2CPP_TYPE_GENERICINST
    public partial class MedalGashaServiceMethods : DataModel
    {

        public static MedalGashaServiceMethods? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MedalGashaServiceMethods() { Pointer= p0 };


            return value;
        }
    }
}
