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
    // 010 MobileChainChoice                        000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 020 MobileChainDecide                        000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 030 MobileSPhoneVoiceOn                      000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 040 MobileSPhoneVoiceOff                     000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 050 MobileSphoneCall                         000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 060 MobileChainNotice                        000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 070 MobileTwestaNotice                       000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 080 MobileTwestaFavoriteOn                   000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 090 MobileTwestaFavoriteOff                  000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 0A0 MobileOurStreamFavoriteOn                000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 0B0 MobileOurStreamFavoriteOff               000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
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

            value.MobileChainChoice                         = (SoundKey)GetInt32(new IntPtr(p + 0x010)); // 02466B149360 0x10 MobileChainChoice           ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.MobileChainDecide                         = (SoundKey)GetInt32(new IntPtr(p + 0x020)); // 02466B149380 0x20 MobileChainDecide           ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.MobileSPhoneVoiceOn                       = (SoundKey)GetInt32(new IntPtr(p + 0x030)); // 02466B1493A0 0x30 MobileSPhoneVoiceOn         ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.MobileSPhoneVoiceOff                      = (SoundKey)GetInt32(new IntPtr(p + 0x040)); // 02466B1493C0 0x40 MobileSPhoneVoiceOff        ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.MobileSphoneCall                          = (SoundKey)GetInt32(new IntPtr(p + 0x050)); // 02466B1493E0 0x50 MobileSphoneCall            ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.MobileChainNotice                         = (SoundKey)GetInt32(new IntPtr(p + 0x060)); // 02466B149400 0x60 MobileChainNotice           ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.MobileTwestaNotice                        = (SoundKey)GetInt32(new IntPtr(p + 0x070)); // 02466B149420 0x70 MobileTwestaNotice          ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.MobileTwestaFavoriteOn                    = (SoundKey)GetInt32(new IntPtr(p + 0x080)); // 02466B149440 0x80 MobileTwestaFavoriteOn      ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.MobileTwestaFavoriteOff                   = (SoundKey)GetInt32(new IntPtr(p + 0x090)); // 02466B149460 0x90 MobileTwestaFavoriteOff     ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.MobileOurStreamFavoriteOn                 = (SoundKey)GetInt32(new IntPtr(p + 0x0A0)); // 02466B149480 0xA0 MobileOurStreamFavoriteOn   ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.MobileOurStreamFavoriteOff                = (SoundKey)GetInt32(new IntPtr(p + 0x0B0)); // 02466B1494A0 0xB0 MobileOurStreamFavoriteOff  ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )

            return value;
        }
    }
}
