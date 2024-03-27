using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Level                                    0001866B8DF0 ModelEnumType NtlmAuthLevel NtlmAuthLevel NtlmAuthLevel Int32
    // 020 Challenge                                000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 028 Host                                     000186671910 ModelPrimitiveType string string string String
    // 030 Domain                                   000186671910 ModelPrimitiveType string string string String
    // 038 Username                                 000186671910 ModelPrimitiveType string string string String
    // 040 Password                                 000186671910 ModelPrimitiveType string string string String
    // 048 Type2                                    0001866D0D30 ModelClassType Type2Message Type2Message Type2Message Pointer
    // 050 Lm                                       000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 058 Nt                                       000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    public partial class Type3Message
    {
        public NtlmAuthLevel                            Level                                   { get; set; }
        public List<sbyte>?                             Challenge                               { get; set; }
        public string                                   Host                                    { get; set; }
        public string                                   Domain                                  { get; set; }
        public string                                   Username                                { get; set; }
        public string                                   Password                                { get; set; }
        public Type2Message?                            Type2                                   { get; set; }
        public List<sbyte>?                             Lm                                      { get; set; }
        public List<sbyte>?                             Nt                                      { get; set; }

        public static Type3Message? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Type3Message();

            value.Level                                     = (NtlmAuthLevel)GetInt32(new IntPtr(p + 0x018)); // 0270DB37F6B8 0x18 Level                       ( 0001866B8DF0 ModelEnumType NtlmAuthLevel NtlmAuthLevel NtlmAuthLevel Int32 )
            value.Challenge                                 = GetSByteList(new IntPtr(p + 0x020)); // 0270DB37F6D8 0x20 Challenge                   ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Host                                      = GetString(new IntPtr(p + 0x028)); // 0270DB37F6F8 0x28 Host                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Domain                                    = GetString(new IntPtr(p + 0x030)); // 0270DB37F718 0x30 Domain                      ( 000186671910 ModelPrimitiveType string string string String )
            value.Username                                  = GetString(new IntPtr(p + 0x038)); // 0270DB37F738 0x38 Username                    ( 000186671910 ModelPrimitiveType string string string String )
            value.Password                                  = GetString(new IntPtr(p + 0x040)); // 0270DB37F758 0x40 Password                    ( 000186671910 ModelPrimitiveType string string string String )
            value.Type2                                     = GetObject<Type2Message>(new IntPtr(p + 0x048), ReversePrism.DataModels.Type2Message.FromPointer); // 0270DB37F778 0x48 Type2                       ( 0001866D0D30 ModelClassType Type2Message Type2Message Type2Message Pointer )
            value.Lm                                        = GetSByteList(new IntPtr(p + 0x050)); // 0270DB37F798 0x50 Lm                          ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Nt                                        = GetSByteList(new IntPtr(p + 0x058)); // 0270DB37F7B8 0x58 Nt                          ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )

            return value;
        }
    }
}
