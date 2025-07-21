using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MarshalCookie                            ModelPrimitiveType string string string String
    // 018 MarshalType                              ModelPrimitiveType string string string String
    // 020 MarshalTypeRef                           ModelClassType Type Type Type Pointer
    // 028 SafeArrayUserDefinedSubType              ModelClassType Type Type Type Pointer
    // 030 Utype                                    ModelEnumType UnmanagedType UnmanagedType UnmanagedType Int32
    // 034 ArraySubType                             ModelEnumType UnmanagedType UnmanagedType UnmanagedType Int32
    // 038 SafeArraySubType                         ModelEnumType VarEnum VarEnum VarEnum Int32
    // 03C SizeConst                                ModelPrimitiveType int int int Int32
    // 040 IidParameterIndex                        ModelPrimitiveType int int int Int32
    // 044 SizeParamIndex                           ModelPrimitiveType short short short Int16
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

            value.MarshalCookie                             = GetString(new IntPtr(p + 0x010)); // 0x10 MarshalCookie               ( ModelPrimitiveType string string string String )
            value.MarshalType                               = GetString(new IntPtr(p + 0x018)); // 0x18 MarshalType                 ( ModelPrimitiveType string string string String )
            value.MarshalTypeRef                            = GetObject<Type>(new IntPtr(p + 0x020), ReversePrism.DataModels.Type.FromPointer); // 0x20 MarshalTypeRef              ( ModelClassType Type Type Type Pointer )
            value.SafeArrayUserDefinedSubType               = GetObject<Type>(new IntPtr(p + 0x028), ReversePrism.DataModels.Type.FromPointer); // 0x28 SafeArrayUserDefinedSubType ( ModelClassType Type Type Type Pointer )
            value.Utype                                     = (UnmanagedType)GetInt32(new IntPtr(p + 0x030)); // 0x30 Utype                       ( ModelEnumType UnmanagedType UnmanagedType UnmanagedType Int32 )
            value.ArraySubType                              = (UnmanagedType)GetInt32(new IntPtr(p + 0x034)); // 0x34 ArraySubType                ( ModelEnumType UnmanagedType UnmanagedType UnmanagedType Int32 )
            value.SafeArraySubType                          = (VarEnum)GetInt32(new IntPtr(p + 0x038)); // 0x38 SafeArraySubType            ( ModelEnumType VarEnum VarEnum VarEnum Int32 )
            value.SizeConst                                 = GetInt32(new IntPtr(p + 0x03C)); // 0x3C SizeConst                   ( ModelPrimitiveType int int int Int32 )
            value.IidParameterIndex                         = GetInt32(new IntPtr(p + 0x040)); // 0x40 IidParameterIndex           ( ModelPrimitiveType int int int Int32 )
            value.SizeParamIndex                            = GetInt16(new IntPtr(p + 0x044)); // 0x44 SizeParamIndex              ( ModelPrimitiveType short short short Int16 )

            return value;
        }
    }
}
