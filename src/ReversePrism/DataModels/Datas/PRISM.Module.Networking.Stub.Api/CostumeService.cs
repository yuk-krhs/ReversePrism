using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 __ServiceName                            string IL2CPP_TYPE_STRING
    // 008 __Marshaller_api_GetCostumeListArgs      Marshaller`1<GetCostumeListArgs> IL2CPP_TYPE_GENERICINST
    // 010 __Marshaller_api_GetCostumeListReply     Marshaller`1<GetCostumeListReply> IL2CPP_TYPE_GENERICINST
    // 018 __Marshaller_api_GetCostumePresetListArgs Marshaller`1<GetCostumePresetListArgs> IL2CPP_TYPE_GENERICINST
    // 020 __Marshaller_api_GetCostumePresetListReply Marshaller`1<GetCostumePresetListReply> IL2CPP_TYPE_GENERICINST
    // 028 __Marshaller_api_SetCostumePresetArgs    Marshaller`1<SetCostumePresetArgs> IL2CPP_TYPE_GENERICINST
    // 030 __Marshaller_api_SetCostumePresetReply   Marshaller`1<SetCostumePresetReply> IL2CPP_TYPE_GENERICINST
    // 038 __Marshaller_api_SetCostumePresetNameArgs Marshaller`1<SetCostumePresetNameArgs> IL2CPP_TYPE_GENERICINST
    // 040 __Marshaller_api_SetCostumePresetNameReply Marshaller`1<SetCostumePresetNameReply> IL2CPP_TYPE_GENERICINST
    // 048 __Marshaller_api_ClearCostumePresetArgs  Marshaller`1<ClearCostumePresetArgs> IL2CPP_TYPE_GENERICINST
    // 050 __Marshaller_api_ClearCostumePresetReply Marshaller`1<ClearCostumePresetReply> IL2CPP_TYPE_GENERICINST
    // 058 __Method_GetCostumeList                  Method`2<GetCostumeListArgs, GetCostumeListReply> IL2CPP_TYPE_GENERICINST
    // 060 __Method_GetCostumePresetList            Method`2<GetCostumePresetListArgs, GetCostumePresetListReply> IL2CPP_TYPE_GENERICINST
    // 068 __Method_SetCostumePreset                Method`2<SetCostumePresetArgs, SetCostumePresetReply> IL2CPP_TYPE_GENERICINST
    // 070 __Method_SetCostumePresetName            Method`2<SetCostumePresetNameArgs, SetCostumePresetNameReply> IL2CPP_TYPE_GENERICINST
    // 078 __Method_ClearCostumePreset              Method`2<ClearCostumePresetArgs, ClearCostumePresetReply> IL2CPP_TYPE_GENERICINST
    public partial class CostumeService : DataModel
    {

        public static CostumeService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CostumeService() { Pointer= p0 };


            return value;
        }
    }
}
