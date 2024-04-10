using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 DefaultCharacterPrefab                   0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 028 HeadTopName                              000186671910 ModelPrimitiveType string string string String
    // 030 EyeCleraName                             000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    public partial class CharacterRendering : DataModel
    {
        public GameObject?                              DefaultCharacterPrefab                  { get; set; }
        public string                                   HeadTopName                             { get; set; }
        public List<string>?                            EyeCleraName                            { get; set; }

        public static CharacterRendering? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CharacterRendering() { Pointer= p0 };

            value.DefaultCharacterPrefab                    = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 024664DD2688 0x20 DefaultCharacterPrefab      ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.HeadTopName                               = GetString(new IntPtr(p + 0x028)); // 024664DD26A8 0x28 HeadTopName                 ( 000186671910 ModelPrimitiveType string string string String )
            value.EyeCleraName                              = GetStringList(new IntPtr(p + 0x030)); // 024664DD26C8 0x30 EyeCleraName                ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
