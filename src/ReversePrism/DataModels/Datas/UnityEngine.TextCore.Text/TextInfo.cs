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
    // 010 CharacterCount                           ModelPrimitiveType int int int Int32
    // 014 SpriteCount                              ModelPrimitiveType int int int Int32
    // 018 SpaceCount                               ModelPrimitiveType int int int Int32
    // 01C WordCount                                ModelPrimitiveType int int int Int32
    // 020 LinkCount                                ModelPrimitiveType int int int Int32
    // 024 LineCount                                ModelPrimitiveType int int int Int32
    // 028 PageCount                                ModelPrimitiveType int int int Int32
    // 02C MaterialCount                            ModelPrimitiveType int int int Int32
    // 030 TextElementInfo                          ModelEnumListType TextElementInfo[] TextElementInfo[] List<TextElementInfo> Pointer
    // 038 WordInfo                                 ModelEnumListType WordInfo[] WordInfo[] List<WordInfo> Pointer
    // 040 LinkInfo                                 ModelEnumListType LinkInfo[] LinkInfo[] List<LinkInfo> Pointer
    // 048 LineInfo                                 ModelEnumListType LineInfo[] LineInfo[] List<LineInfo> Pointer
    // 050 PageInfo                                 ModelEnumListType PageInfo[] PageInfo[] List<PageInfo> Pointer
    // 058 MeshInfo                                 ModelEnumListType MeshInfo[] MeshInfo[] List<MeshInfo> Pointer
    // 060 IsDirty                                  ModelPrimitiveType bool bool bool Bool
    // 061 HasMultipleColors                        ModelPrimitiveType bool bool bool Bool
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

            value.CharacterCount                            = GetInt32(new IntPtr(p + 0x010)); // 0x10 CharacterCount              ( ModelPrimitiveType int int int Int32 )
            value.SpriteCount                               = GetInt32(new IntPtr(p + 0x014)); // 0x14 SpriteCount                 ( ModelPrimitiveType int int int Int32 )
            value.SpaceCount                                = GetInt32(new IntPtr(p + 0x018)); // 0x18 SpaceCount                  ( ModelPrimitiveType int int int Int32 )
            value.WordCount                                 = GetInt32(new IntPtr(p + 0x01C)); // 0x1C WordCount                   ( ModelPrimitiveType int int int Int32 )
            value.LinkCount                                 = GetInt32(new IntPtr(p + 0x020)); // 0x20 LinkCount                   ( ModelPrimitiveType int int int Int32 )
            value.LineCount                                 = GetInt32(new IntPtr(p + 0x024)); // 0x24 LineCount                   ( ModelPrimitiveType int int int Int32 )
            value.PageCount                                 = GetInt32(new IntPtr(p + 0x028)); // 0x28 PageCount                   ( ModelPrimitiveType int int int Int32 )
            value.MaterialCount                             = GetInt32(new IntPtr(p + 0x02C)); // 0x2C MaterialCount               ( ModelPrimitiveType int int int Int32 )
            value.TextElementInfo                           = GetEnumList<TextElementInfo>(new IntPtr(p + 0x030)); // 0x30 TextElementInfo             ( ModelEnumListType TextElementInfo[] TextElementInfo[] List<TextElementInfo> Pointer )
            value.WordInfo                                  = GetEnumList<WordInfo>(new IntPtr(p + 0x038)); // 0x38 WordInfo                    ( ModelEnumListType WordInfo[] WordInfo[] List<WordInfo> Pointer )
            value.LinkInfo                                  = GetEnumList<LinkInfo>(new IntPtr(p + 0x040)); // 0x40 LinkInfo                    ( ModelEnumListType LinkInfo[] LinkInfo[] List<LinkInfo> Pointer )
            value.LineInfo                                  = GetEnumList<LineInfo>(new IntPtr(p + 0x048)); // 0x48 LineInfo                    ( ModelEnumListType LineInfo[] LineInfo[] List<LineInfo> Pointer )
            value.PageInfo                                  = GetEnumList<PageInfo>(new IntPtr(p + 0x050)); // 0x50 PageInfo                    ( ModelEnumListType PageInfo[] PageInfo[] List<PageInfo> Pointer )
            value.MeshInfo                                  = GetEnumList<MeshInfo>(new IntPtr(p + 0x058)); // 0x58 MeshInfo                    ( ModelEnumListType MeshInfo[] MeshInfo[] List<MeshInfo> Pointer )
            value.IsDirty                                   = GetBool(new IntPtr(p + 0x060)); // 0x60 IsDirty                     ( ModelPrimitiveType bool bool bool Bool )
            value.HasMultipleColors                         = GetBool(new IntPtr(p + 0x061)); // 0x61 HasMultipleColors           ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
