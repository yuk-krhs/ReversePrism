using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 GetSupportCharacterList                  Method`2<IGetSupportCharacterListArgs, IGetSupportCharacterListReply> IL2CPP_TYPE_GENERICINST
    // 018 TrainingSupportCharacter                 Method`2<ITrainingSupportCharacterArgs, ITrainingSupportCharacterReply> IL2CPP_TYPE_GENERICINST
    // 030 MasterTrainingSupportCharacter           Method`2<IMasterTrainingSupportCharacterArgs, IMasterTrainingSupportCharacterReply> IL2CPP_TYPE_GENERICINST
    // 048 MarkFavoriteSupportCharacter             Method`2<IMarkFavoriteSupportCharacterArgs, IMarkFavoriteSupportCharacterReply> IL2CPP_TYPE_GENERICINST
    public partial class SupportCharacterServiceMethods
    {

        public static SupportCharacterServiceMethods? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportCharacterServiceMethods();


            return value;
        }
    }
}
