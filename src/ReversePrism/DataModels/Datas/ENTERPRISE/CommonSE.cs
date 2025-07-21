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
    // 010 Cancel                                   ModelEnumType SoundKey SoundKey SoundKey Int32
    // 020 PopupOpen                                ModelEnumType SoundKey SoundKey SoundKey Int32
    // 030 RewardPopupOpen                          ModelEnumType SoundKey SoundKey SoundKey Int32
    // 040 Select                                   ModelEnumType SoundKey SoundKey SoundKey Int32
    // 050 Swipe                                    ModelEnumType SoundKey SoundKey SoundKey Int32
    // 060 TapTab                                   ModelEnumType SoundKey SoundKey SoundKey Int32
    // 070 TouchStart                               ModelEnumType SoundKey SoundKey SoundKey Int32
    // 080 LongPress                                ModelEnumType SoundKey SoundKey SoundKey Int32
    // 090 NoticeDM                                 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 0A0 NoticeNG                                 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 0B0 Inactive                                 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 0C0 ViewClose                                ModelEnumType SoundKey SoundKey SoundKey Int32
    // 0D0 ErrorModal                               ModelEnumType SoundKey SoundKey SoundKey Int32
    // 0E0 Toggle                                   ModelEnumType SoundKey SoundKey SoundKey Int32
    // 0F0 UnitSlide                                ModelEnumType SoundKey SoundKey SoundKey Int32
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

            value.Cancel                                    = (SoundKey)GetInt32(new IntPtr(p + 0x010)); // 0x10 Cancel                      ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.PopupOpen                                 = (SoundKey)GetInt32(new IntPtr(p + 0x020)); // 0x20 PopupOpen                   ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.RewardPopupOpen                           = (SoundKey)GetInt32(new IntPtr(p + 0x030)); // 0x30 RewardPopupOpen             ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.Select                                    = (SoundKey)GetInt32(new IntPtr(p + 0x040)); // 0x40 Select                      ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.Swipe                                     = (SoundKey)GetInt32(new IntPtr(p + 0x050)); // 0x50 Swipe                       ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.TapTab                                    = (SoundKey)GetInt32(new IntPtr(p + 0x060)); // 0x60 TapTab                      ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.TouchStart                                = (SoundKey)GetInt32(new IntPtr(p + 0x070)); // 0x70 TouchStart                  ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.LongPress                                 = (SoundKey)GetInt32(new IntPtr(p + 0x080)); // 0x80 LongPress                   ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.NoticeDM                                  = (SoundKey)GetInt32(new IntPtr(p + 0x090)); // 0x90 NoticeDM                    ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.NoticeNG                                  = (SoundKey)GetInt32(new IntPtr(p + 0x0A0)); // 0xA0 NoticeNG                    ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.Inactive                                  = (SoundKey)GetInt32(new IntPtr(p + 0x0B0)); // 0xB0 Inactive                    ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ViewClose                                 = (SoundKey)GetInt32(new IntPtr(p + 0x0C0)); // 0xC0 ViewClose                   ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ErrorModal                                = (SoundKey)GetInt32(new IntPtr(p + 0x0D0)); // 0xD0 ErrorModal                  ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.Toggle                                    = (SoundKey)GetInt32(new IntPtr(p + 0x0E0)); // 0xE0 Toggle                      ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.UnitSlide                                 = (SoundKey)GetInt32(new IntPtr(p + 0x0F0)); // 0xF0 UnitSlide                   ( ModelEnumType SoundKey SoundKey SoundKey Int32 )

            return value;
        }
    }
}
