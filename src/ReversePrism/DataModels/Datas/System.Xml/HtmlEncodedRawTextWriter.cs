using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0C0 ElementScope                             00018651D300 ModelClassType ByteStack ByteStack ByteStack Pointer
    // 0C8 CurrentElementProperties                 000186723250 ModelEnumType ElementProperties ElementProperties ElementProperties Int32
    // 0CC CurrentAttributeProperties               000186713220 ModelEnumType AttributeProperties AttributeProperties AttributeProperties Int32
    // 0D0 EndsWithAmpersand                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0D8 UriEscapingBuffer                        000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 0E0 MediaType                                000186671910 ModelPrimitiveType string string string String
    // 0E8 DoNotEscapeUriAttributes                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 elementPropertySearch                    TernaryTreeReadOnly IL2CPP_TYPE_CLASS
    // 008 attributePropertySearch                  TernaryTreeReadOnly IL2CPP_TYPE_CLASS
    public partial class HtmlEncodedRawTextWriter
    {
        public ByteStack?                               ElementScope                            { get; set; }
        public ElementProperties                        CurrentElementProperties                { get; set; }
        public AttributeProperties                      CurrentAttributeProperties              { get; set; }
        public bool                                     EndsWithAmpersand                       { get; set; }
        public List<sbyte>?                             UriEscapingBuffer                       { get; set; }
        public string                                   MediaType                               { get; set; }
        public bool                                     DoNotEscapeUriAttributes                { get; set; }

        public static HtmlEncodedRawTextWriter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HtmlEncodedRawTextWriter();

            value.ElementScope                              = GetObject<ByteStack>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.ByteStack.FromPointer); // 0270D73692F8 0xC0 ElementScope                ( 00018651D300 ModelClassType ByteStack ByteStack ByteStack Pointer )
            value.CurrentElementProperties                  = (ElementProperties)GetInt32(new IntPtr(p + 0x0C8)); // 0270D7369318 0xC8 CurrentElementProperties    ( 000186723250 ModelEnumType ElementProperties ElementProperties ElementProperties Int32 )
            value.CurrentAttributeProperties                = (AttributeProperties)GetInt32(new IntPtr(p + 0x0CC)); // 0270D7369338 0xCC CurrentAttributeProperties  ( 000186713220 ModelEnumType AttributeProperties AttributeProperties AttributeProperties Int32 )
            value.EndsWithAmpersand                         = GetBool(new IntPtr(p + 0x0D0)); // 0270D7369358 0xD0 EndsWithAmpersand           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.UriEscapingBuffer                         = GetSByteList(new IntPtr(p + 0x0D8)); // 0270D7369378 0xD8 UriEscapingBuffer           ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.MediaType                                 = GetString(new IntPtr(p + 0x0E0)); // 0270D7369398 0xE0 MediaType                   ( 000186671910 ModelPrimitiveType string string string String )
            value.DoNotEscapeUriAttributes                  = GetBool(new IntPtr(p + 0x0E8)); // 0270D73693B8 0xE8 DoNotEscapeUriAttributes    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
