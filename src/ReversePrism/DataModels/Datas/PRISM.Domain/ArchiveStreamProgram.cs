using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MstStreamProgramId                       ModelPrimitiveType int int int Int32
    // 018 Title                                    ModelPrimitiveType string string string String
    // 020 Description                              ModelPrimitiveType string string string String
    // 028 BeginDate                                ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 038 EndDate                                  ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 048 PerformerIdList                          ModelPrimitiveListType IReadOnlyList`1<int> IReadOnlyList`1<int> List<int> Pointer
    // 050 Seconds                                  ModelPrimitiveType int int int Int32
    // 054 IsFavorite                               ModelPrimitiveType bool bool bool Bool
    // 058 CategoryType                             ModelPrimitiveType int int int Int32
    // 060 FavoriteDate                             ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 070 IsFavoriteOnServer                       ModelPrimitiveType bool bool bool Bool
    public partial class ArchiveStreamProgram : DataModel
    {
        public int                                      MstStreamProgramId                      { get; set; }
        public string                                   Title                                   { get; set; }
        public string                                   Description                             { get; set; }
        public DateTime                                 BeginDate                               { get; set; }
        public DateTime                                 EndDate                                 { get; set; }
        public List<int>?                               PerformerIdList                         { get; set; }
        public int                                      Seconds                                 { get; set; }
        public bool                                     IsFavorite                              { get; set; }
        public int                                      CategoryType                            { get; set; }
        public DateTime                                 FavoriteDate                            { get; set; }
        public bool                                     IsFavoriteOnServer                      { get; set; }

        public static ArchiveStreamProgram? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ArchiveStreamProgram() { Pointer= p0 };

            value.MstStreamProgramId                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 MstStreamProgramId          ( ModelPrimitiveType int int int Int32 )
            value.Title                                     = GetString(new IntPtr(p + 0x018)); // 0x18 Title                       ( ModelPrimitiveType string string string String )
            value.Description                               = GetString(new IntPtr(p + 0x020)); // 0x20 Description                 ( ModelPrimitiveType string string string String )
            value.BeginDate                                 = GetDateTime(new IntPtr(p + 0x028)); // 0x28 BeginDate                   ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.EndDate                                   = GetDateTime(new IntPtr(p + 0x038)); // 0x38 EndDate                     ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.PerformerIdList                           = GetInt32List(new IntPtr(p + 0x048)); // 0x48 PerformerIdList             ( ModelPrimitiveListType IReadOnlyList`1<int> IReadOnlyList`1<int> List<int> Pointer )
            value.Seconds                                   = GetInt32(new IntPtr(p + 0x050)); // 0x50 Seconds                     ( ModelPrimitiveType int int int Int32 )
            value.IsFavorite                                = GetBool(new IntPtr(p + 0x054)); // 0x54 IsFavorite                  ( ModelPrimitiveType bool bool bool Bool )
            value.CategoryType                              = GetInt32(new IntPtr(p + 0x058)); // 0x58 CategoryType                ( ModelPrimitiveType int int int Int32 )
            value.FavoriteDate                              = GetDateTime(new IntPtr(p + 0x060)); // 0x60 FavoriteDate                ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.IsFavoriteOnServer                        = GetBool(new IntPtr(p + 0x070)); // 0x70 IsFavoriteOnServer          ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
