using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GashaPasserbyCharacterEffectStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstCharacterIdFieldNumber                int IL2CPP_TYPE_I4
    // 018 MstCharacterId                           ModelPrimitiveType int int int Int32
    // 000 MstCostumeSetIdFieldNumber               int IL2CPP_TYPE_I4
    // 01C MstCostumeSetId                          ModelPrimitiveType int int int Int32
    public partial class GashaPasserbyCharacterEffectStatus : DataModel
    {
        public int                                      MstCharacterId                          { get; set; }
        public int                                      MstCostumeSetId                         { get; set; }

        public static GashaPasserbyCharacterEffectStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaPasserbyCharacterEffectStatus() { Pointer= p0 };

            value.MstCharacterId                            = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstCharacterId              ( ModelPrimitiveType int int int Int32 )
            value.MstCostumeSetId                           = GetInt32(new IntPtr(p + 0x01C)); // 0x1C MstCostumeSetId             ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
