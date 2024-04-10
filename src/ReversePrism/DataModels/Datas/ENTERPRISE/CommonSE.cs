using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 SheetName                                string IL2CPP_TYPE_STRING
    // 000 Decide                                   SoundKey IL2CPP_TYPE_VALUETYPE
    // 010 Cancel                                   000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 020 PopupOpen                                000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 030 RewardPopupOpen                          000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 040 Select                                   000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 050 Swipe                                    000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 060 TapTab                                   000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 070 TouchStart                               000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 080 LongPress                                000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 090 NoticeDM                                 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 0A0 NoticeNG                                 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 0B0 Inactive                                 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 0C0 ViewClose                                000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 0D0 ErrorModal                               000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 0E0 Toggle                                   000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 0F0 UnitSlide                                000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    public partial class CommonSE : DataModel
    {
        public SoundKey                                 Cancel                                  { get; set; }
        public SoundKey                                 PopupOpen                               { get; set; }
        public SoundKey                                 RewardPopupOpen                         { get; set; }
        public SoundKey                                 Select                                  { get; set; }
        public SoundKey                                 Swipe                                   { get; set; }
        public SoundKey                                 TapTab                                  { get; set; }
        public SoundKey                                 TouchStart                              { get; set; }
        public SoundKey                                 LongPress                               { get; set; }
        public SoundKey                                 NoticeDM                                { get; set; }
        public SoundKey                                 NoticeNG                                { get; set; }
        public SoundKey                                 Inactive                                { get; set; }
        public SoundKey                                 ViewClose                               { get; set; }
        public SoundKey                                 ErrorModal                              { get; set; }
        public SoundKey                                 Toggle                                  { get; set; }
        public SoundKey                                 UnitSlide                               { get; set; }

        public static CommonSE? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CommonSE() { Pointer= p0 };

            value.Cancel                                    = (SoundKey)GetInt32(new IntPtr(p + 0x010)); // 0245A4036AF0 0x10 Cancel                      ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.PopupOpen                                 = (SoundKey)GetInt32(new IntPtr(p + 0x020)); // 0245A4036B10 0x20 PopupOpen                   ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.RewardPopupOpen                           = (SoundKey)GetInt32(new IntPtr(p + 0x030)); // 0245A4036B30 0x30 RewardPopupOpen             ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.Select                                    = (SoundKey)GetInt32(new IntPtr(p + 0x040)); // 0245A4036B50 0x40 Select                      ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.Swipe                                     = (SoundKey)GetInt32(new IntPtr(p + 0x050)); // 0245A4036B70 0x50 Swipe                       ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.TapTab                                    = (SoundKey)GetInt32(new IntPtr(p + 0x060)); // 0245A4036B90 0x60 TapTab                      ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.TouchStart                                = (SoundKey)GetInt32(new IntPtr(p + 0x070)); // 0245A4036BB0 0x70 TouchStart                  ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.LongPress                                 = (SoundKey)GetInt32(new IntPtr(p + 0x080)); // 0245A4036BD0 0x80 LongPress                   ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.NoticeDM                                  = (SoundKey)GetInt32(new IntPtr(p + 0x090)); // 0245A4036BF0 0x90 NoticeDM                    ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.NoticeNG                                  = (SoundKey)GetInt32(new IntPtr(p + 0x0A0)); // 0245A4036C10 0xA0 NoticeNG                    ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.Inactive                                  = (SoundKey)GetInt32(new IntPtr(p + 0x0B0)); // 0245A4036C30 0xB0 Inactive                    ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ViewClose                                 = (SoundKey)GetInt32(new IntPtr(p + 0x0C0)); // 0245A4036C50 0xC0 ViewClose                   ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ErrorModal                                = (SoundKey)GetInt32(new IntPtr(p + 0x0D0)); // 0245A4036C70 0xD0 ErrorModal                  ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.Toggle                                    = (SoundKey)GetInt32(new IntPtr(p + 0x0E0)); // 0245A4036C90 0xE0 Toggle                      ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.UnitSlide                                 = (SoundKey)GetInt32(new IntPtr(p + 0x0F0)); // 0245A4036CB0 0xF0 UnitSlide                   ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )

            return value;
        }
    }
}
