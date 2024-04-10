using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_InfinityVectorPositive                 Vector2 IL2CPP_TYPE_VALUETYPE
    // 008 s_InfinityVectorNegative                 Vector2 IL2CPP_TYPE_VALUETYPE
    // 010 CharacterCount                           0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 SpriteCount                              0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 SpaceCount                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 01C WordCount                                0001865F36C0 ModelPrimitiveType int int int Int32
    // 020 LinkCount                                0001865F36C0 ModelPrimitiveType int int int Int32
    // 024 LineCount                                0001865F36C0 ModelPrimitiveType int int int Int32
    // 028 PageCount                                0001865F36C0 ModelPrimitiveType int int int Int32
    // 02C MaterialCount                            0001865F36C0 ModelPrimitiveType int int int Int32
    // 030 TextElementInfo                          000185CAAB58 ModelEnumListType TextElementInfo[] TextElementInfo[] List<TextElementInfo> Pointer
    // 038 WordInfo                                 000185CB2728 ModelEnumListType WordInfo[] WordInfo[] List<WordInfo> Pointer
    // 040 LinkInfo                                 000185B90280 ModelEnumListType LinkInfo[] LinkInfo[] List<LinkInfo> Pointer
    // 048 LineInfo                                 000185B90080 ModelEnumListType LineInfo[] LineInfo[] List<LineInfo> Pointer
    // 050 PageInfo                                 000185B9A100 ModelEnumListType PageInfo[] PageInfo[] List<PageInfo> Pointer
    // 058 MeshInfo                                 000185B936E0 ModelEnumListType MeshInfo[] MeshInfo[] List<MeshInfo> Pointer
    // 060 IsDirty                                  000186595960 ModelPrimitiveType bool bool bool Bool
    // 061 HasMultipleColors                        000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class TextInfo : DataModel
    {
        public int                                      CharacterCount                          { get; set; }
        public int                                      SpriteCount                             { get; set; }
        public int                                      SpaceCount                              { get; set; }
        public int                                      WordCount                               { get; set; }
        public int                                      LinkCount                               { get; set; }
        public int                                      LineCount                               { get; set; }
        public int                                      PageCount                               { get; set; }
        public int                                      MaterialCount                           { get; set; }
        public List<TextElementInfo>?                   TextElementInfo                         { get; set; }
        public List<WordInfo>?                          WordInfo                                { get; set; }
        public List<LinkInfo>?                          LinkInfo                                { get; set; }
        public List<LineInfo>?                          LineInfo                                { get; set; }
        public List<PageInfo>?                          PageInfo                                { get; set; }
        public List<MeshInfo>?                          MeshInfo                                { get; set; }
        public bool                                     IsDirty                                 { get; set; }
        public bool                                     HasMultipleColors                       { get; set; }

        public static TextInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TextInfo() { Pointer= p0 };

            value.CharacterCount                            = GetInt32(new IntPtr(p + 0x010)); // 0245A68BC588 0x10 CharacterCount              ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.SpriteCount                               = GetInt32(new IntPtr(p + 0x014)); // 0245A68BC5A8 0x14 SpriteCount                 ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.SpaceCount                                = GetInt32(new IntPtr(p + 0x018)); // 0245A68BC5C8 0x18 SpaceCount                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.WordCount                                 = GetInt32(new IntPtr(p + 0x01C)); // 0245A68BC5E8 0x1C WordCount                   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.LinkCount                                 = GetInt32(new IntPtr(p + 0x020)); // 0245A68BC608 0x20 LinkCount                   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.LineCount                                 = GetInt32(new IntPtr(p + 0x024)); // 0245A68BC628 0x24 LineCount                   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.PageCount                                 = GetInt32(new IntPtr(p + 0x028)); // 0245A68BC648 0x28 PageCount                   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.MaterialCount                             = GetInt32(new IntPtr(p + 0x02C)); // 0245A68BC668 0x2C MaterialCount               ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.TextElementInfo                           = GetEnumList<TextElementInfo>(new IntPtr(p + 0x030)); // 0245A68BC688 0x30 TextElementInfo             ( 000185CAAB58 ModelEnumListType TextElementInfo[] TextElementInfo[] List<TextElementInfo> Pointer )
            value.WordInfo                                  = GetEnumList<WordInfo>(new IntPtr(p + 0x038)); // 0245A68BC6A8 0x38 WordInfo                    ( 000185CB2728 ModelEnumListType WordInfo[] WordInfo[] List<WordInfo> Pointer )
            value.LinkInfo                                  = GetEnumList<LinkInfo>(new IntPtr(p + 0x040)); // 0245A68BC6C8 0x40 LinkInfo                    ( 000185B90280 ModelEnumListType LinkInfo[] LinkInfo[] List<LinkInfo> Pointer )
            value.LineInfo                                  = GetEnumList<LineInfo>(new IntPtr(p + 0x048)); // 0245A68BC6E8 0x48 LineInfo                    ( 000185B90080 ModelEnumListType LineInfo[] LineInfo[] List<LineInfo> Pointer )
            value.PageInfo                                  = GetEnumList<PageInfo>(new IntPtr(p + 0x050)); // 0245A68BC708 0x50 PageInfo                    ( 000185B9A100 ModelEnumListType PageInfo[] PageInfo[] List<PageInfo> Pointer )
            value.MeshInfo                                  = GetEnumList<MeshInfo>(new IntPtr(p + 0x058)); // 0245A68BC728 0x58 MeshInfo                    ( 000185B936E0 ModelEnumListType MeshInfo[] MeshInfo[] List<MeshInfo> Pointer )
            value.IsDirty                                   = GetBool(new IntPtr(p + 0x060)); // 0245A68BC748 0x60 IsDirty                     ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.HasMultipleColors                         = GetBool(new IntPtr(p + 0x061)); // 0245A68BC768 0x61 HasMultipleColors           ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
