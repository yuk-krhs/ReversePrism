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
    // 010 TextComponent                            000186613DC0 ModelClassType TMP_Text TMP_Text TMP_Text Pointer
    // 018 CharacterCount                           0001865F36C0 ModelPrimitiveType int int int Int32
    // 01C SpriteCount                              0001865F36C0 ModelPrimitiveType int int int Int32
    // 020 SpaceCount                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 024 WordCount                                0001865F36C0 ModelPrimitiveType int int int Int32
    // 028 LinkCount                                0001865F36C0 ModelPrimitiveType int int int Int32
    // 02C LineCount                                0001865F36C0 ModelPrimitiveType int int int Int32
    // 030 PageCount                                0001865F36C0 ModelPrimitiveType int int int Int32
    // 034 MaterialCount                            0001865F36C0 ModelPrimitiveType int int int Int32
    // 038 CharacterInfo                            000185CA8C48 ModelEnumListType TMP_CharacterInfo[] TMP_CharacterInfo[] List<TMP_CharacterInfo> Pointer
    // 040 WordInfo                                 000185CA9DC8 ModelEnumListType TMP_WordInfo[] TMP_WordInfo[] List<TMP_WordInfo> Pointer
    // 048 LinkInfo                                 000185CA92D8 ModelEnumListType TMP_LinkInfo[] TMP_LinkInfo[] List<TMP_LinkInfo> Pointer
    // 050 LineInfo                                 000185CA90F8 ModelEnumListType TMP_LineInfo[] TMP_LineInfo[] List<TMP_LineInfo> Pointer
    // 058 PageInfo                                 000185CA97D8 ModelEnumListType TMP_PageInfo[] TMP_PageInfo[] List<TMP_PageInfo> Pointer
    // 060 MeshInfo                                 000185CA96C8 ModelEnumListType TMP_MeshInfo[] TMP_MeshInfo[] List<TMP_MeshInfo> Pointer
    // 068 M_CachedMeshInfo                         000185CA95E8 ModelEnumListType TMP_MeshInfo[] TMP_MeshInfo[] List<TMP_MeshInfo> Pointer
    public partial class TMP_TextInfo
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
            var value   = new TMP_TextInfo();

            value.TextComponent                             = GetObject<TMP_Text>(new IntPtr(p + 0x010), ReversePrism.DataModels.TMP_Text.FromPointer); // 027003A07050 0x10 TextComponent               ( 000186613DC0 ModelClassType TMP_Text TMP_Text TMP_Text Pointer )
            value.CharacterCount                            = GetInt32(new IntPtr(p + 0x018)); // 027003A07070 0x18 CharacterCount              ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.SpriteCount                               = GetInt32(new IntPtr(p + 0x01C)); // 027003A07090 0x1C SpriteCount                 ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.SpaceCount                                = GetInt32(new IntPtr(p + 0x020)); // 027003A070B0 0x20 SpaceCount                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.WordCount                                 = GetInt32(new IntPtr(p + 0x024)); // 027003A070D0 0x24 WordCount                   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.LinkCount                                 = GetInt32(new IntPtr(p + 0x028)); // 027003A070F0 0x28 LinkCount                   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.LineCount                                 = GetInt32(new IntPtr(p + 0x02C)); // 027003A07110 0x2C LineCount                   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.PageCount                                 = GetInt32(new IntPtr(p + 0x030)); // 027003A07130 0x30 PageCount                   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.MaterialCount                             = GetInt32(new IntPtr(p + 0x034)); // 027003A07150 0x34 MaterialCount               ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.CharacterInfo                             = GetEnumList<TMP_CharacterInfo>(new IntPtr(p + 0x038)); // 027003A07170 0x38 CharacterInfo               ( 000185CA8C48 ModelEnumListType TMP_CharacterInfo[] TMP_CharacterInfo[] List<TMP_CharacterInfo> Pointer )
            value.WordInfo                                  = GetEnumList<TMP_WordInfo>(new IntPtr(p + 0x040)); // 027003A07190 0x40 WordInfo                    ( 000185CA9DC8 ModelEnumListType TMP_WordInfo[] TMP_WordInfo[] List<TMP_WordInfo> Pointer )
            value.LinkInfo                                  = GetEnumList<TMP_LinkInfo>(new IntPtr(p + 0x048)); // 027003A071B0 0x48 LinkInfo                    ( 000185CA92D8 ModelEnumListType TMP_LinkInfo[] TMP_LinkInfo[] List<TMP_LinkInfo> Pointer )
            value.LineInfo                                  = GetEnumList<TMP_LineInfo>(new IntPtr(p + 0x050)); // 027003A071D0 0x50 LineInfo                    ( 000185CA90F8 ModelEnumListType TMP_LineInfo[] TMP_LineInfo[] List<TMP_LineInfo> Pointer )
            value.PageInfo                                  = GetEnumList<TMP_PageInfo>(new IntPtr(p + 0x058)); // 027003A071F0 0x58 PageInfo                    ( 000185CA97D8 ModelEnumListType TMP_PageInfo[] TMP_PageInfo[] List<TMP_PageInfo> Pointer )
            value.MeshInfo                                  = GetEnumList<TMP_MeshInfo>(new IntPtr(p + 0x060)); // 027003A07210 0x60 MeshInfo                    ( 000185CA96C8 ModelEnumListType TMP_MeshInfo[] TMP_MeshInfo[] List<TMP_MeshInfo> Pointer )
            value.M_CachedMeshInfo                          = GetEnumList<TMP_MeshInfo>(new IntPtr(p + 0x068)); // 027003A07230 0x68 M_CachedMeshInfo            ( 000185CA95E8 ModelEnumListType TMP_MeshInfo[] TMP_MeshInfo[] List<TMP_MeshInfo> Pointer )

            return value;
        }
    }
}
