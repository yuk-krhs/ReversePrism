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
    // 010 LoginStamp                               ModelEnumType SoundKey SoundKey SoundKey Int32
    // 020 LoginBoard                               ModelEnumType SoundKey SoundKey SoundKey Int32
    // 030 LoginTitle                               ModelEnumType SoundKey SoundKey SoundKey Int32
    // 040 LoginWipe                                ModelEnumType SoundKey SoundKey SoundKey Int32
    // 050 LoginNext                                ModelEnumType SoundKey SoundKey SoundKey Int32
    // 060 BirthdayRibbon                           ModelEnumType SoundKey SoundKey SoundKey Int32
    // 070 BirthdayTitle                            ModelEnumType SoundKey SoundKey SoundKey Int32
    // 080 BirthdayCracker                          ModelEnumType SoundKey SoundKey SoundKey Int32
    public partial class HomeSeConst : DataModel
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
            var value   = new HomeSeConst() { Pointer= p0 };

            value.LoginStamp                                = (SoundKey)GetInt32(new IntPtr(p + 0x010)); // 0x10 LoginStamp                  ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.LoginBoard                                = (SoundKey)GetInt32(new IntPtr(p + 0x020)); // 0x20 LoginBoard                  ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.LoginTitle                                = (SoundKey)GetInt32(new IntPtr(p + 0x030)); // 0x30 LoginTitle                  ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.LoginWipe                                 = (SoundKey)GetInt32(new IntPtr(p + 0x040)); // 0x40 LoginWipe                   ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.LoginNext                                 = (SoundKey)GetInt32(new IntPtr(p + 0x050)); // 0x50 LoginNext                   ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.BirthdayRibbon                            = (SoundKey)GetInt32(new IntPtr(p + 0x060)); // 0x60 BirthdayRibbon              ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.BirthdayTitle                             = (SoundKey)GetInt32(new IntPtr(p + 0x070)); // 0x70 BirthdayTitle               ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.BirthdayCracker                           = (SoundKey)GetInt32(new IntPtr(p + 0x080)); // 0x80 BirthdayCracker             ( ModelEnumType SoundKey SoundKey SoundKey Int32 )

            return value;
        }
    }
}
