using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       ModelPrimitiveType int int int Int32
    // 014 MstSongTypeId                            ModelPrimitiveType int int int Int32
    // 018 MstUnitId                                ModelPrimitiveType int int int Int32
    // 01C MstSongPositionId                        ModelPrimitiveType int int int Int32
    // 020 SortId                                   ModelPrimitiveType int int int Int32
    // 024 Bpm                                      ModelPrimitiveType int int int Int32
    // 028 IsAdvanceDownload                        ModelPrimitiveType bool bool bool Bool
    // 029 IsSongParts                              ModelPrimitiveType bool bool bool Bool
    // 02A IsFocusCamera                            ModelPrimitiveType bool bool bool Bool
    // 02B Is3D                                     ModelPrimitiveType bool bool bool Bool
    // 02C Is2D                                     ModelPrimitiveType bool bool bool Bool
    // 02D IsHDR                                    ModelPrimitiveType bool bool bool Bool
    // 02E IsLDR                                    ModelPrimitiveType bool bool bool Bool
    // 030 ResultBg                                 ModelPrimitiveType int int int Int32
    // 038 PurchaseLink                             ModelPrimitiveType string string string String
    // 040 PurchaseLinkActiveDate                   ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 048 BeginDate                                ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 050 SongType                                 ModelClassType MstSongType MstSongType MstSongType Pointer
    public partial class MstSong : DataModel
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
        public bool                                     IsHDR                                   { get; set; }
        public bool                                     IsLDR                                   { get; set; }
        public int                                      ResultBg                                { get; set; }
        public string                                   PurchaseLink                            { get; set; }
        public DateTime                                 PurchaseLinkActiveDate                  { get; set; }
        public DateTime                                 BeginDate                               { get; set; }
        public MstSongType?                             SongType                                { get; set; }

        public static MstSong? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstSong() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType int int int Int32 )
            value.MstSongTypeId                             = GetInt32(new IntPtr(p + 0x014)); // 0x14 MstSongTypeId               ( ModelPrimitiveType int int int Int32 )
            value.MstUnitId                                 = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstUnitId                   ( ModelPrimitiveType int int int Int32 )
            value.MstSongPositionId                         = GetInt32(new IntPtr(p + 0x01C)); // 0x1C MstSongPositionId           ( ModelPrimitiveType int int int Int32 )
            value.SortId                                    = GetInt32(new IntPtr(p + 0x020)); // 0x20 SortId                      ( ModelPrimitiveType int int int Int32 )
            value.Bpm                                       = GetInt32(new IntPtr(p + 0x024)); // 0x24 Bpm                         ( ModelPrimitiveType int int int Int32 )
            value.IsAdvanceDownload                         = GetBool(new IntPtr(p + 0x028)); // 0x28 IsAdvanceDownload           ( ModelPrimitiveType bool bool bool Bool )
            value.IsSongParts                               = GetBool(new IntPtr(p + 0x029)); // 0x29 IsSongParts                 ( ModelPrimitiveType bool bool bool Bool )
            value.IsFocusCamera                             = GetBool(new IntPtr(p + 0x02A)); // 0x2A IsFocusCamera               ( ModelPrimitiveType bool bool bool Bool )
            value.Is3D                                      = GetBool(new IntPtr(p + 0x02B)); // 0x2B Is3D                        ( ModelPrimitiveType bool bool bool Bool )
            value.Is2D                                      = GetBool(new IntPtr(p + 0x02C)); // 0x2C Is2D                        ( ModelPrimitiveType bool bool bool Bool )
            value.IsHDR                                     = GetBool(new IntPtr(p + 0x02D)); // 0x2D IsHDR                       ( ModelPrimitiveType bool bool bool Bool )
            value.IsLDR                                     = GetBool(new IntPtr(p + 0x02E)); // 0x2E IsLDR                       ( ModelPrimitiveType bool bool bool Bool )
            value.ResultBg                                  = GetInt32(new IntPtr(p + 0x030)); // 0x30 ResultBg                    ( ModelPrimitiveType int int int Int32 )
            value.PurchaseLink                              = GetString(new IntPtr(p + 0x038)); // 0x38 PurchaseLink                ( ModelPrimitiveType string string string String )
            value.PurchaseLinkActiveDate                    = GetDateTime(new IntPtr(p + 0x040)); // 0x40 PurchaseLinkActiveDate      ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.BeginDate                                 = GetDateTime(new IntPtr(p + 0x048)); // 0x48 BeginDate                   ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.SongType                                  = GetObject<MstSongType>(new IntPtr(p + 0x050), ReversePrism.DataModels.MstSongType.FromPointer); // 0x50 SongType                    ( ModelClassType MstSongType MstSongType MstSongType Pointer )

            return value;
        }
    }
}
