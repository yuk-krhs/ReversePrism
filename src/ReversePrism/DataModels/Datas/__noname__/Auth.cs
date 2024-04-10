using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<Auth> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 PrincipalFieldNumber                     int IL2CPP_TYPE_I4
    // 018 Principal                                000186671910 ModelPrimitiveType string string string String
    // 000 AudiencesFieldNumber                     int IL2CPP_TYPE_I4
    // 008 _repeated_audiences_codec                FieldCodec`1<string> IL2CPP_TYPE_GENERICINST
    // 020 Audiences                                000185CF3478 ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer
    // 000 PresenterFieldNumber                     int IL2CPP_TYPE_I4
    // 028 Presenter                                000186671910 ModelPrimitiveType string string string String
    // 000 ClaimsFieldNumber                        int IL2CPP_TYPE_I4
    // 030 Claims                                   0001865C4EE0 ModelClassType Struct Struct Struct Pointer
    // 000 AccessLevelsFieldNumber                  int IL2CPP_TYPE_I4
    // 010 _repeated_accessLevels_codec             FieldCodec`1<string> IL2CPP_TYPE_GENERICINST
    // 038 AccessLevels                             000185CF3478 ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer
    public partial class Auth : DataModel
    {
        public string                                   Principal                               { get; set; }
        public List<string>?                            Audiences                               { get; set; }
        public string                                   Presenter                               { get; set; }
        public Struct?                                  Claims                                  { get; set; }
        public List<string>?                            AccessLevels                            { get; set; }

        public static Auth? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Auth() { Pointer= p0 };

            value.Principal                                 = GetString(new IntPtr(p + 0x018)); // 02466A76EB10 0x18 Principal                   ( 000186671910 ModelPrimitiveType string string string String )
            value.Audiences                                 = GetStringList(new IntPtr(p + 0x020)); // 02466A76EB70 0x20 Audiences                   ( 000185CF3478 ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer )
            value.Presenter                                 = GetString(new IntPtr(p + 0x028)); // 02466A76EBB0 0x28 Presenter                   ( 000186671910 ModelPrimitiveType string string string String )
            value.Claims                                    = GetObject<Struct>(new IntPtr(p + 0x030), ReversePrism.DataModels.Struct.FromPointer); // 02466A76EBF0 0x30 Claims                      ( 0001865C4EE0 ModelClassType Struct Struct Struct Pointer )
            value.AccessLevels                              = GetStringList(new IntPtr(p + 0x038)); // 02466A76EC50 0x38 AccessLevels                ( 000185CF3478 ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer )

            return value;
        }
    }
}
