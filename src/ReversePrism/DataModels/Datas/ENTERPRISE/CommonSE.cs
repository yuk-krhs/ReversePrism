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
    public partial class CommonSE
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
            var value   = new CommonSE();

            value.Cancel                                    = (SoundKey)GetInt32(new IntPtr(p + 0x010)); // 0270040400F8 0x10 Cancel                      ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.PopupOpen                                 = (SoundKey)GetInt32(new IntPtr(p + 0x020)); // 027004040118 0x20 PopupOpen                   ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.RewardPopupOpen                           = (SoundKey)GetInt32(new IntPtr(p + 0x030)); // 027004040138 0x30 RewardPopupOpen             ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.Select                                    = (SoundKey)GetInt32(new IntPtr(p + 0x040)); // 027004040158 0x40 Select                      ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.Swipe                                     = (SoundKey)GetInt32(new IntPtr(p + 0x050)); // 027004040178 0x50 Swipe                       ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.TapTab                                    = (SoundKey)GetInt32(new IntPtr(p + 0x060)); // 027004040198 0x60 TapTab                      ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.TouchStart                                = (SoundKey)GetInt32(new IntPtr(p + 0x070)); // 0270040401B8 0x70 TouchStart                  ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.LongPress                                 = (SoundKey)GetInt32(new IntPtr(p + 0x080)); // 0270040401D8 0x80 LongPress                   ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.NoticeDM                                  = (SoundKey)GetInt32(new IntPtr(p + 0x090)); // 0270040401F8 0x90 NoticeDM                    ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.NoticeNG                                  = (SoundKey)GetInt32(new IntPtr(p + 0x0A0)); // 027004040218 0xA0 NoticeNG                    ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.Inactive                                  = (SoundKey)GetInt32(new IntPtr(p + 0x0B0)); // 027004040238 0xB0 Inactive                    ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ViewClose                                 = (SoundKey)GetInt32(new IntPtr(p + 0x0C0)); // 027004040258 0xC0 ViewClose                   ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ErrorModal                                = (SoundKey)GetInt32(new IntPtr(p + 0x0D0)); // 027004040278 0xD0 ErrorModal                  ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.Toggle                                    = (SoundKey)GetInt32(new IntPtr(p + 0x0E0)); // 027004040298 0xE0 Toggle                      ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.UnitSlide                                 = (SoundKey)GetInt32(new IntPtr(p + 0x0F0)); // 0270040402B8 0xF0 UnitSlide                   ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )

            return value;
        }
    }
}
