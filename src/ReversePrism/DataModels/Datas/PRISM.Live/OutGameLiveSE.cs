using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 SheetName                                string IL2CPP_TYPE_STRING
    // 000 ScrollUp                                 SoundKey IL2CPP_TYPE_VALUETYPE
    // 010 ScrollDown                               000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 020 LiveStartCrowdLoop                       000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 030 LiveStart                                000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 040 ResultCountLoop                          000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 050 ResultCountEnd                           000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 060 ResultNewRecord                          000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 070 ResultCrearlamp                          000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 080 ResultScoreCBA                           000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 090 ResultScoreS                             000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 0A0 ResultScoreSS                            000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 0B0 ResultGetStamp                           000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 0C0 SkipliveClear                            000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 0D0 ResultItemGet                            000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 0E0 ResultItemGetRare                        000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 0F0 ResultMoneyEnd                           000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 100 ResultMoneyLoop                          000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 110 ResultPuSpecial                          000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 120 RatinggradeUp                            000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 130 ResultIdolCountLoop                      000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 140 ResultIdolCountLvUp                      000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 150 RatinggradeUpCount                       000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 160 RatinggradeUpCountEnd                    000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 170 RatinggradeUpGrade                       000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 180 RatinggradeUpStar                        000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 190 ResultIdolFanCount                       000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 1A0 EventCongratulations                     000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 1B0 EventGet                                 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 1C0 EventGetRare                             000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 1D0 EventBoxOpen                             000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 1E0 EventResultIn                            000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    public partial class OutGameLiveSE : DataModel
    {
        public SoundKey                                 ScrollDown                              { get; set; }
        public SoundKey                                 LiveStartCrowdLoop                      { get; set; }
        public SoundKey                                 LiveStart                               { get; set; }
        public SoundKey                                 ResultCountLoop                         { get; set; }
        public SoundKey                                 ResultCountEnd                          { get; set; }
        public SoundKey                                 ResultNewRecord                         { get; set; }
        public SoundKey                                 ResultCrearlamp                         { get; set; }
        public SoundKey                                 ResultScoreCBA                          { get; set; }
        public SoundKey                                 ResultScoreS                            { get; set; }
        public SoundKey                                 ResultScoreSS                           { get; set; }
        public SoundKey                                 ResultGetStamp                          { get; set; }
        public SoundKey                                 SkipliveClear                           { get; set; }
        public SoundKey                                 ResultItemGet                           { get; set; }
        public SoundKey                                 ResultItemGetRare                       { get; set; }
        public SoundKey                                 ResultMoneyEnd                          { get; set; }
        public SoundKey                                 ResultMoneyLoop                         { get; set; }
        public SoundKey                                 ResultPuSpecial                         { get; set; }
        public SoundKey                                 RatinggradeUp                           { get; set; }
        public SoundKey                                 ResultIdolCountLoop                     { get; set; }
        public SoundKey                                 ResultIdolCountLvUp                     { get; set; }
        public SoundKey                                 RatinggradeUpCount                      { get; set; }
        public SoundKey                                 RatinggradeUpCountEnd                   { get; set; }
        public SoundKey                                 RatinggradeUpGrade                      { get; set; }
        public SoundKey                                 RatinggradeUpStar                       { get; set; }
        public SoundKey                                 ResultIdolFanCount                      { get; set; }
        public SoundKey                                 EventCongratulations                    { get; set; }
        public SoundKey                                 EventGet                                { get; set; }
        public SoundKey                                 EventGetRare                            { get; set; }
        public SoundKey                                 EventBoxOpen                            { get; set; }
        public SoundKey                                 EventResultIn                           { get; set; }

        public static OutGameLiveSE? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OutGameLiveSE() { Pointer= p0 };

            value.ScrollDown                                = (SoundKey)GetInt32(new IntPtr(p + 0x010)); // 02466522DC08 0x10 ScrollDown                  ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.LiveStartCrowdLoop                        = (SoundKey)GetInt32(new IntPtr(p + 0x020)); // 02466522DC28 0x20 LiveStartCrowdLoop          ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.LiveStart                                 = (SoundKey)GetInt32(new IntPtr(p + 0x030)); // 02466522DC48 0x30 LiveStart                   ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ResultCountLoop                           = (SoundKey)GetInt32(new IntPtr(p + 0x040)); // 02466522DC68 0x40 ResultCountLoop             ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ResultCountEnd                            = (SoundKey)GetInt32(new IntPtr(p + 0x050)); // 02466522DC88 0x50 ResultCountEnd              ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ResultNewRecord                           = (SoundKey)GetInt32(new IntPtr(p + 0x060)); // 02466522DCA8 0x60 ResultNewRecord             ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ResultCrearlamp                           = (SoundKey)GetInt32(new IntPtr(p + 0x070)); // 02466522DCC8 0x70 ResultCrearlamp             ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ResultScoreCBA                            = (SoundKey)GetInt32(new IntPtr(p + 0x080)); // 02466522DCE8 0x80 ResultScoreCBA              ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ResultScoreS                              = (SoundKey)GetInt32(new IntPtr(p + 0x090)); // 02466522DD08 0x90 ResultScoreS                ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ResultScoreSS                             = (SoundKey)GetInt32(new IntPtr(p + 0x0A0)); // 02466522DD28 0xA0 ResultScoreSS               ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ResultGetStamp                            = (SoundKey)GetInt32(new IntPtr(p + 0x0B0)); // 02466522DD48 0xB0 ResultGetStamp              ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.SkipliveClear                             = (SoundKey)GetInt32(new IntPtr(p + 0x0C0)); // 02466522DD68 0xC0 SkipliveClear               ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ResultItemGet                             = (SoundKey)GetInt32(new IntPtr(p + 0x0D0)); // 02466522DD88 0xD0 ResultItemGet               ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ResultItemGetRare                         = (SoundKey)GetInt32(new IntPtr(p + 0x0E0)); // 02466522DDA8 0xE0 ResultItemGetRare           ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ResultMoneyEnd                            = (SoundKey)GetInt32(new IntPtr(p + 0x0F0)); // 02466522DDC8 0xF0 ResultMoneyEnd              ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ResultMoneyLoop                           = (SoundKey)GetInt32(new IntPtr(p + 0x100)); // 02466522DDE8 0x100 ResultMoneyLoop             ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ResultPuSpecial                           = (SoundKey)GetInt32(new IntPtr(p + 0x110)); // 02466522DE08 0x110 ResultPuSpecial             ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.RatinggradeUp                             = (SoundKey)GetInt32(new IntPtr(p + 0x120)); // 02466522DE28 0x120 RatinggradeUp               ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ResultIdolCountLoop                       = (SoundKey)GetInt32(new IntPtr(p + 0x130)); // 02466522DE48 0x130 ResultIdolCountLoop         ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ResultIdolCountLvUp                       = (SoundKey)GetInt32(new IntPtr(p + 0x140)); // 02466522DE68 0x140 ResultIdolCountLvUp         ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.RatinggradeUpCount                        = (SoundKey)GetInt32(new IntPtr(p + 0x150)); // 02466522DE88 0x150 RatinggradeUpCount          ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.RatinggradeUpCountEnd                     = (SoundKey)GetInt32(new IntPtr(p + 0x160)); // 02466522DEA8 0x160 RatinggradeUpCountEnd       ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.RatinggradeUpGrade                        = (SoundKey)GetInt32(new IntPtr(p + 0x170)); // 02466522DEC8 0x170 RatinggradeUpGrade          ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.RatinggradeUpStar                         = (SoundKey)GetInt32(new IntPtr(p + 0x180)); // 02466522DEE8 0x180 RatinggradeUpStar           ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ResultIdolFanCount                        = (SoundKey)GetInt32(new IntPtr(p + 0x190)); // 02466522DF08 0x190 ResultIdolFanCount          ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.EventCongratulations                      = (SoundKey)GetInt32(new IntPtr(p + 0x1A0)); // 02466522DF28 0x1A0 EventCongratulations        ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.EventGet                                  = (SoundKey)GetInt32(new IntPtr(p + 0x1B0)); // 02466522DF48 0x1B0 EventGet                    ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.EventGetRare                              = (SoundKey)GetInt32(new IntPtr(p + 0x1C0)); // 02466522DF68 0x1C0 EventGetRare                ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.EventBoxOpen                              = (SoundKey)GetInt32(new IntPtr(p + 0x1D0)); // 02466522DF88 0x1D0 EventBoxOpen                ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.EventResultIn                             = (SoundKey)GetInt32(new IntPtr(p + 0x1E0)); // 02466522DFA8 0x1E0 EventResultIn               ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )

            return value;
        }
    }
}
