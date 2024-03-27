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
    // 018 Revision                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 RegionCodeFieldNumber                    int IL2CPP_TYPE_I4
    // 020 RegionCode                               000186671910 ModelPrimitiveType string string string String
    // 000 LanguageCodeFieldNumber                  int IL2CPP_TYPE_I4
    // 028 LanguageCode                             000186671910 ModelPrimitiveType string string string String
    // 000 PostalCodeFieldNumber                    int IL2CPP_TYPE_I4
    // 030 PostalCode                               000186671910 ModelPrimitiveType string string string String
    // 000 SortingCodeFieldNumber                   int IL2CPP_TYPE_I4
    // 038 SortingCode                              000186671910 ModelPrimitiveType string string string String
    // 000 AdministrativeAreaFieldNumber            int IL2CPP_TYPE_I4
    // 040 AdministrativeArea                       000186671910 ModelPrimitiveType string string string String
    // 000 LocalityFieldNumber                      int IL2CPP_TYPE_I4
    // 048 Locality                                 000186671910 ModelPrimitiveType string string string String
    // 000 SublocalityFieldNumber                   int IL2CPP_TYPE_I4
    // 050 Sublocality                              000186671910 ModelPrimitiveType string string string String
    // 000 AddressLinesFieldNumber                  int IL2CPP_TYPE_I4
    // 008 _repeated_addressLines_codec             FieldCodec`1<string> IL2CPP_TYPE_GENERICINST
    // 058 AddressLines                             000185CF3478 ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer
    // 000 RecipientsFieldNumber                    int IL2CPP_TYPE_I4
    // 010 _repeated_recipients_codec               FieldCodec`1<string> IL2CPP_TYPE_GENERICINST
    // 060 Recipients                               000185CF3478 ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer
    // 000 OrganizationFieldNumber                  int IL2CPP_TYPE_I4
    // 068 Organization                             000186671910 ModelPrimitiveType string string string String
    public partial class PostalAddress
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
            var value   = new PostalAddress();

            value.Revision                                  = GetInt32(new IntPtr(p + 0x018)); // 0270DA6AE020 0x18 Revision                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.RegionCode                                = GetString(new IntPtr(p + 0x020)); // 0270DA6AE060 0x20 RegionCode                  ( 000186671910 ModelPrimitiveType string string string String )
            value.LanguageCode                              = GetString(new IntPtr(p + 0x028)); // 0270DA6AE0A0 0x28 LanguageCode                ( 000186671910 ModelPrimitiveType string string string String )
            value.PostalCode                                = GetString(new IntPtr(p + 0x030)); // 0270DA6AE0E0 0x30 PostalCode                  ( 000186671910 ModelPrimitiveType string string string String )
            value.SortingCode                               = GetString(new IntPtr(p + 0x038)); // 0270DA6AE120 0x38 SortingCode                 ( 000186671910 ModelPrimitiveType string string string String )
            value.AdministrativeArea                        = GetString(new IntPtr(p + 0x040)); // 0270DA6AE160 0x40 AdministrativeArea          ( 000186671910 ModelPrimitiveType string string string String )
            value.Locality                                  = GetString(new IntPtr(p + 0x048)); // 0270DA6AE1A0 0x48 Locality                    ( 000186671910 ModelPrimitiveType string string string String )
            value.Sublocality                               = GetString(new IntPtr(p + 0x050)); // 0270DA6AE1E0 0x50 Sublocality                 ( 000186671910 ModelPrimitiveType string string string String )
            value.AddressLines                              = GetStringList(new IntPtr(p + 0x058)); // 0270DA6AE240 0x58 AddressLines                ( 000185CF3478 ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer )
            value.Recipients                                = GetStringList(new IntPtr(p + 0x060)); // 0270DA6AE2A0 0x60 Recipients                  ( 000185CF3478 ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer )
            value.Organization                              = GetString(new IntPtr(p + 0x068)); // 0270DA6AE2E0 0x68 Organization                ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
