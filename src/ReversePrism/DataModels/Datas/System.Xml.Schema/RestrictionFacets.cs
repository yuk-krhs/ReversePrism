using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Length                                   ModelPrimitiveType int int int Int32
    // 014 MinLength                                ModelPrimitiveType int int int Int32
    // 018 MaxLength                                ModelPrimitiveType int int int Int32
    // 020 Patterns                                 ModelClassType ArrayList ArrayList ArrayList Pointer
    // 028 Enumeration                              ModelClassType ArrayList ArrayList ArrayList Pointer
    // 030 WhiteSpace                               ModelEnumType XmlSchemaWhiteSpace XmlSchemaWhiteSpace XmlSchemaWhiteSpace Int32
    // 038 MaxInclusive                             <object> IL2CPP_TYPE_OBJECT
    // 040 MaxExclusive                             <object> IL2CPP_TYPE_OBJECT
    // 048 MinInclusive                             <object> IL2CPP_TYPE_OBJECT
    // 050 MinExclusive                             <object> IL2CPP_TYPE_OBJECT
    // 058 TotalDigits                              ModelPrimitiveType int int int Int32
    // 05C FractionDigits                           ModelPrimitiveType int int int Int32
    // 060 Flags                                    ModelEnumType RestrictionFlags RestrictionFlags RestrictionFlags Int32
    // 064 FixedFlags                               ModelEnumType RestrictionFlags RestrictionFlags RestrictionFlags Int32
    public partial class RestrictionFacets : DataModel
    {
        public int                                      Length                                  { get; set; }
        public int                                      MinLength                               { get; set; }
        public int                                      MaxLength                               { get; set; }
        public ArrayList?                               Patterns                                { get; set; }
        public ArrayList?                               Enumeration                             { get; set; }
        public XmlSchemaWhiteSpace                      WhiteSpace                              { get; set; }
        public int                                      TotalDigits                             { get; set; }
        public int                                      FractionDigits                          { get; set; }
        public RestrictionFlags                         Flags                                   { get; set; }
        public RestrictionFlags                         FixedFlags                              { get; set; }

        public static RestrictionFacets? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RestrictionFacets() { Pointer= p0 };

            value.Length                                    = GetInt32(new IntPtr(p + 0x010)); // 0x10 Length                      ( ModelPrimitiveType int int int Int32 )
            value.MinLength                                 = GetInt32(new IntPtr(p + 0x014)); // 0x14 MinLength                   ( ModelPrimitiveType int int int Int32 )
            value.MaxLength                                 = GetInt32(new IntPtr(p + 0x018)); // 0x18 MaxLength                   ( ModelPrimitiveType int int int Int32 )
            value.Patterns                                  = GetObject<ArrayList>(new IntPtr(p + 0x020), ReversePrism.DataModels.ArrayList.FromPointer); // 0x20 Patterns                    ( ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.Enumeration                               = GetObject<ArrayList>(new IntPtr(p + 0x028), ReversePrism.DataModels.ArrayList.FromPointer); // 0x28 Enumeration                 ( ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.WhiteSpace                                = (XmlSchemaWhiteSpace)GetInt32(new IntPtr(p + 0x030)); // 0x30 WhiteSpace                  ( ModelEnumType XmlSchemaWhiteSpace XmlSchemaWhiteSpace XmlSchemaWhiteSpace Int32 )
            value.TotalDigits                               = GetInt32(new IntPtr(p + 0x058)); // 0x58 TotalDigits                 ( ModelPrimitiveType int int int Int32 )
            value.FractionDigits                            = GetInt32(new IntPtr(p + 0x05C)); // 0x5C FractionDigits              ( ModelPrimitiveType int int int Int32 )
            value.Flags                                     = (RestrictionFlags)GetInt32(new IntPtr(p + 0x060)); // 0x60 Flags                       ( ModelEnumType RestrictionFlags RestrictionFlags RestrictionFlags Int32 )
            value.FixedFlags                                = (RestrictionFlags)GetInt32(new IntPtr(p + 0x064)); // 0x64 FixedFlags                  ( ModelEnumType RestrictionFlags RestrictionFlags RestrictionFlags Int32 )

            return value;
        }
    }
}
