using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MstStreamProgramId                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 Title                                    000186671910 ModelPrimitiveType string string string String
    // 020 Description                              000186671910 ModelPrimitiveType string string string String
    // 028 BeginDate                                000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 038 EndDate                                  000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 048 PerformerIdList                          000185D11E28 ModelPrimitiveListType IReadOnlyList`1<int> IReadOnlyList`1<int> List<int> Pointer
    // 050 Seconds                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 054 IsFavorite                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 058 CategoryType                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 060 FavoriteDate                             000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 070 IsFavoriteOnServer                       000186594D10 ModelPrimitiveType bool bool bool Bool
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

            value.MstStreamProgramId                        = GetInt32(new IntPtr(p + 0x010)); // 0245A4B572F0 0x10 MstStreamProgramId          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Title                                     = GetString(new IntPtr(p + 0x018)); // 0245A4B57310 0x18 Title                       ( 000186671910 ModelPrimitiveType string string string String )
            value.Description                               = GetString(new IntPtr(p + 0x020)); // 0245A4B57330 0x20 Description                 ( 000186671910 ModelPrimitiveType string string string String )
            value.BeginDate                                 = GetDateTime(new IntPtr(p + 0x028)); // 0245A4B57350 0x28 BeginDate                   ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.EndDate                                   = GetDateTime(new IntPtr(p + 0x038)); // 0245A4B57370 0x38 EndDate                     ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.PerformerIdList                           = GetInt32List(new IntPtr(p + 0x048)); // 0245A4B57390 0x48 PerformerIdList             ( 000185D11E28 ModelPrimitiveListType IReadOnlyList`1<int> IReadOnlyList`1<int> List<int> Pointer )
            value.Seconds                                   = GetInt32(new IntPtr(p + 0x050)); // 0245A4B573B0 0x50 Seconds                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsFavorite                                = GetBool(new IntPtr(p + 0x054)); // 0245A4B573D0 0x54 IsFavorite                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CategoryType                              = GetInt32(new IntPtr(p + 0x058)); // 0245A4B573F0 0x58 CategoryType                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.FavoriteDate                              = GetDateTime(new IntPtr(p + 0x060)); // 0245A4B57410 0x60 FavoriteDate                ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.IsFavoriteOnServer                        = GetBool(new IntPtr(p + 0x070)); // 0245A4B57430 0x70 IsFavoriteOnServer          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
