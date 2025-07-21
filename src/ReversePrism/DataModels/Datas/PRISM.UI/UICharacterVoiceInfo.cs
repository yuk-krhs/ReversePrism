using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MstCharacterInfoId                       ModelPrimitiveType int int int Int32
    // 018 CharaName                                ModelPrimitiveType string string string String
    // 020 UnitIdol                                 ModelClassType UnitIdol UnitIdol UnitIdol Pointer
    // 028 VoicePattern                             ModelClassType UICharacterVoicePattern UICharacterVoicePattern UICharacterVoicePattern Pointer
    public partial class UICharacterVoiceInfo : DataModel
    {
        public int                                      MstCharacterInfoId                      { get; set; }
        public string                                   CharaName                               { get; set; }
        public UnitIdol?                                UnitIdol                                { get; set; }
        public UICharacterVoicePattern?                 VoicePattern                            { get; set; }

        public static UICharacterVoiceInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UICharacterVoiceInfo() { Pointer= p0 };

            value.MstCharacterInfoId                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 MstCharacterInfoId          ( ModelPrimitiveType int int int Int32 )
            value.CharaName                                 = GetString(new IntPtr(p + 0x018)); // 0x18 CharaName                   ( ModelPrimitiveType string string string String )
            value.UnitIdol                                  = GetObject<UnitIdol>(new IntPtr(p + 0x020), ReversePrism.DataModels.UnitIdol.FromPointer); // 0x20 UnitIdol                    ( ModelClassType UnitIdol UnitIdol UnitIdol Pointer )
            value.VoicePattern                              = GetObject<UICharacterVoicePattern>(new IntPtr(p + 0x028), ReversePrism.DataModels.UICharacterVoicePattern.FromPointer); // 0x28 VoicePattern                ( ModelClassType UICharacterVoicePattern UICharacterVoicePattern UICharacterVoicePattern Pointer )

            return value;
        }
    }
}
