using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<PostalAddress> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 RevisionFieldNumber                      int IL2CPP_TYPE_I4
    // 018 Revision                                 ModelPrimitiveType int int int Int32
    // 000 RegionCodeFieldNumber                    int IL2CPP_TYPE_I4
    // 020 RegionCode                               ModelPrimitiveType string string string String
    // 000 LanguageCodeFieldNumber                  int IL2CPP_TYPE_I4
    // 028 LanguageCode                             ModelPrimitiveType string string string String
    // 000 PostalCodeFieldNumber                    int IL2CPP_TYPE_I4
    // 030 PostalCode                               ModelPrimitiveType string string string String
    // 000 SortingCodeFieldNumber                   int IL2CPP_TYPE_I4
    // 038 SortingCode                              ModelPrimitiveType string string string String
    // 000 AdministrativeAreaFieldNumber            int IL2CPP_TYPE_I4
    // 040 AdministrativeArea                       ModelPrimitiveType string string string String
    // 000 LocalityFieldNumber                      int IL2CPP_TYPE_I4
    // 048 Locality                                 ModelPrimitiveType string string string String
    // 000 SublocalityFieldNumber                   int IL2CPP_TYPE_I4
    // 050 Sublocality                              ModelPrimitiveType string string string String
    // 000 AddressLinesFieldNumber                  int IL2CPP_TYPE_I4
    // 008 _repeated_addressLines_codec             FieldCodec`1<string> IL2CPP_TYPE_GENERICINST
    // 058 AddressLines                             ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer
    // 000 RecipientsFieldNumber                    int IL2CPP_TYPE_I4
    // 010 _repeated_recipients_codec               FieldCodec`1<string> IL2CPP_TYPE_GENERICINST
    // 060 Recipients                               ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer
    // 000 OrganizationFieldNumber                  int IL2CPP_TYPE_I4
    // 068 Organization                             ModelPrimitiveType string string string String
    public partial class PostalAddress : DataModel
    {
        public int                                      Revision                                { get; set; }
        public string                                   RegionCode                              { get; set; }
        public string                                   LanguageCode                            { get; set; }
        public string                                   PostalCode                              { get; set; }
        public string                                   SortingCode                             { get; set; }
        public string                                   AdministrativeArea                      { get; set; }
        public string                                   Locality                                { get; set; }
        public string                                   Sublocality                             { get; set; }
        public List<string>?                            AddressLines                            { get; set; }
        public List<string>?                            Recipients                              { get; set; }
        public string                                   Organization                            { get; set; }

        public static PostalAddress? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PostalAddress() { Pointer= p0 };

            value.Revision                                  = GetInt32(new IntPtr(p + 0x018)); // 0x18 Revision                    ( ModelPrimitiveType int int int Int32 )
            value.RegionCode                                = GetString(new IntPtr(p + 0x020)); // 0x20 RegionCode                  ( ModelPrimitiveType string string string String )
            value.LanguageCode                              = GetString(new IntPtr(p + 0x028)); // 0x28 LanguageCode                ( ModelPrimitiveType string string string String )
            value.PostalCode                                = GetString(new IntPtr(p + 0x030)); // 0x30 PostalCode                  ( ModelPrimitiveType string string string String )
            value.SortingCode                               = GetString(new IntPtr(p + 0x038)); // 0x38 SortingCode                 ( ModelPrimitiveType string string string String )
            value.AdministrativeArea                        = GetString(new IntPtr(p + 0x040)); // 0x40 AdministrativeArea          ( ModelPrimitiveType string string string String )
            value.Locality                                  = GetString(new IntPtr(p + 0x048)); // 0x48 Locality                    ( ModelPrimitiveType string string string String )
            value.Sublocality                               = GetString(new IntPtr(p + 0x050)); // 0x50 Sublocality                 ( ModelPrimitiveType string string string String )
            value.AddressLines                              = GetStringList(new IntPtr(p + 0x058)); // 0x58 AddressLines                ( ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer )
            value.Recipients                                = GetStringList(new IntPtr(p + 0x060)); // 0x60 Recipients                  ( ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer )
            value.Organization                              = GetString(new IntPtr(p + 0x068)); // 0x68 Organization                ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
