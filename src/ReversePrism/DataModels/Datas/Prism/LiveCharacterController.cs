using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 MAX_CHARACTER                            int IL2CPP_TYPE_I4
    // 020 Characters                               000185B74CD0 ModelClassListType Character[] Character[] List<Character> Pointer
    // 000 characterAnimName                        string[] IL2CPP_TYPE_SZARRAY
    // 008 characterPosition                        Vector3[] IL2CPP_TYPE_SZARRAY
    // 010 CharacterLipSyncName                     000185B81AC0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 018 CharacterRotationY                       000185B80A20 ModelPrimitiveListType float[] float[] List<float> Pointer
    // 020 CharacterRecordedAnimName                000185B81AC0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 028 LiveOffsetTime                           000186666300 ModelPrimitiveType float float float Single
    public partial class LiveCharacterController
    {
        public List<Character>?                         Characters                              { get; set; }
        public List<string>?                            CharacterLipSyncName                    { get; set; }
        public List<float>?                             CharacterRotationY                      { get; set; }
        public List<string>?                            CharacterRecordedAnimName               { get; set; }
        public float                                    LiveOffsetTime                          { get; set; }

        public static LiveCharacterController? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveCharacterController();

            value.Characters                                = GetObjectList<Character>(new IntPtr(p + 0x020), ReversePrism.DataModels.Character.FromPointer); // 0270069A8788 0x20 Characters                  ( 000185B74CD0 ModelClassListType Character[] Character[] List<Character> Pointer )
            value.CharacterLipSyncName                      = GetStringList(new IntPtr(p + 0x010)); // 0270069A87E8 0x10 CharacterLipSyncName        ( 000185B81AC0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.CharacterRotationY                        = GetSingleList(new IntPtr(p + 0x018)); // 0270069A8808 0x18 CharacterRotationY          ( 000185B80A20 ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.CharacterRecordedAnimName                 = GetStringList(new IntPtr(p + 0x020)); // 0270069A8828 0x20 CharacterRecordedAnimName   ( 000185B81AC0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.LiveOffsetTime                            = GetSingle(new IntPtr(p + 0x028)); // 0270069A8848 0x28 LiveOffsetTime              ( 000186666300 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
