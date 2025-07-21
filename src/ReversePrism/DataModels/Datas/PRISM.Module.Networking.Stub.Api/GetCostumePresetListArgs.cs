using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetCostumePresetListArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstIdolIdFieldNumber                     int IL2CPP_TYPE_I4
    // 018 MstIdolId                                ModelPrimitiveType int int int Int32
    // 000 PresetTypeFieldNumber                    int IL2CPP_TYPE_I4
    // 01C PresetType                               ModelEnumType CostumePresetType CostumePresetType CostumePresetType Int32
    public partial class GetCostumePresetListArgs : DataModel
    {
        public int                                      MstIdolId                               { get; set; }
        public CostumePresetType                        PresetType                              { get; set; }

        public static GetCostumePresetListArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetCostumePresetListArgs() { Pointer= p0 };

            value.MstIdolId                                 = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstIdolId                   ( ModelPrimitiveType int int int Int32 )
            value.PresetType                                = (CostumePresetType)GetInt32(new IntPtr(p + 0x01C)); // 0x1C PresetType                  ( ModelEnumType CostumePresetType CostumePresetType CostumePresetType Int32 )

            return value;
        }
    }
}
