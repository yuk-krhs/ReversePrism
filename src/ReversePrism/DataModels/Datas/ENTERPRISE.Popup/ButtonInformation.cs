using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ID                                       0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 IsEnable                                 000186595960 ModelPrimitiveType bool bool bool Bool
    // 018 Type                                     000186761060 ModelEnumType PopupButtonType PopupButtonType PopupButtonType Int32
    // 020 ClickSE                                  000186536470 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 030 TextKey                                  0001866722E0 ModelPrimitiveType string string string String
    // 038 IsDefaultTarget                          000186595960 ModelPrimitiveType bool bool bool Bool
    // 000 OK                                       string IL2CPP_TYPE_STRING
    // 008 Close                                    string IL2CPP_TYPE_STRING
    // 010 Cancel                                   000186674040 ModelPrimitiveType string string string String
    // 018 No                                       000186674040 ModelPrimitiveType string string string String
    // 020 Yes                                      000186674040 ModelPrimitiveType string string string String
    public partial class ButtonInformation : DataModel
    {
        public int                                      ID                                      { get; set; }
        public bool                                     IsEnable                                { get; set; }
        public PopupButtonType                          Type                                    { get; set; }
        public SoundKey                                 ClickSE                                 { get; set; }
        public string                                   TextKey                                 { get; set; }
        public bool                                     IsDefaultTarget                         { get; set; }
        public string                                   Cancel                                  { get; set; }
        public string                                   No                                      { get; set; }
        public string                                   Yes                                     { get; set; }

        public static ButtonInformation? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ButtonInformation() { Pointer= p0 };

            value.ID                                        = GetInt32(new IntPtr(p + 0x010)); // 024664C8B610 0x10 ID                          ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.IsEnable                                  = GetBool(new IntPtr(p + 0x014)); // 024664C8B630 0x14 IsEnable                    ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.Type                                      = (PopupButtonType)GetInt32(new IntPtr(p + 0x018)); // 024664C8B650 0x18 Type                        ( 000186761060 ModelEnumType PopupButtonType PopupButtonType PopupButtonType Int32 )
            value.ClickSE                                   = (SoundKey)GetInt32(new IntPtr(p + 0x020)); // 024664C8B670 0x20 ClickSE                     ( 000186536470 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.TextKey                                   = GetString(new IntPtr(p + 0x030)); // 024664C8B690 0x30 TextKey                     ( 0001866722E0 ModelPrimitiveType string string string String )
            value.IsDefaultTarget                           = GetBool(new IntPtr(p + 0x038)); // 024664C8B6B0 0x38 IsDefaultTarget             ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.Cancel                                    = GetString(new IntPtr(p + 0x010)); // 024664C8B710 0x10 Cancel                      ( 000186674040 ModelPrimitiveType string string string String )
            value.No                                        = GetString(new IntPtr(p + 0x018)); // 024664C8B730 0x18 No                          ( 000186674040 ModelPrimitiveType string string string String )
            value.Yes                                       = GetString(new IntPtr(p + 0x020)); // 024664C8B750 0x20 Yes                         ( 000186674040 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
