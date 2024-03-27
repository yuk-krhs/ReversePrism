using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<CharacterCostumeStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 CharaIdFieldNumber                       int IL2CPP_TYPE_I4
    // 018 CharaId                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 HairIdFieldNumber                        int IL2CPP_TYPE_I4
    // 01C HairId                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ClothIdFieldNumber                       int IL2CPP_TYPE_I4
    // 020 ClothId                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 AccessoryIdListFieldNumber               int IL2CPP_TYPE_I4
    // 008 _repeated_accessoryIdList_codec          FieldCodec`1<int> IL2CPP_TYPE_GENERICINST
    // 028 AccessoryIdList                          000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer
    public partial class CharacterCostumeStatus
    {
        public int                                      CharaId                                 { get; set; }
        public int                                      HairId                                  { get; set; }
        public int                                      ClothId                                 { get; set; }
        public List<int>?                               AccessoryIdList                         { get; set; }

        public static CharacterCostumeStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CharacterCostumeStatus();

            value.CharaId                                   = GetInt32(new IntPtr(p + 0x018)); // 0270D0F4C660 0x18 CharaId                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.HairId                                    = GetInt32(new IntPtr(p + 0x01C)); // 0270D0F4C6A0 0x1C HairId                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ClothId                                   = GetInt32(new IntPtr(p + 0x020)); // 0270D0F4C6E0 0x20 ClothId                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.AccessoryIdList                           = GetInt32List(new IntPtr(p + 0x028)); // 0270D0F4C740 0x28 AccessoryIdList             ( 000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer )

            return value;
        }
    }
}
