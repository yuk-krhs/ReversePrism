using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_value                                  ModelPrimitiveType string string string String
    // 018 M_cmpInfo                                ModelClassType CompareInfo CompareInfo CompareInfo Pointer
    // 020 M_lcid                                   ModelPrimitiveType int int int Int32
    // 024 M_flag                                   ModelEnumType SqlCompareOptions SqlCompareOptions SqlCompareOptions Int32
    // 028 M_fNotNull                               ModelPrimitiveType bool bool bool Bool
    // 000 Null                                     SqlString IL2CPP_TYPE_VALUETYPE
    // 020 S_unicodeEncoding                        ModelClassType UnicodeEncoding UnicodeEncoding UnicodeEncoding Pointer
    // 028 IgnoreCase                               ModelPrimitiveType int int int Int32
    // 02C IgnoreWidth                              ModelPrimitiveType int int int Int32
    // 030 IgnoreNonSpace                           ModelPrimitiveType int int int Int32
    // 034 IgnoreKanaType                           ModelPrimitiveType int int int Int32
    // 038 BinarySort                               ModelPrimitiveType int int int Int32
    // 03C BinarySort2                              ModelPrimitiveType int int int Int32
    // 040 S_iDefaultFlag                           ModelEnumType SqlCompareOptions SqlCompareOptions SqlCompareOptions Int32
    // 044 S_iValidCompareOptionMask                ModelEnumType CompareOptions CompareOptions CompareOptions Int32
    // 048 S_iValidSqlCompareOptionMask             ModelEnumType SqlCompareOptions SqlCompareOptions SqlCompareOptions Int32
    // 04C S_lcidUSEnglish                          ModelPrimitiveType int int int Int32
    // 050 S_lcidBinary                             ModelPrimitiveType int int int Int32
    public partial class SqlString : DataModel
    {
        public string                                   M_value                                 { get; set; }
        public CompareInfo?                             M_cmpInfo                               { get; set; }
        public int                                      M_lcid                                  { get; set; }
        public SqlCompareOptions                        M_flag                                  { get; set; }
        public bool                                     M_fNotNull                              { get; set; }
        public UnicodeEncoding?                         S_unicodeEncoding                       { get; set; }
        public int                                      IgnoreCase                              { get; set; }
        public int                                      IgnoreWidth                             { get; set; }
        public int                                      IgnoreNonSpace                          { get; set; }
        public int                                      IgnoreKanaType                          { get; set; }
        public int                                      BinarySort                              { get; set; }
        public int                                      BinarySort2                             { get; set; }
        public SqlCompareOptions                        S_iDefaultFlag                          { get; set; }
        public CompareOptions                           S_iValidCompareOptionMask               { get; set; }
        public SqlCompareOptions                        S_iValidSqlCompareOptionMask            { get; set; }
        public int                                      S_lcidUSEnglish                         { get; set; }
        public int                                      S_lcidBinary                            { get; set; }

        public static SqlString? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SqlString() { Pointer= p0 };

            value.M_value                                   = GetString(new IntPtr(p + 0x010)); // 0x10 M_value                     ( ModelPrimitiveType string string string String )
            value.M_cmpInfo                                 = GetObject<CompareInfo>(new IntPtr(p + 0x018), ReversePrism.DataModels.CompareInfo.FromPointer); // 0x18 M_cmpInfo                   ( ModelClassType CompareInfo CompareInfo CompareInfo Pointer )
            value.M_lcid                                    = GetInt32(new IntPtr(p + 0x020)); // 0x20 M_lcid                      ( ModelPrimitiveType int int int Int32 )
            value.M_flag                                    = (SqlCompareOptions)GetInt32(new IntPtr(p + 0x024)); // 0x24 M_flag                      ( ModelEnumType SqlCompareOptions SqlCompareOptions SqlCompareOptions Int32 )
            value.M_fNotNull                                = GetBool(new IntPtr(p + 0x028)); // 0x28 M_fNotNull                  ( ModelPrimitiveType bool bool bool Bool )
            value.S_unicodeEncoding                         = GetObject<UnicodeEncoding>(new IntPtr(p + 0x020), ReversePrism.DataModels.UnicodeEncoding.FromPointer); // 0x20 S_unicodeEncoding           ( ModelClassType UnicodeEncoding UnicodeEncoding UnicodeEncoding Pointer )
            value.IgnoreCase                                = GetInt32(new IntPtr(p + 0x028)); // 0x28 IgnoreCase                  ( ModelPrimitiveType int int int Int32 )
            value.IgnoreWidth                               = GetInt32(new IntPtr(p + 0x02C)); // 0x2C IgnoreWidth                 ( ModelPrimitiveType int int int Int32 )
            value.IgnoreNonSpace                            = GetInt32(new IntPtr(p + 0x030)); // 0x30 IgnoreNonSpace              ( ModelPrimitiveType int int int Int32 )
            value.IgnoreKanaType                            = GetInt32(new IntPtr(p + 0x034)); // 0x34 IgnoreKanaType              ( ModelPrimitiveType int int int Int32 )
            value.BinarySort                                = GetInt32(new IntPtr(p + 0x038)); // 0x38 BinarySort                  ( ModelPrimitiveType int int int Int32 )
            value.BinarySort2                               = GetInt32(new IntPtr(p + 0x03C)); // 0x3C BinarySort2                 ( ModelPrimitiveType int int int Int32 )
            value.S_iDefaultFlag                            = (SqlCompareOptions)GetInt32(new IntPtr(p + 0x040)); // 0x40 S_iDefaultFlag              ( ModelEnumType SqlCompareOptions SqlCompareOptions SqlCompareOptions Int32 )
            value.S_iValidCompareOptionMask                 = (CompareOptions)GetInt32(new IntPtr(p + 0x044)); // 0x44 S_iValidCompareOptionMask   ( ModelEnumType CompareOptions CompareOptions CompareOptions Int32 )
            value.S_iValidSqlCompareOptionMask              = (SqlCompareOptions)GetInt32(new IntPtr(p + 0x048)); // 0x48 S_iValidSqlCompareOptionMask ( ModelEnumType SqlCompareOptions SqlCompareOptions SqlCompareOptions Int32 )
            value.S_lcidUSEnglish                           = GetInt32(new IntPtr(p + 0x04C)); // 0x4C S_lcidUSEnglish             ( ModelPrimitiveType int int int Int32 )
            value.S_lcidBinary                              = GetInt32(new IntPtr(p + 0x050)); // 0x50 S_lcidBinary                ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
