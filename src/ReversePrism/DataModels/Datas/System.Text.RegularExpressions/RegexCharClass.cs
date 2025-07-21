using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_internalRegexIgnoreCase                string IL2CPP_TYPE_STRING
    // 008 s_space                                  string IL2CPP_TYPE_STRING
    // 010 S_notSpace                               ModelPrimitiveType string string string String
    // 018 S_word                                   ModelPrimitiveType string string string String
    // 020 S_notWord                                ModelPrimitiveType string string string String
    // 028 SpaceClass                               ModelPrimitiveType string string string String
    // 030 NotSpaceClass                            ModelPrimitiveType string string string String
    // 038 WordClass                                ModelPrimitiveType string string string String
    // 040 NotWordClass                             ModelPrimitiveType string string string String
    // 048 DigitClass                               ModelPrimitiveType string string string String
    // 050 NotDigitClass                            ModelPrimitiveType string string string String
    // 058 s_definedCategories                      Dictionary`2<string, string> IL2CPP_TYPE_GENERICINST
    // 060 s_propTable                              string[][] IL2CPP_TYPE_SZARRAY
    // 068 S_lcTable                                ModelEnumListType LowerCaseMapping[] LowerCaseMapping[] List<LowerCaseMapping> Pointer
    // 010 Rangelist                                ModelEnumListType List`1<SingleRange> List`1<SingleRange> List<SingleRange> Pointer
    // 018 Categories                               ModelClassType StringBuilder StringBuilder StringBuilder Pointer
    // 020 Canonical                                ModelPrimitiveType bool bool bool Bool
    // 021 Negate                                   ModelPrimitiveType bool bool bool Bool
    // 028 Subtractor                               ModelClassType RegexCharClass RegexCharClass RegexCharClass Pointer
    public partial class RegexCharClass : DataModel
    {
        public string                                   S_notSpace                              { get; set; }
        public string                                   S_word                                  { get; set; }
        public string                                   S_notWord                               { get; set; }
        public string                                   SpaceClass                              { get; set; }
        public string                                   NotSpaceClass                           { get; set; }
        public string                                   WordClass                               { get; set; }
        public string                                   NotWordClass                            { get; set; }
        public string                                   DigitClass                              { get; set; }
        public string                                   NotDigitClass                           { get; set; }
        public List<LowerCaseMapping>?                  S_lcTable                               { get; set; }
        public List<SingleRange>?                       Rangelist                               { get; set; }
        public StringBuilder?                           Categories                              { get; set; }
        public bool                                     Canonical                               { get; set; }
        public bool                                     Negate                                  { get; set; }
        public RegexCharClass?                          Subtractor                              { get; set; }

        public static RegexCharClass? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RegexCharClass() { Pointer= p0 };

            value.S_notSpace                                = GetString(new IntPtr(p + 0x010)); // 0x10 S_notSpace                  ( ModelPrimitiveType string string string String )
            value.S_word                                    = GetString(new IntPtr(p + 0x018)); // 0x18 S_word                      ( ModelPrimitiveType string string string String )
            value.S_notWord                                 = GetString(new IntPtr(p + 0x020)); // 0x20 S_notWord                   ( ModelPrimitiveType string string string String )
            value.SpaceClass                                = GetString(new IntPtr(p + 0x028)); // 0x28 SpaceClass                  ( ModelPrimitiveType string string string String )
            value.NotSpaceClass                             = GetString(new IntPtr(p + 0x030)); // 0x30 NotSpaceClass               ( ModelPrimitiveType string string string String )
            value.WordClass                                 = GetString(new IntPtr(p + 0x038)); // 0x38 WordClass                   ( ModelPrimitiveType string string string String )
            value.NotWordClass                              = GetString(new IntPtr(p + 0x040)); // 0x40 NotWordClass                ( ModelPrimitiveType string string string String )
            value.DigitClass                                = GetString(new IntPtr(p + 0x048)); // 0x48 DigitClass                  ( ModelPrimitiveType string string string String )
            value.NotDigitClass                             = GetString(new IntPtr(p + 0x050)); // 0x50 NotDigitClass               ( ModelPrimitiveType string string string String )
            value.S_lcTable                                 = GetEnumList<LowerCaseMapping>(new IntPtr(p + 0x068)); // 0x68 S_lcTable                   ( ModelEnumListType LowerCaseMapping[] LowerCaseMapping[] List<LowerCaseMapping> Pointer )
            value.Rangelist                                 = GetEnumList<SingleRange>(new IntPtr(p + 0x010)); // 0x10 Rangelist                   ( ModelEnumListType List`1<SingleRange> List`1<SingleRange> List<SingleRange> Pointer )
            value.Categories                                = GetObject<StringBuilder>(new IntPtr(p + 0x018), ReversePrism.DataModels.StringBuilder.FromPointer); // 0x18 Categories                  ( ModelClassType StringBuilder StringBuilder StringBuilder Pointer )
            value.Canonical                                 = GetBool(new IntPtr(p + 0x020)); // 0x20 Canonical                   ( ModelPrimitiveType bool bool bool Bool )
            value.Negate                                    = GetBool(new IntPtr(p + 0x021)); // 0x21 Negate                      ( ModelPrimitiveType bool bool bool Bool )
            value.Subtractor                                = GetObject<RegexCharClass>(new IntPtr(p + 0x028), ReversePrism.DataModels.RegexCharClass.FromPointer); // 0x28 Subtractor                  ( ModelClassType RegexCharClass RegexCharClass RegexCharClass Pointer )

            return value;
        }
    }
}
