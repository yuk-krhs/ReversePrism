using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     00018658B490 ModelEnumType PopupButtonType PopupButtonType PopupButtonType Int32
    // 014 IsEnable                                 0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 018 ClickSE                                  0001865366F0 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 028 <TextKey>k__BackingField                 ValueTuple`2<string, int> IL2CPP_TYPE_GENERICINST
    // 038 OnClick                                  00018667A3C0 ModelClassType Action Action Action Pointer
    public partial class ButtonInfoParameter
    {
        public PopupButtonType                          Type                                    { get; set; }
        public bool                                     IsEnable                                { get; set; }
        public SoundKey                                 ClickSE                                 { get; set; }
        public Action?                                  OnClick                                 { get; set; }

        public static ButtonInfoParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ButtonInfoParameter();

            value.Type                                      = (PopupButtonType)GetInt32(new IntPtr(p + 0x010)); // 0270DA307328 0x10 Type                        ( 00018658B490 ModelEnumType PopupButtonType PopupButtonType PopupButtonType Int32 )
            value.IsEnable                                  = GetBool(new IntPtr(p + 0x014)); // 0270DA307348 0x14 IsEnable                    ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.ClickSE                                   = (SoundKey)GetInt32(new IntPtr(p + 0x018)); // 0270DA307368 0x18 ClickSE                     ( 0001865366F0 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.OnClick                                   = GetObject<Action>(new IntPtr(p + 0x038), ReversePrism.DataModels.Action.FromPointer); // 0270DA3073A8 0x38 OnClick                     ( 00018667A3C0 ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
