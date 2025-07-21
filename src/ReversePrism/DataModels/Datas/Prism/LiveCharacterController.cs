using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 MAX_CHARACTER                            int IL2CPP_TYPE_I4
    // 020 Characters                               ModelClassListType Character[] Character[] List<Character> Pointer
    // 028 LiveOffsetTime                           ModelPrimitiveType float float float Single
    // 030 CharacterCreateData                      ModelClassListType CharacterCreateData[] CharacterCreateData[] List<CharacterCreateData> Pointer
    public partial class LiveCharacterController : DataModel
    {
        public List<Character>?                         Characters                              { get; set; }
        public float                                    LiveOffsetTime                          { get; set; }
        public List<CharacterCreateData>?               CharacterCreateData                     { get; set; }

        public static LiveCharacterController? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveCharacterController() { Pointer= p0 };

            value.Characters                                = GetObjectList<Character>(new IntPtr(p + 0x020), ReversePrism.DataModels.Character.FromPointer); // 0x20 Characters                  ( ModelClassListType Character[] Character[] List<Character> Pointer )
            value.LiveOffsetTime                            = GetSingle(new IntPtr(p + 0x028)); // 0x28 LiveOffsetTime              ( ModelPrimitiveType float float float Single )
            value.CharacterCreateData                       = GetObjectList<CharacterCreateData>(new IntPtr(p + 0x030), ReversePrism.DataModels.CharacterCreateData.FromPointer); // 0x30 CharacterCreateData         ( ModelClassListType CharacterCreateData[] CharacterCreateData[] List<CharacterCreateData> Pointer )

            return value;
        }
    }
}
