using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<CharacterBirthdayADVStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstCharacterBirthdayAdvIdFieldNumber     int IL2CPP_TYPE_I4
    // 018 MstCharacterBirthdayAdvId                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstCharacterInfoIdFieldNumber            int IL2CPP_TYPE_I4
    // 01C MstCharacterInfoId                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ResourceIdFieldNumber                    int IL2CPP_TYPE_I4
    // 020 ResourceId                               000186671910 ModelPrimitiveType string string string String
    public partial class CharacterBirthdayADVStatus
    {
        public int                                      MstCharacterBirthdayAdvId               { get; set; }
        public int                                      MstCharacterInfoId                      { get; set; }
        public string                                   ResourceId                              { get; set; }

        public static CharacterBirthdayADVStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CharacterBirthdayADVStatus();

            value.MstCharacterBirthdayAdvId                 = GetInt32(new IntPtr(p + 0x018)); // 0270D1987D10 0x18 MstCharacterBirthdayAdvId   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstCharacterInfoId                        = GetInt32(new IntPtr(p + 0x01C)); // 0270D1987D50 0x1C MstCharacterInfoId          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ResourceId                                = GetString(new IntPtr(p + 0x020)); // 0270D1987D90 0x20 ResourceId                  ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
