using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 sheetName                                string IL2CPP_TYPE_STRING
    // 000 MobileChainPop                           SoundKey IL2CPP_TYPE_VALUETYPE
    // 010 MobileChainChoice                        ModelEnumType SoundKey SoundKey SoundKey Int32
    // 020 MobileChainDecide                        ModelEnumType SoundKey SoundKey SoundKey Int32
    // 030 MobileSPhoneVoiceOn                      ModelEnumType SoundKey SoundKey SoundKey Int32
    // 040 MobileSPhoneVoiceOff                     ModelEnumType SoundKey SoundKey SoundKey Int32
    // 050 MobileSphoneCall                         ModelEnumType SoundKey SoundKey SoundKey Int32
    // 060 MobileChainNotice                        ModelEnumType SoundKey SoundKey SoundKey Int32
    // 070 MobileTwestaNotice                       ModelEnumType SoundKey SoundKey SoundKey Int32
    // 080 MobileTwestaFavoriteOn                   ModelEnumType SoundKey SoundKey SoundKey Int32
    // 090 MobileTwestaFavoriteOff                  ModelEnumType SoundKey SoundKey SoundKey Int32
    // 0A0 MobileOurStreamFavoriteOn                ModelEnumType SoundKey SoundKey SoundKey Int32
    // 0B0 MobileOurStreamFavoriteOff               ModelEnumType SoundKey SoundKey SoundKey Int32
    public partial class MobileSeConst : DataModel
    {
        public SoundKey                                 MobileChainChoice                       { get; set; }
        public SoundKey                                 MobileChainDecide                       { get; set; }
        public SoundKey                                 MobileSPhoneVoiceOn                     { get; set; }
        public SoundKey                                 MobileSPhoneVoiceOff                    { get; set; }
        public SoundKey                                 MobileSphoneCall                        { get; set; }
        public SoundKey                                 MobileChainNotice                       { get; set; }
        public SoundKey                                 MobileTwestaNotice                      { get; set; }
        public SoundKey                                 MobileTwestaFavoriteOn                  { get; set; }
        public SoundKey                                 MobileTwestaFavoriteOff                 { get; set; }
        public SoundKey                                 MobileOurStreamFavoriteOn               { get; set; }
        public SoundKey                                 MobileOurStreamFavoriteOff              { get; set; }

        public static MobileSeConst? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MobileSeConst() { Pointer= p0 };

            value.MobileChainChoice                         = (SoundKey)GetInt32(new IntPtr(p + 0x010)); // 0x10 MobileChainChoice           ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.MobileChainDecide                         = (SoundKey)GetInt32(new IntPtr(p + 0x020)); // 0x20 MobileChainDecide           ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.MobileSPhoneVoiceOn                       = (SoundKey)GetInt32(new IntPtr(p + 0x030)); // 0x30 MobileSPhoneVoiceOn         ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.MobileSPhoneVoiceOff                      = (SoundKey)GetInt32(new IntPtr(p + 0x040)); // 0x40 MobileSPhoneVoiceOff        ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.MobileSphoneCall                          = (SoundKey)GetInt32(new IntPtr(p + 0x050)); // 0x50 MobileSphoneCall            ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.MobileChainNotice                         = (SoundKey)GetInt32(new IntPtr(p + 0x060)); // 0x60 MobileChainNotice           ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.MobileTwestaNotice                        = (SoundKey)GetInt32(new IntPtr(p + 0x070)); // 0x70 MobileTwestaNotice          ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.MobileTwestaFavoriteOn                    = (SoundKey)GetInt32(new IntPtr(p + 0x080)); // 0x80 MobileTwestaFavoriteOn      ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.MobileTwestaFavoriteOff                   = (SoundKey)GetInt32(new IntPtr(p + 0x090)); // 0x90 MobileTwestaFavoriteOff     ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.MobileOurStreamFavoriteOn                 = (SoundKey)GetInt32(new IntPtr(p + 0x0A0)); // 0xA0 MobileOurStreamFavoriteOn   ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.MobileOurStreamFavoriteOff                = (SoundKey)GetInt32(new IntPtr(p + 0x0B0)); // 0xB0 MobileOurStreamFavoriteOff  ( ModelEnumType SoundKey SoundKey SoundKey Int32 )

            return value;
        }
    }
}
