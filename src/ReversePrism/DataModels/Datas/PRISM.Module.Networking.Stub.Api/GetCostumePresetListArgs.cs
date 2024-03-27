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
    // 018 MstIdolId                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 PresetTypeFieldNumber                    int IL2CPP_TYPE_I4
    // 01C PresetType                               000186630A70 ModelEnumType CostumePresetType CostumePresetType CostumePresetType Int32
    public partial class GetCostumePresetListArgs
    {
        public int                                      MstIdolId                               { get; set; }
        public CostumePresetType                        PresetType                              { get; set; }

        public static GetCostumePresetListArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetCostumePresetListArgs();

            value.MstIdolId                                 = GetInt32(new IntPtr(p + 0x018)); // 0270D0D78940 0x18 MstIdolId                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.PresetType                                = (CostumePresetType)GetInt32(new IntPtr(p + 0x01C)); // 0270D0D78980 0x1C PresetType                  ( 000186630A70 ModelEnumType CostumePresetType CostumePresetType CostumePresetType Int32 )

            return value;
        }
    }
}
