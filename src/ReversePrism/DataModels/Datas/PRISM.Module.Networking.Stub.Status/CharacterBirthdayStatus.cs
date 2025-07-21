using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<CharacterBirthdayStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 AdvListFieldNumber                       int IL2CPP_TYPE_I4
    // 008 _repeated_advList_codec                  FieldCodec`1<CharacterBirthdayADVStatus> IL2CPP_TYPE_GENERICINST
    // 018 AdvList                                  ModelClassListType RepeatedField`1<CharacterBirthdayADVStatus> RepeatedField`1<CharacterBirthdayADVStatus> List<CharacterBirthdayADVStatus> Pointer
    public partial class CharacterBirthdayStatus : DataModel
    {
        public List<CharacterBirthdayADVStatus>?        AdvList                                 { get; set; }

        public static CharacterBirthdayStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CharacterBirthdayStatus() { Pointer= p0 };

            value.AdvList                                   = GetObjectList<CharacterBirthdayADVStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.CharacterBirthdayADVStatus.FromPointer); // 0x18 AdvList                     ( ModelClassListType RepeatedField`1<CharacterBirthdayADVStatus> RepeatedField`1<CharacterBirthdayADVStatus> List<CharacterBirthdayADVStatus> Pointer )

            return value;
        }
    }
}
