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
    // 010 ScrollDown                               ModelEnumType SoundKey SoundKey SoundKey Int32
    // 020 LiveStartCrowdLoop                       ModelEnumType SoundKey SoundKey SoundKey Int32
    // 030 LiveStart                                ModelEnumType SoundKey SoundKey SoundKey Int32
    // 040 ResultCountLoop                          ModelEnumType SoundKey SoundKey SoundKey Int32
    // 050 ResultCountEnd                           ModelEnumType SoundKey SoundKey SoundKey Int32
    // 060 ResultNewRecord                          ModelEnumType SoundKey SoundKey SoundKey Int32
    // 070 ResultCrearlamp                          ModelEnumType SoundKey SoundKey SoundKey Int32
    // 080 ResultScoreCBA                           ModelEnumType SoundKey SoundKey SoundKey Int32
    // 090 ResultScoreS                             ModelEnumType SoundKey SoundKey SoundKey Int32
    // 0A0 ResultScoreSS                            ModelEnumType SoundKey SoundKey SoundKey Int32
    // 0B0 ResultGetStamp                           ModelEnumType SoundKey SoundKey SoundKey Int32
    // 0C0 SkipliveClear                            ModelEnumType SoundKey SoundKey SoundKey Int32
    // 0D0 ResultItemGet                            ModelEnumType SoundKey SoundKey SoundKey Int32
    // 0E0 ResultItemGetRare                        ModelEnumType SoundKey SoundKey SoundKey Int32
    // 0F0 ResultMoneyEnd                           ModelEnumType SoundKey SoundKey SoundKey Int32
    // 100 ResultMoneyLoop                          ModelEnumType SoundKey SoundKey SoundKey Int32
    // 110 ResultPuSpecial                          ModelEnumType SoundKey SoundKey SoundKey Int32
    // 120 RatinggradeUp                            ModelEnumType SoundKey SoundKey SoundKey Int32
    // 130 ResultIdolCountLoop                      ModelEnumType SoundKey SoundKey SoundKey Int32
    // 140 ResultIdolCountLvUp                      ModelEnumType SoundKey SoundKey SoundKey Int32
    // 150 RatinggradeUpCount                       ModelEnumType SoundKey SoundKey SoundKey Int32
    // 160 RatinggradeUpCountEnd                    ModelEnumType SoundKey SoundKey SoundKey Int32
    // 170 RatinggradeUpGrade                       ModelEnumType SoundKey SoundKey SoundKey Int32
    // 180 RatinggradeUpStar                        ModelEnumType SoundKey SoundKey SoundKey Int32
    // 190 ResultIdolFanCount                       ModelEnumType SoundKey SoundKey SoundKey Int32
    // 1A0 EventCongratulations                     ModelEnumType SoundKey SoundKey SoundKey Int32
    // 1B0 EventGet                                 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 1C0 EventGetRare                             ModelEnumType SoundKey SoundKey SoundKey Int32
    // 1D0 EventBoxOpen                             ModelEnumType SoundKey SoundKey SoundKey Int32
    // 1E0 EventResultIn                            ModelEnumType SoundKey SoundKey SoundKey Int32
    // 1F0 EventAlbumOpen                           ModelEnumType SoundKey SoundKey SoundKey Int32
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
        public SoundKey                                 EventAlbumOpen                          { get; set; }

        public static OutGameLiveSE? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OutGameLiveSE() { Pointer= p0 };

            value.ScrollDown                                = (SoundKey)GetInt32(new IntPtr(p + 0x010)); // 0x10 ScrollDown                  ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.LiveStartCrowdLoop                        = (SoundKey)GetInt32(new IntPtr(p + 0x020)); // 0x20 LiveStartCrowdLoop          ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.LiveStart                                 = (SoundKey)GetInt32(new IntPtr(p + 0x030)); // 0x30 LiveStart                   ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ResultCountLoop                           = (SoundKey)GetInt32(new IntPtr(p + 0x040)); // 0x40 ResultCountLoop             ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ResultCountEnd                            = (SoundKey)GetInt32(new IntPtr(p + 0x050)); // 0x50 ResultCountEnd              ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ResultNewRecord                           = (SoundKey)GetInt32(new IntPtr(p + 0x060)); // 0x60 ResultNewRecord             ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ResultCrearlamp                           = (SoundKey)GetInt32(new IntPtr(p + 0x070)); // 0x70 ResultCrearlamp             ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ResultScoreCBA                            = (SoundKey)GetInt32(new IntPtr(p + 0x080)); // 0x80 ResultScoreCBA              ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ResultScoreS                              = (SoundKey)GetInt32(new IntPtr(p + 0x090)); // 0x90 ResultScoreS                ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ResultScoreSS                             = (SoundKey)GetInt32(new IntPtr(p + 0x0A0)); // 0xA0 ResultScoreSS               ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ResultGetStamp                            = (SoundKey)GetInt32(new IntPtr(p + 0x0B0)); // 0xB0 ResultGetStamp              ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.SkipliveClear                             = (SoundKey)GetInt32(new IntPtr(p + 0x0C0)); // 0xC0 SkipliveClear               ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ResultItemGet                             = (SoundKey)GetInt32(new IntPtr(p + 0x0D0)); // 0xD0 ResultItemGet               ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ResultItemGetRare                         = (SoundKey)GetInt32(new IntPtr(p + 0x0E0)); // 0xE0 ResultItemGetRare           ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ResultMoneyEnd                            = (SoundKey)GetInt32(new IntPtr(p + 0x0F0)); // 0xF0 ResultMoneyEnd              ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ResultMoneyLoop                           = (SoundKey)GetInt32(new IntPtr(p + 0x100)); // 0x100 ResultMoneyLoop             ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ResultPuSpecial                           = (SoundKey)GetInt32(new IntPtr(p + 0x110)); // 0x110 ResultPuSpecial             ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.RatinggradeUp                             = (SoundKey)GetInt32(new IntPtr(p + 0x120)); // 0x120 RatinggradeUp               ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ResultIdolCountLoop                       = (SoundKey)GetInt32(new IntPtr(p + 0x130)); // 0x130 ResultIdolCountLoop         ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ResultIdolCountLvUp                       = (SoundKey)GetInt32(new IntPtr(p + 0x140)); // 0x140 ResultIdolCountLvUp         ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.RatinggradeUpCount                        = (SoundKey)GetInt32(new IntPtr(p + 0x150)); // 0x150 RatinggradeUpCount          ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.RatinggradeUpCountEnd                     = (SoundKey)GetInt32(new IntPtr(p + 0x160)); // 0x160 RatinggradeUpCountEnd       ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.RatinggradeUpGrade                        = (SoundKey)GetInt32(new IntPtr(p + 0x170)); // 0x170 RatinggradeUpGrade          ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.RatinggradeUpStar                         = (SoundKey)GetInt32(new IntPtr(p + 0x180)); // 0x180 RatinggradeUpStar           ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.ResultIdolFanCount                        = (SoundKey)GetInt32(new IntPtr(p + 0x190)); // 0x190 ResultIdolFanCount          ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.EventCongratulations                      = (SoundKey)GetInt32(new IntPtr(p + 0x1A0)); // 0x1A0 EventCongratulations        ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.EventGet                                  = (SoundKey)GetInt32(new IntPtr(p + 0x1B0)); // 0x1B0 EventGet                    ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.EventGetRare                              = (SoundKey)GetInt32(new IntPtr(p + 0x1C0)); // 0x1C0 EventGetRare                ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.EventBoxOpen                              = (SoundKey)GetInt32(new IntPtr(p + 0x1D0)); // 0x1D0 EventBoxOpen                ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.EventResultIn                             = (SoundKey)GetInt32(new IntPtr(p + 0x1E0)); // 0x1E0 EventResultIn               ( ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.EventAlbumOpen                            = (SoundKey)GetInt32(new IntPtr(p + 0x1F0)); // 0x1F0 EventAlbumOpen              ( ModelEnumType SoundKey SoundKey SoundKey Int32 )

            return value;
        }
    }
}
