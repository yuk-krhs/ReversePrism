using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 invariant                                SimpleCollator IL2CPP_TYPE_CLASS
    // 010 TextInfo                                 ModelClassType TextInfo TextInfo TextInfo Pointer
    // 018 CjkIndexer                               ModelClassType CodePointIndexer CodePointIndexer CodePointIndexer Pointer
    // 020 Contractions                             ModelClassListType Contraction[] Contraction[] List<Contraction> Pointer
    // 028 Level2Maps                               ModelClassListType Level2Map[] Level2Map[] List<Level2Map> Pointer
    // 030 UnsafeFlags                              ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 038 cjkCatTable                              IntPtr IL2CPP_TYPE_PTR
    // 040 cjkLv1Table                              IntPtr IL2CPP_TYPE_PTR
    // 048 cjkLv2Table                              IntPtr IL2CPP_TYPE_PTR
    // 050 CjkLv2Indexer                            ModelClassType CodePointIndexer CodePointIndexer CodePointIndexer Pointer
    // 058 Lcid                                     ModelPrimitiveType int int int Int32
    // 05C FrenchSort                               ModelPrimitiveType bool bool bool Bool
    public partial class SimpleCollator : DataModel
    {
        public TextInfo?                                TextInfo                                { get; set; }
        public CodePointIndexer?                        CjkIndexer                              { get; set; }
        public List<Contraction>?                       Contractions                            { get; set; }
        public List<Level2Map>?                         Level2Maps                              { get; set; }
        public List<sbyte>?                             UnsafeFlags                             { get; set; }
        public CodePointIndexer?                        CjkLv2Indexer                           { get; set; }
        public int                                      Lcid                                    { get; set; }
        public bool                                     FrenchSort                              { get; set; }

        public static SimpleCollator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SimpleCollator() { Pointer= p0 };

            value.TextInfo                                  = GetObject<TextInfo>(new IntPtr(p + 0x010), ReversePrism.DataModels.TextInfo.FromPointer); // 0x10 TextInfo                    ( ModelClassType TextInfo TextInfo TextInfo Pointer )
            value.CjkIndexer                                = GetObject<CodePointIndexer>(new IntPtr(p + 0x018), ReversePrism.DataModels.CodePointIndexer.FromPointer); // 0x18 CjkIndexer                  ( ModelClassType CodePointIndexer CodePointIndexer CodePointIndexer Pointer )
            value.Contractions                              = GetObjectList<Contraction>(new IntPtr(p + 0x020), ReversePrism.DataModels.Contraction.FromPointer); // 0x20 Contractions                ( ModelClassListType Contraction[] Contraction[] List<Contraction> Pointer )
            value.Level2Maps                                = GetObjectList<Level2Map>(new IntPtr(p + 0x028), ReversePrism.DataModels.Level2Map.FromPointer); // 0x28 Level2Maps                  ( ModelClassListType Level2Map[] Level2Map[] List<Level2Map> Pointer )
            value.UnsafeFlags                               = GetSByteList(new IntPtr(p + 0x030)); // 0x30 UnsafeFlags                 ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.CjkLv2Indexer                             = GetObject<CodePointIndexer>(new IntPtr(p + 0x050), ReversePrism.DataModels.CodePointIndexer.FromPointer); // 0x50 CjkLv2Indexer               ( ModelClassType CodePointIndexer CodePointIndexer CodePointIndexer Pointer )
            value.Lcid                                      = GetInt32(new IntPtr(p + 0x058)); // 0x58 Lcid                        ( ModelPrimitiveType int int int Int32 )
            value.FrenchSort                                = GetBool(new IntPtr(p + 0x05C)); // 0x5C FrenchSort                  ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
