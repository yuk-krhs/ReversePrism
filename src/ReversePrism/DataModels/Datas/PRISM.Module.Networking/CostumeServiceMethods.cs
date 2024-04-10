using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 GetCostumeList                           Method`2<IGetCostumeListArgs, IGetCostumeListReply> IL2CPP_TYPE_GENERICINST
    // 018 GetCostumePresetList                     Method`2<IGetCostumePresetListArgs, IGetCostumePresetListReply> IL2CPP_TYPE_GENERICINST
    // 030 SetCostumePreset                         Method`2<ISetCostumePresetArgs, ISetCostumePresetReply> IL2CPP_TYPE_GENERICINST
    // 048 SetCostumePresetName                     Method`2<ISetCostumePresetNameArgs, ISetCostumePresetNameReply> IL2CPP_TYPE_GENERICINST
    // 060 ClearCostumePreset                       Method`2<IClearCostumePresetArgs, IClearCostumePresetReply> IL2CPP_TYPE_GENERICINST
    public partial class CostumeServiceMethods : DataModel
    {

        public static CostumeServiceMethods? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CostumeServiceMethods() { Pointer= p0 };


            return value;
        }
    }
}
