using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 LongTouchThreshold                       float IL2CPP_TYPE_R4
    // 020 IsInitialized                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 024 TouchDuration                            0001866656B0 ModelPrimitiveType float float float Single
    // 028 IsTouchCharacter                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 029 IsTouchOutOfRange                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 02A IsLongTouchCharacter                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 02B IsTouchAllRange                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 02C IsTouchNotPointerOverAllRange            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 02D IsReleaseCharacter                       000186594D10 ModelPrimitiveType bool bool bool Bool
    // 02E IsReleaseOutOfRange                      000186594D10 ModelPrimitiveType bool bool bool Bool
    // 02F IsReleaseAllRange                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 030 MainCamera                               0001865A1C90 ModelClassType Camera Camera Camera Pointer
    // 038 LayerMask                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 040 touchCharacterSubject                    Subject`1<Character> IL2CPP_TYPE_GENERICINST
    // 048 touchOutOfRangeSubject                   Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 050 longTouchSubject                         Subject`1<Character> IL2CPP_TYPE_GENERICINST
    // 058 touchAllRangeSubject                     Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 060 touchNotPointerOverAllRangeSubject       Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class CharacterTouchDetector : DataModel
    {
        public bool                                     IsInitialized                           { get; set; }
        public float                                    TouchDuration                           { get; set; }
        public bool                                     IsTouchCharacter                        { get; set; }
        public bool                                     IsTouchOutOfRange                       { get; set; }
        public bool                                     IsLongTouchCharacter                    { get; set; }
        public bool                                     IsTouchAllRange                         { get; set; }
        public bool                                     IsTouchNotPointerOverAllRange           { get; set; }
        public bool                                     IsReleaseCharacter                      { get; set; }
        public bool                                     IsReleaseOutOfRange                     { get; set; }
        public bool                                     IsReleaseAllRange                       { get; set; }
        public Camera?                                  MainCamera                              { get; set; }
        public int                                      LayerMask                               { get; set; }

        public static CharacterTouchDetector? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CharacterTouchDetector() { Pointer= p0 };

            value.IsInitialized                             = GetBool(new IntPtr(p + 0x020)); // 0245A4FA74F8 0x20 IsInitialized               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.TouchDuration                             = GetSingle(new IntPtr(p + 0x024)); // 0245A4FA7518 0x24 TouchDuration               ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.IsTouchCharacter                          = GetBool(new IntPtr(p + 0x028)); // 0245A4FA7538 0x28 IsTouchCharacter            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsTouchOutOfRange                         = GetBool(new IntPtr(p + 0x029)); // 0245A4FA7558 0x29 IsTouchOutOfRange           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsLongTouchCharacter                      = GetBool(new IntPtr(p + 0x02A)); // 0245A4FA7578 0x2A IsLongTouchCharacter        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsTouchAllRange                           = GetBool(new IntPtr(p + 0x02B)); // 0245A4FA7598 0x2B IsTouchAllRange             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsTouchNotPointerOverAllRange             = GetBool(new IntPtr(p + 0x02C)); // 0245A4FA75B8 0x2C IsTouchNotPointerOverAllRange ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsReleaseCharacter                        = GetBool(new IntPtr(p + 0x02D)); // 0245A4FA75D8 0x2D IsReleaseCharacter          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsReleaseOutOfRange                       = GetBool(new IntPtr(p + 0x02E)); // 0245A4FA75F8 0x2E IsReleaseOutOfRange         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsReleaseAllRange                         = GetBool(new IntPtr(p + 0x02F)); // 0245A4FA7618 0x2F IsReleaseAllRange           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.MainCamera                                = GetObject<Camera>(new IntPtr(p + 0x030), ReversePrism.DataModels.Camera.FromPointer); // 0245A4FA7638 0x30 MainCamera                  ( 0001865A1C90 ModelClassType Camera Camera Camera Pointer )
            value.LayerMask                                 = GetInt32(new IntPtr(p + 0x038)); // 0245A4FA7658 0x38 LayerMask                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
