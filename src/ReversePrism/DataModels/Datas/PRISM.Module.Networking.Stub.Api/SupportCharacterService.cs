using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 __ServiceName                            string IL2CPP_TYPE_STRING
    // 008 __Marshaller_api_GetSupportCharacterListArgs Marshaller`1<GetSupportCharacterListArgs> IL2CPP_TYPE_GENERICINST
    // 010 __Marshaller_api_GetSupportCharacterListReply Marshaller`1<GetSupportCharacterListReply> IL2CPP_TYPE_GENERICINST
    // 018 __Marshaller_api_TrainingSupportCharacterArgs Marshaller`1<TrainingSupportCharacterArgs> IL2CPP_TYPE_GENERICINST
    // 020 __Marshaller_api_TrainingSupportCharacterReply Marshaller`1<TrainingSupportCharacterReply> IL2CPP_TYPE_GENERICINST
    // 028 __Marshaller_api_MasterTrainingSupportCharacterArgs Marshaller`1<MasterTrainingSupportCharacterArgs> IL2CPP_TYPE_GENERICINST
    // 030 __Marshaller_api_MasterTrainingSupportCharacterReply Marshaller`1<MasterTrainingSupportCharacterReply> IL2CPP_TYPE_GENERICINST
    // 038 __Marshaller_api_MarkFavoriteSupportCharacterArgs Marshaller`1<MarkFavoriteSupportCharacterArgs> IL2CPP_TYPE_GENERICINST
    // 040 __Marshaller_api_MarkFavoriteSupportCharacterReply Marshaller`1<MarkFavoriteSupportCharacterReply> IL2CPP_TYPE_GENERICINST
    // 048 __Method_GetSupportCharacterList         Method`2<GetSupportCharacterListArgs, GetSupportCharacterListReply> IL2CPP_TYPE_GENERICINST
    // 050 __Method_TrainingSupportCharacter        Method`2<TrainingSupportCharacterArgs, TrainingSupportCharacterReply> IL2CPP_TYPE_GENERICINST
    // 058 __Method_MasterTrainingSupportCharacter  Method`2<MasterTrainingSupportCharacterArgs, MasterTrainingSupportCharacterReply> IL2CPP_TYPE_GENERICINST
    // 060 __Method_MarkFavoriteSupportCharacter    Method`2<MarkFavoriteSupportCharacterArgs, MarkFavoriteSupportCharacterReply> IL2CPP_TYPE_GENERICINST
    public partial class SupportCharacterService : DataModel
    {

        public static SupportCharacterService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportCharacterService() { Pointer= p0 };


            return value;
        }
    }
}
