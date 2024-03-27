using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 SheetName                                string IL2CPP_TYPE_STRING
    // 000 LoginHadukiExit                          SoundKey IL2CPP_TYPE_VALUETYPE
    // 010 LoginStamp                               000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 020 LoginBoard                               000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 030 LoginTitle                               000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 040 LoginWipe                                000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 050 LoginNext                                000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 060 BirthdayRibbon                           000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 070 BirthdayTitle                            000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 080 BirthdayCracker                          000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    public partial class HomeSeConst
    {
        public SoundKey                                 LoginStamp                              { get; set; }
        public SoundKey                                 LoginBoard                              { get; set; }
        public SoundKey                                 LoginTitle                              { get; set; }
        public SoundKey                                 LoginWipe                               { get; set; }
        public SoundKey                                 LoginNext                               { get; set; }
        public SoundKey                                 BirthdayRibbon                          { get; set; }
        public SoundKey                                 BirthdayTitle                           { get; set; }
        public SoundKey                                 BirthdayCracker                         { get; set; }

        public static HomeSeConst? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeSeConst();

            value.LoginStamp                                = (SoundKey)GetInt32(new IntPtr(p + 0x010)); // 0270D5E58080 0x10 LoginStamp                  ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.LoginBoard                                = (SoundKey)GetInt32(new IntPtr(p + 0x020)); // 0270D5E580A0 0x20 LoginBoard                  ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.LoginTitle                                = (SoundKey)GetInt32(new IntPtr(p + 0x030)); // 0270D5E580C0 0x30 LoginTitle                  ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.LoginWipe                                 = (SoundKey)GetInt32(new IntPtr(p + 0x040)); // 0270D5E580E0 0x40 LoginWipe                   ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.LoginNext                                 = (SoundKey)GetInt32(new IntPtr(p + 0x050)); // 0270D5E58100 0x50 LoginNext                   ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.BirthdayRibbon                            = (SoundKey)GetInt32(new IntPtr(p + 0x060)); // 0270D5E58120 0x60 BirthdayRibbon              ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.BirthdayTitle                             = (SoundKey)GetInt32(new IntPtr(p + 0x070)); // 0270D5E58140 0x70 BirthdayTitle               ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.BirthdayCracker                           = (SoundKey)GetInt32(new IntPtr(p + 0x080)); // 0270D5E58160 0x80 BirthdayCracker             ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )

            return value;
        }
    }
}
