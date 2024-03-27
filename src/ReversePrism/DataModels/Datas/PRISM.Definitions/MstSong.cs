using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001865F4260 ModelPrimitiveType int int int Int32
    // 014 MstSongTypeId                            0001865F4260 ModelPrimitiveType int int int Int32
    // 018 MstUnitId                                0001865F4260 ModelPrimitiveType int int int Int32
    // 01C MstSongPositionId                        0001865F4260 ModelPrimitiveType int int int Int32
    // 020 SortId                                   0001865F4260 ModelPrimitiveType int int int Int32
    // 024 Bpm                                      0001865F4260 ModelPrimitiveType int int int Int32
    // 028 IsAdvanceDownload                        0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 029 IsSongParts                              0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 02A IsFocusCamera                            0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 02B Is3D                                     0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 02C Is2D                                     0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 030 PurchaseLink                             000186672F10 ModelPrimitiveType string string string String
    // 038 PurchaseLinkActiveDate                   0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 040 BeginDate                                0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 048 SongType                                 00018662C9B0 ModelClassType MstSongType MstSongType MstSongType Pointer
    public partial class MstSong
    {
        public int                                      Id                                      { get; set; }
        public int                                      MstSongTypeId                           { get; set; }
        public int                                      MstUnitId                               { get; set; }
        public int                                      MstSongPositionId                       { get; set; }
        public int                                      SortId                                  { get; set; }
        public int                                      Bpm                                     { get; set; }
        public bool                                     IsAdvanceDownload                       { get; set; }
        public bool                                     IsSongParts                             { get; set; }
        public bool                                     IsFocusCamera                           { get; set; }
        public bool                                     Is3D                                    { get; set; }
        public bool                                     Is2D                                    { get; set; }
        public string                                   PurchaseLink                            { get; set; }
        public DateTime                                 PurchaseLinkActiveDate                  { get; set; }
        public DateTime                                 BeginDate                               { get; set; }
        public MstSongType?                             SongType                                { get; set; }

        public static MstSong? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstSong();

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 027004602DC0 0x10 Id                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstSongTypeId                             = GetInt32(new IntPtr(p + 0x014)); // 027004602DE0 0x14 MstSongTypeId               ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstUnitId                                 = GetInt32(new IntPtr(p + 0x018)); // 027004602E00 0x18 MstUnitId                   ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstSongPositionId                         = GetInt32(new IntPtr(p + 0x01C)); // 027004602E20 0x1C MstSongPositionId           ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.SortId                                    = GetInt32(new IntPtr(p + 0x020)); // 027004602E40 0x20 SortId                      ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Bpm                                       = GetInt32(new IntPtr(p + 0x024)); // 027004602E60 0x24 Bpm                         ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.IsAdvanceDownload                         = GetBool(new IntPtr(p + 0x028)); // 027004602E80 0x28 IsAdvanceDownload           ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.IsSongParts                               = GetBool(new IntPtr(p + 0x029)); // 027004602EA0 0x29 IsSongParts                 ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.IsFocusCamera                             = GetBool(new IntPtr(p + 0x02A)); // 027004602EC0 0x2A IsFocusCamera               ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.Is3D                                      = GetBool(new IntPtr(p + 0x02B)); // 027004602EE0 0x2B Is3D                        ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.Is2D                                      = GetBool(new IntPtr(p + 0x02C)); // 027004602F00 0x2C Is2D                        ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.PurchaseLink                              = GetString(new IntPtr(p + 0x030)); // 027004602F20 0x30 PurchaseLink                ( 000186672F10 ModelPrimitiveType string string string String )
            value.PurchaseLinkActiveDate                    = GetDateTime(new IntPtr(p + 0x038)); // 027004602F40 0x38 PurchaseLinkActiveDate      ( 0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.BeginDate                                 = GetDateTime(new IntPtr(p + 0x040)); // 027004602F60 0x40 BeginDate                   ( 0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.SongType                                  = GetObject<MstSongType>(new IntPtr(p + 0x048), ReversePrism.DataModels.MstSongType.FromPointer); // 027004602F80 0x48 SongType                    ( 00018662C9B0 ModelClassType MstSongType MstSongType MstSongType Pointer )

            return value;
        }
    }
}
