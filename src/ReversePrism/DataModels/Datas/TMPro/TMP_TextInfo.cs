using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_InfinityVectorPositive                 Vector2 IL2CPP_TYPE_VALUETYPE
    // 008 k_InfinityVectorNegative                 Vector2 IL2CPP_TYPE_VALUETYPE
    // 010 TextComponent                            ModelClassType TMP_Text TMP_Text TMP_Text Pointer
    // 018 CharacterCount                           ModelPrimitiveType int int int Int32
    // 01C SpriteCount                              ModelPrimitiveType int int int Int32
    // 020 SpaceCount                               ModelPrimitiveType int int int Int32
    // 024 WordCount                                ModelPrimitiveType int int int Int32
    // 028 LinkCount                                ModelPrimitiveType int int int Int32
    // 02C LineCount                                ModelPrimitiveType int int int Int32
    // 030 PageCount                                ModelPrimitiveType int int int Int32
    // 034 MaterialCount                            ModelPrimitiveType int int int Int32
    // 038 CharacterInfo                            ModelEnumListType TMP_CharacterInfo[] TMP_CharacterInfo[] List<TMP_CharacterInfo> Pointer
    // 040 WordInfo                                 ModelEnumListType TMP_WordInfo[] TMP_WordInfo[] List<TMP_WordInfo> Pointer
    // 048 LinkInfo                                 ModelEnumListType TMP_LinkInfo[] TMP_LinkInfo[] List<TMP_LinkInfo> Pointer
    // 050 LineInfo                                 ModelEnumListType TMP_LineInfo[] TMP_LineInfo[] List<TMP_LineInfo> Pointer
    // 058 PageInfo                                 ModelEnumListType TMP_PageInfo[] TMP_PageInfo[] List<TMP_PageInfo> Pointer
    // 060 MeshInfo                                 ModelEnumListType TMP_MeshInfo[] TMP_MeshInfo[] List<TMP_MeshInfo> Pointer
    // 068 M_CachedMeshInfo                         ModelEnumListType TMP_MeshInfo[] TMP_MeshInfo[] List<TMP_MeshInfo> Pointer
    public partial class TMP_TextInfo : DataModel
    {
        public TMP_Text?                                TextComponent                           { get; set; }
        public int                                      CharacterCount                          { get; set; }
        public int                                      SpriteCount                             { get; set; }
        public int                                      SpaceCount                              { get; set; }
        public int                                      WordCount                               { get; set; }
        public int                                      LinkCount                               { get; set; }
        public int                                      LineCount                               { get; set; }
        public int                                      PageCount                               { get; set; }
        public int                                      MaterialCount                           { get; set; }
        public List<TMP_CharacterInfo>?                 CharacterInfo                           { get; set; }
        public List<TMP_WordInfo>?                      WordInfo                                { get; set; }
        public List<TMP_LinkInfo>?                      LinkInfo                                { get; set; }
        public List<TMP_LineInfo>?                      LineInfo                                { get; set; }
        public List<TMP_PageInfo>?                      PageInfo                                { get; set; }
        public List<TMP_MeshInfo>?                      MeshInfo                                { get; set; }
        public List<TMP_MeshInfo>?                      M_CachedMeshInfo                        { get; set; }

        public static TMP_TextInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TMP_TextInfo() { Pointer= p0 };

            value.TextComponent                             = GetObject<TMP_Text>(new IntPtr(p + 0x010), ReversePrism.DataModels.TMP_Text.FromPointer); // 0x10 TextComponent               ( ModelClassType TMP_Text TMP_Text TMP_Text Pointer )
            value.CharacterCount                            = GetInt32(new IntPtr(p + 0x018)); // 0x18 CharacterCount              ( ModelPrimitiveType int int int Int32 )
            value.SpriteCount                               = GetInt32(new IntPtr(p + 0x01C)); // 0x1C SpriteCount                 ( ModelPrimitiveType int int int Int32 )
            value.SpaceCount                                = GetInt32(new IntPtr(p + 0x020)); // 0x20 SpaceCount                  ( ModelPrimitiveType int int int Int32 )
            value.WordCount                                 = GetInt32(new IntPtr(p + 0x024)); // 0x24 WordCount                   ( ModelPrimitiveType int int int Int32 )
            value.LinkCount                                 = GetInt32(new IntPtr(p + 0x028)); // 0x28 LinkCount                   ( ModelPrimitiveType int int int Int32 )
            value.LineCount                                 = GetInt32(new IntPtr(p + 0x02C)); // 0x2C LineCount                   ( ModelPrimitiveType int int int Int32 )
            value.PageCount                                 = GetInt32(new IntPtr(p + 0x030)); // 0x30 PageCount                   ( ModelPrimitiveType int int int Int32 )
            value.MaterialCount                             = GetInt32(new IntPtr(p + 0x034)); // 0x34 MaterialCount               ( ModelPrimitiveType int int int Int32 )
            value.CharacterInfo                             = GetEnumList<TMP_CharacterInfo>(new IntPtr(p + 0x038)); // 0x38 CharacterInfo               ( ModelEnumListType TMP_CharacterInfo[] TMP_CharacterInfo[] List<TMP_CharacterInfo> Pointer )
            value.WordInfo                                  = GetEnumList<TMP_WordInfo>(new IntPtr(p + 0x040)); // 0x40 WordInfo                    ( ModelEnumListType TMP_WordInfo[] TMP_WordInfo[] List<TMP_WordInfo> Pointer )
            value.LinkInfo                                  = GetEnumList<TMP_LinkInfo>(new IntPtr(p + 0x048)); // 0x48 LinkInfo                    ( ModelEnumListType TMP_LinkInfo[] TMP_LinkInfo[] List<TMP_LinkInfo> Pointer )
            value.LineInfo                                  = GetEnumList<TMP_LineInfo>(new IntPtr(p + 0x050)); // 0x50 LineInfo                    ( ModelEnumListType TMP_LineInfo[] TMP_LineInfo[] List<TMP_LineInfo> Pointer )
            value.PageInfo                                  = GetEnumList<TMP_PageInfo>(new IntPtr(p + 0x058)); // 0x58 PageInfo                    ( ModelEnumListType TMP_PageInfo[] TMP_PageInfo[] List<TMP_PageInfo> Pointer )
            value.MeshInfo                                  = GetEnumList<TMP_MeshInfo>(new IntPtr(p + 0x060)); // 0x60 MeshInfo                    ( ModelEnumListType TMP_MeshInfo[] TMP_MeshInfo[] List<TMP_MeshInfo> Pointer )
            value.M_CachedMeshInfo                          = GetEnumList<TMP_MeshInfo>(new IntPtr(p + 0x068)); // 0x68 M_CachedMeshInfo            ( ModelEnumListType TMP_MeshInfo[] TMP_MeshInfo[] List<TMP_MeshInfo> Pointer )

            return value;
        }
    }
}
