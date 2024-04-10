using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MarshalCookie                            0001866722E0 ModelPrimitiveType string string string String
    // 018 MarshalType                              0001866722E0 ModelPrimitiveType string string string String
    // 020 MarshalTypeRef                           000186692F60 ModelClassType Type Type Type Pointer
    // 028 SafeArrayUserDefinedSubType              000186692F60 ModelClassType Type Type Type Pointer
    // 030 Utype                                    000186734450 ModelEnumType UnmanagedType UnmanagedType UnmanagedType Int32
    // 034 ArraySubType                             0001867346C0 ModelEnumType UnmanagedType UnmanagedType UnmanagedType Int32
    // 038 SafeArraySubType                         000186771D80 ModelEnumType VarEnum VarEnum VarEnum Int32
    // 03C SizeConst                                0001865F36C0 ModelPrimitiveType int int int Int32
    // 040 IidParameterIndex                        0001865F36C0 ModelPrimitiveType int int int Int32
    // 044 SizeParamIndex                           0001865F1520 ModelPrimitiveType short short short Int16
    public partial class MarshalAsAttribute : DataModel
    {
        public string                                   MarshalCookie                           { get; set; }
        public string                                   MarshalType                             { get; set; }
        public Type?                                    MarshalTypeRef                          { get; set; }
        public Type?                                    SafeArrayUserDefinedSubType             { get; set; }
        public UnmanagedType                            Utype                                   { get; set; }
        public UnmanagedType                            ArraySubType                            { get; set; }
        public VarEnum                                  SafeArraySubType                        { get; set; }
        public int                                      SizeConst                               { get; set; }
        public int                                      IidParameterIndex                       { get; set; }
        public short                                    SizeParamIndex                          { get; set; }

        public static MarshalAsAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MarshalAsAttribute() { Pointer= p0 };

            value.MarshalCookie                             = GetString(new IntPtr(p + 0x010)); // 024666D025D8 0x10 MarshalCookie               ( 0001866722E0 ModelPrimitiveType string string string String )
            value.MarshalType                               = GetString(new IntPtr(p + 0x018)); // 024666D025F8 0x18 MarshalType                 ( 0001866722E0 ModelPrimitiveType string string string String )
            value.MarshalTypeRef                            = GetObject<Type>(new IntPtr(p + 0x020), ReversePrism.DataModels.Type.FromPointer); // 024666D02618 0x20 MarshalTypeRef              ( 000186692F60 ModelClassType Type Type Type Pointer )
            value.SafeArrayUserDefinedSubType               = GetObject<Type>(new IntPtr(p + 0x028), ReversePrism.DataModels.Type.FromPointer); // 024666D02638 0x28 SafeArrayUserDefinedSubType ( 000186692F60 ModelClassType Type Type Type Pointer )
            value.Utype                                     = (UnmanagedType)GetInt32(new IntPtr(p + 0x030)); // 024666D02658 0x30 Utype                       ( 000186734450 ModelEnumType UnmanagedType UnmanagedType UnmanagedType Int32 )
            value.ArraySubType                              = (UnmanagedType)GetInt32(new IntPtr(p + 0x034)); // 024666D02678 0x34 ArraySubType                ( 0001867346C0 ModelEnumType UnmanagedType UnmanagedType UnmanagedType Int32 )
            value.SafeArraySubType                          = (VarEnum)GetInt32(new IntPtr(p + 0x038)); // 024666D02698 0x38 SafeArraySubType            ( 000186771D80 ModelEnumType VarEnum VarEnum VarEnum Int32 )
            value.SizeConst                                 = GetInt32(new IntPtr(p + 0x03C)); // 024666D026B8 0x3C SizeConst                   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.IidParameterIndex                         = GetInt32(new IntPtr(p + 0x040)); // 024666D026D8 0x40 IidParameterIndex           ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.SizeParamIndex                            = GetInt16(new IntPtr(p + 0x044)); // 024666D026F8 0x44 SizeParamIndex              ( 0001865F1520 ModelPrimitiveType short short short Int16 )

            return value;
        }
    }
}
