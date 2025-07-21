using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Level                                    ModelEnumType NtlmAuthLevel NtlmAuthLevel NtlmAuthLevel Int32
    // 020 Challenge                                ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 028 Host                                     ModelPrimitiveType string string string String
    // 030 Domain                                   ModelPrimitiveType string string string String
    // 038 Username                                 ModelPrimitiveType string string string String
    // 040 Password                                 ModelPrimitiveType string string string String
    // 048 Type2                                    ModelClassType Type2Message Type2Message Type2Message Pointer
    // 050 Lm                                       ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 058 Nt                                       ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    public partial class Type3Message : DataModel
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
            var value   = new Type3Message() { Pointer= p0 };

            value.Level                                     = (NtlmAuthLevel)GetInt32(new IntPtr(p + 0x018)); // 0x18 Level                       ( ModelEnumType NtlmAuthLevel NtlmAuthLevel NtlmAuthLevel Int32 )
            value.Challenge                                 = GetSByteList(new IntPtr(p + 0x020)); // 0x20 Challenge                   ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Host                                      = GetString(new IntPtr(p + 0x028)); // 0x28 Host                        ( ModelPrimitiveType string string string String )
            value.Domain                                    = GetString(new IntPtr(p + 0x030)); // 0x30 Domain                      ( ModelPrimitiveType string string string String )
            value.Username                                  = GetString(new IntPtr(p + 0x038)); // 0x38 Username                    ( ModelPrimitiveType string string string String )
            value.Password                                  = GetString(new IntPtr(p + 0x040)); // 0x40 Password                    ( ModelPrimitiveType string string string String )
            value.Type2                                     = GetObject<Type2Message>(new IntPtr(p + 0x048), ReversePrism.DataModels.Type2Message.FromPointer); // 0x48 Type2                       ( ModelClassType Type2Message Type2Message Type2Message Pointer )
            value.Lm                                        = GetSByteList(new IntPtr(p + 0x050)); // 0x50 Lm                          ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Nt                                        = GetSByteList(new IntPtr(p + 0x058)); // 0x58 Nt                          ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )

            return value;
        }
    }
}
