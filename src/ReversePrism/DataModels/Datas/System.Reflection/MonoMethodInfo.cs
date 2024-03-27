using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Parent                                   000186692850 ModelClassType Type Type Type Pointer
    // 018 Ret                                      000186692850 ModelClassType Type Type Type Pointer
    // 020 Attrs                                    00018660EBE0 ModelEnumType MethodAttributes MethodAttributes MethodAttributes Int32
    // 024 Iattrs                                   000186611620 ModelEnumType MethodImplAttributes MethodImplAttributes MethodImplAttributes Int32
    // 028 Callconv                                 0001865345B0 ModelEnumType CallingConventions CallingConventions CallingConventions Int32
    public partial class MonoMethodInfo
    {
        public Type?                                    Parent                                  { get; set; }
        public Type?                                    Ret                                     { get; set; }
        public MethodAttributes                         Attrs                                   { get; set; }
        public MethodImplAttributes                     Iattrs                                  { get; set; }
        public CallingConventions                       Callconv                                { get; set; }

        public static MonoMethodInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MonoMethodInfo();

            value.Parent                                    = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 0270D6CEE498 0x10 Parent                      ( 000186692850 ModelClassType Type Type Type Pointer )
            value.Ret                                       = GetObject<Type>(new IntPtr(p + 0x018), ReversePrism.DataModels.Type.FromPointer); // 0270D6CEE4B8 0x18 Ret                         ( 000186692850 ModelClassType Type Type Type Pointer )
            value.Attrs                                     = (MethodAttributes)GetInt32(new IntPtr(p + 0x020)); // 0270D6CEE4D8 0x20 Attrs                       ( 00018660EBE0 ModelEnumType MethodAttributes MethodAttributes MethodAttributes Int32 )
            value.Iattrs                                    = (MethodImplAttributes)GetInt32(new IntPtr(p + 0x024)); // 0270D6CEE4F8 0x24 Iattrs                      ( 000186611620 ModelEnumType MethodImplAttributes MethodImplAttributes MethodImplAttributes Int32 )
            value.Callconv                                  = (CallingConventions)GetInt32(new IntPtr(p + 0x028)); // 0270D6CEE518 0x28 Callconv                    ( 0001865345B0 ModelEnumType CallingConventions CallingConventions CallingConventions Int32 )

            return value;
        }
    }
}
