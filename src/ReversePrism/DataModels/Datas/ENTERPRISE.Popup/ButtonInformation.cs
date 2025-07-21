using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ID                                       ModelPrimitiveType int int int Int32
    // 014 IsEnable                                 ModelPrimitiveType bool bool bool Bool
    // 018 Type                                     ModelEnumType PopupButtonType PopupButtonType PopupButtonType Int32
    // 020 ClickSE                                  ModelEnumType SoundKey SoundKey SoundKey Int32
    // 030 TextKey                                  ModelPrimitiveType string string string String
    // 038 IsDefaultTarget                          ModelPrimitiveType bool bool bool Bool
    // 000 OK                                       string IL2CPP_TYPE_STRING
    // 008 Close                                    string IL2CPP_TYPE_STRING
    // 010 Cancel                                   ModelPrimitiveType string string string String
    // 018 No                                       ModelPrimitiveType string string string String
    // 020 Yes                                      ModelPrimitiveType string string string String
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

            value.ID                                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 ID                          ( ModelPrimitiveType int int int Int32 )
            value.IsEnable                                  = GetBool(new IntPtr(p + 0x014)); // 0x14 IsEnable                    ( ModelPrimitiveType bool bool bool Bool )
            value.Type                                      = (PopupButtonType)GetInt32(new IntPtr(p + 0x018)); // 0x18 Type                        ( ModelEnumType PopupButtonType PopupButtonType PopupButtonType Int32 )
            value.ClickSE                                   = (SoundKey)GetInt32(new IntPtr(p + 0x020)); // 0x20 ClickSE                     ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.TextKey                                   = GetString(new IntPtr(p + 0x030)); // 0x30 TextKey                     ( ModelPrimitiveType string string string String )
            value.IsDefaultTarget                           = GetBool(new IntPtr(p + 0x038)); // 0x38 IsDefaultTarget             ( ModelPrimitiveType bool bool bool Bool )
            value.Cancel                                    = GetString(new IntPtr(p + 0x010)); // 0x10 Cancel                      ( ModelPrimitiveType string string string String )
            value.No                                        = GetString(new IntPtr(p + 0x018)); // 0x18 No                          ( ModelPrimitiveType string string string String )
            value.Yes                                       = GetString(new IntPtr(p + 0x020)); // 0x20 Yes                         ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
