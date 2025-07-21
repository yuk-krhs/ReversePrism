using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 ElementScope                             ModelClassType ByteStack ByteStack ByteStack Pointer
    // 098 CurrentElementProperties                 ModelEnumType ElementProperties ElementProperties ElementProperties Int32
    // 09C CurrentAttributeProperties               ModelEnumType AttributeProperties AttributeProperties AttributeProperties Int32
    // 0A0 EndsWithAmpersand                        ModelPrimitiveType bool bool bool Bool
    // 0A8 UriEscapingBuffer                        ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 0B0 MediaType                                ModelPrimitiveType string string string String
    // 0B8 DoNotEscapeUriAttributes                 ModelPrimitiveType bool bool bool Bool
    // 000 elementPropertySearch                    TernaryTreeReadOnly IL2CPP_TYPE_CLASS
    // 008 attributePropertySearch                  TernaryTreeReadOnly IL2CPP_TYPE_CLASS
    public partial class HtmlUtf8RawTextWriter : DataModel
    {
        public ByteStack?                               ElementScope                            { get; set; }
        public ElementProperties                        CurrentElementProperties                { get; set; }
        public AttributeProperties                      CurrentAttributeProperties              { get; set; }
        public bool                                     EndsWithAmpersand                       { get; set; }
        public List<sbyte>?                             UriEscapingBuffer                       { get; set; }
        public string                                   MediaType                               { get; set; }
        public bool                                     DoNotEscapeUriAttributes                { get; set; }

        public static HtmlUtf8RawTextWriter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HtmlUtf8RawTextWriter() { Pointer= p0 };

            value.ElementScope                              = GetObject<ByteStack>(new IntPtr(p + 0x090), ReversePrism.DataModels.ByteStack.FromPointer); // 0x90 ElementScope                ( ModelClassType ByteStack ByteStack ByteStack Pointer )
            value.CurrentElementProperties                  = (ElementProperties)GetInt32(new IntPtr(p + 0x098)); // 0x98 CurrentElementProperties    ( ModelEnumType ElementProperties ElementProperties ElementProperties Int32 )
            value.CurrentAttributeProperties                = (AttributeProperties)GetInt32(new IntPtr(p + 0x09C)); // 0x9C CurrentAttributeProperties  ( ModelEnumType AttributeProperties AttributeProperties AttributeProperties Int32 )
            value.EndsWithAmpersand                         = GetBool(new IntPtr(p + 0x0A0)); // 0xA0 EndsWithAmpersand           ( ModelPrimitiveType bool bool bool Bool )
            value.UriEscapingBuffer                         = GetSByteList(new IntPtr(p + 0x0A8)); // 0xA8 UriEscapingBuffer           ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.MediaType                                 = GetString(new IntPtr(p + 0x0B0)); // 0xB0 MediaType                   ( ModelPrimitiveType string string string String )
            value.DoNotEscapeUriAttributes                  = GetBool(new IntPtr(p + 0x0B8)); // 0xB8 DoNotEscapeUriAttributes    ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
