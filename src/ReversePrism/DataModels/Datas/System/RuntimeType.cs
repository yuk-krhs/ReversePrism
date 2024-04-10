using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ValueType                                RuntimeType IL2CPP_TYPE_CLASS
    // 008 EnumType                                 RuntimeType IL2CPP_TYPE_CLASS
    // 010 ObjectType                               00018669F680 ModelClassType RuntimeType RuntimeType RuntimeType Pointer
    // 018 StringType                               00018669F680 ModelClassType RuntimeType RuntimeType RuntimeType Pointer
    // 020 DelegateType                             00018669F680 ModelClassType RuntimeType RuntimeType RuntimeType Pointer
    // 028 S_SICtorParamTypes                       000185B82F20 ModelClassListType Type[] Type[] List<Type> Pointer
    // 030 MakeTypeBuilderInstantiation             Func`3<Type, Type[], Type> IL2CPP_TYPE_GENERICINST
    // 000 MemberBindingMask                        BindingFlags IL2CPP_TYPE_VALUETYPE
    // 000 InvocationMask                           BindingFlags IL2CPP_TYPE_VALUETYPE
    // 000 BinderNonCreateInstance                  BindingFlags IL2CPP_TYPE_VALUETYPE
    // 000 BinderGetSetProperty                     BindingFlags IL2CPP_TYPE_VALUETYPE
    // 000 BinderSetInvokeProperty                  BindingFlags IL2CPP_TYPE_VALUETYPE
    // 000 BinderGetSetField                        BindingFlags IL2CPP_TYPE_VALUETYPE
    // 000 BinderSetInvokeField                     BindingFlags IL2CPP_TYPE_VALUETYPE
    // 000 BinderNonFieldGetSet                     BindingFlags IL2CPP_TYPE_VALUETYPE
    // 000 ClassicBindingMask                       BindingFlags IL2CPP_TYPE_VALUETYPE
    // 038 S_typedRef                               00018669F470 ModelClassType RuntimeType RuntimeType RuntimeType Pointer
    // 018 Type_info                                00018664E420 ModelClassType MonoTypeInfo MonoTypeInfo MonoTypeInfo Pointer
    // 020 GenericCache                             <object> IL2CPP_TYPE_OBJECT
    // 028 M_serializationCtor                      000186697870 ModelClassType RuntimeConstructorInfo RuntimeConstructorInfo RuntimeConstructorInfo Pointer
    // 000 GenericParameterCountAny                 int IL2CPP_TYPE_I4
    public partial class RuntimeType : DataModel
    {
        public RuntimeType?                             ObjectType                              { get; set; }
        public RuntimeType?                             StringType                              { get; set; }
        public RuntimeType?                             DelegateType                            { get; set; }
        public List<Type>?                              S_SICtorParamTypes                      { get; set; }
        public RuntimeType?                             S_typedRef                              { get; set; }
        public MonoTypeInfo?                            Type_info                               { get; set; }
        public RuntimeConstructorInfo?                  M_serializationCtor                     { get; set; }

        public static RuntimeType? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RuntimeType() { Pointer= p0 };

            value.ObjectType                                = GetObject<RuntimeType>(new IntPtr(p + 0x010), ReversePrism.DataModels.RuntimeType.FromPointer); // 0245A1558180 0x10 ObjectType                  ( 00018669F680 ModelClassType RuntimeType RuntimeType RuntimeType Pointer )
            value.StringType                                = GetObject<RuntimeType>(new IntPtr(p + 0x018), ReversePrism.DataModels.RuntimeType.FromPointer); // 0245A15581A0 0x18 StringType                  ( 00018669F680 ModelClassType RuntimeType RuntimeType RuntimeType Pointer )
            value.DelegateType                              = GetObject<RuntimeType>(new IntPtr(p + 0x020), ReversePrism.DataModels.RuntimeType.FromPointer); // 0245A15581C0 0x20 DelegateType                ( 00018669F680 ModelClassType RuntimeType RuntimeType RuntimeType Pointer )
            value.S_SICtorParamTypes                        = GetObjectList<Type>(new IntPtr(p + 0x028), ReversePrism.DataModels.Type.FromPointer); // 0245A15581E0 0x28 S_SICtorParamTypes          ( 000185B82F20 ModelClassListType Type[] Type[] List<Type> Pointer )
            value.S_typedRef                                = GetObject<RuntimeType>(new IntPtr(p + 0x038), ReversePrism.DataModels.RuntimeType.FromPointer); // 0245A1558340 0x38 S_typedRef                  ( 00018669F470 ModelClassType RuntimeType RuntimeType RuntimeType Pointer )
            value.Type_info                                 = GetObject<MonoTypeInfo>(new IntPtr(p + 0x018), ReversePrism.DataModels.MonoTypeInfo.FromPointer); // 0245A1558360 0x18 Type_info                   ( 00018664E420 ModelClassType MonoTypeInfo MonoTypeInfo MonoTypeInfo Pointer )
            value.M_serializationCtor                       = GetObject<RuntimeConstructorInfo>(new IntPtr(p + 0x028), ReversePrism.DataModels.RuntimeConstructorInfo.FromPointer); // 0245A15583A0 0x28 M_serializationCtor         ( 000186697870 ModelClassType RuntimeConstructorInfo RuntimeConstructorInfo RuntimeConstructorInfo Pointer )

            return value;
        }
    }
}
