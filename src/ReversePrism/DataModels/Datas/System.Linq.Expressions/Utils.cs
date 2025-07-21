using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 BoxedFalse                               <object> IL2CPP_TYPE_OBJECT
    // 008 BoxedTrue                                <object> IL2CPP_TYPE_OBJECT
    // 010 BoxedIntM1                               <object> IL2CPP_TYPE_OBJECT
    // 018 BoxedInt0                                <object> IL2CPP_TYPE_OBJECT
    // 020 BoxedInt1                                <object> IL2CPP_TYPE_OBJECT
    // 028 BoxedInt2                                <object> IL2CPP_TYPE_OBJECT
    // 030 BoxedInt3                                <object> IL2CPP_TYPE_OBJECT
    // 038 BoxedDefaultSByte                        <object> IL2CPP_TYPE_OBJECT
    // 040 BoxedDefaultChar                         <object> IL2CPP_TYPE_OBJECT
    // 048 BoxedDefaultInt16                        <object> IL2CPP_TYPE_OBJECT
    // 050 BoxedDefaultInt64                        <object> IL2CPP_TYPE_OBJECT
    // 058 BoxedDefaultByte                         <object> IL2CPP_TYPE_OBJECT
    // 060 BoxedDefaultUInt16                       <object> IL2CPP_TYPE_OBJECT
    // 068 BoxedDefaultUInt32                       <object> IL2CPP_TYPE_OBJECT
    // 070 BoxedDefaultUInt64                       <object> IL2CPP_TYPE_OBJECT
    // 078 BoxedDefaultSingle                       <object> IL2CPP_TYPE_OBJECT
    // 080 BoxedDefaultDouble                       <object> IL2CPP_TYPE_OBJECT
    // 088 BoxedDefaultDecimal                      <object> IL2CPP_TYPE_OBJECT
    // 090 BoxedDefaultDateTime                     <object> IL2CPP_TYPE_OBJECT
    // 098 S_true                                   ModelClassType ConstantExpression ConstantExpression ConstantExpression Pointer
    // 0A0 S_false                                  ModelClassType ConstantExpression ConstantExpression ConstantExpression Pointer
    // 0A8 S_m1                                     ModelClassType ConstantExpression ConstantExpression ConstantExpression Pointer
    // 0B0 S_0                                      ModelClassType ConstantExpression ConstantExpression ConstantExpression Pointer
    // 0B8 S_1                                      ModelClassType ConstantExpression ConstantExpression ConstantExpression Pointer
    // 0C0 S_2                                      ModelClassType ConstantExpression ConstantExpression ConstantExpression Pointer
    // 0C8 S_3                                      ModelClassType ConstantExpression ConstantExpression ConstantExpression Pointer
    // 0D0 Empty                                    ModelClassType DefaultExpression DefaultExpression DefaultExpression Pointer
    // 0D8 Null                                     ModelClassType ConstantExpression ConstantExpression ConstantExpression Pointer
    public partial class Utils : DataModel
    {
        public ConstantExpression?                      S_true                                  { get; set; }
        public ConstantExpression?                      S_false                                 { get; set; }
        public ConstantExpression?                      S_m1                                    { get; set; }
        public ConstantExpression?                      S_0                                     { get; set; }
        public ConstantExpression?                      S_1                                     { get; set; }
        public ConstantExpression?                      S_2                                     { get; set; }
        public ConstantExpression?                      S_3                                     { get; set; }
        public DefaultExpression?                       Empty                                   { get; set; }
        public ConstantExpression?                      Null                                    { get; set; }

        public static Utils? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Utils() { Pointer= p0 };

            value.S_true                                    = GetObject<ConstantExpression>(new IntPtr(p + 0x098), ReversePrism.DataModels.ConstantExpression.FromPointer); // 0x98 S_true                      ( ModelClassType ConstantExpression ConstantExpression ConstantExpression Pointer )
            value.S_false                                   = GetObject<ConstantExpression>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.ConstantExpression.FromPointer); // 0xA0 S_false                     ( ModelClassType ConstantExpression ConstantExpression ConstantExpression Pointer )
            value.S_m1                                      = GetObject<ConstantExpression>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.ConstantExpression.FromPointer); // 0xA8 S_m1                        ( ModelClassType ConstantExpression ConstantExpression ConstantExpression Pointer )
            value.S_0                                       = GetObject<ConstantExpression>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.ConstantExpression.FromPointer); // 0xB0 S_0                         ( ModelClassType ConstantExpression ConstantExpression ConstantExpression Pointer )
            value.S_1                                       = GetObject<ConstantExpression>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.ConstantExpression.FromPointer); // 0xB8 S_1                         ( ModelClassType ConstantExpression ConstantExpression ConstantExpression Pointer )
            value.S_2                                       = GetObject<ConstantExpression>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.ConstantExpression.FromPointer); // 0xC0 S_2                         ( ModelClassType ConstantExpression ConstantExpression ConstantExpression Pointer )
            value.S_3                                       = GetObject<ConstantExpression>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.ConstantExpression.FromPointer); // 0xC8 S_3                         ( ModelClassType ConstantExpression ConstantExpression ConstantExpression Pointer )
            value.Empty                                     = GetObject<DefaultExpression>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.DefaultExpression.FromPointer); // 0xD0 Empty                       ( ModelClassType DefaultExpression DefaultExpression DefaultExpression Pointer )
            value.Null                                      = GetObject<ConstantExpression>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.ConstantExpression.FromPointer); // 0xD8 Null                        ( ModelClassType ConstantExpression ConstantExpression ConstantExpression Pointer )

            return value;
        }
    }
}
