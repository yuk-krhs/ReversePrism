using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_defaultBinder                          Binder IL2CPP_TYPE_CLASS
    // 008 Delimiter                                char IL2CPP_TYPE_CHAR
    // 010 EmptyTypes                               000185B83450 ModelClassListType Type[] Type[] List<Type> Pointer
    // 018 Missing                                  <object> IL2CPP_TYPE_OBJECT
    // 020 FilterAttribute                          0001865F1540 ModelClassType MemberFilter MemberFilter MemberFilter Pointer
    // 028 FilterName                               0001865F1540 ModelClassType MemberFilter MemberFilter MemberFilter Pointer
    // 030 FilterNameIgnoreCase                     0001865F1540 ModelClassType MemberFilter MemberFilter MemberFilter Pointer
    // 000 DefaultLookup                            BindingFlags IL2CPP_TYPE_VALUETYPE
    // 010 Impl                                     0001866A0050 ModelEnumType RuntimeTypeHandle RuntimeTypeHandle RuntimeTypeHandle Int32
    // 000 DefaultTypeNameWhenMissingMetadata       string IL2CPP_TYPE_STRING
    public partial class Type : DataModel
    {
        public List<Type>?                              EmptyTypes                              { get; set; }
        public MemberFilter?                            FilterAttribute                         { get; set; }
        public MemberFilter?                            FilterName                              { get; set; }
        public MemberFilter?                            FilterNameIgnoreCase                    { get; set; }
        public RuntimeTypeHandle                        Impl                                    { get; set; }

        public static Type? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Type() { Pointer= p0 };

            value.EmptyTypes                                = GetObjectList<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 0245A154AA38 0x10 EmptyTypes                  ( 000185B83450 ModelClassListType Type[] Type[] List<Type> Pointer )
            value.FilterAttribute                           = GetObject<MemberFilter>(new IntPtr(p + 0x020), ReversePrism.DataModels.MemberFilter.FromPointer); // 0245A154AA78 0x20 FilterAttribute             ( 0001865F1540 ModelClassType MemberFilter MemberFilter MemberFilter Pointer )
            value.FilterName                                = GetObject<MemberFilter>(new IntPtr(p + 0x028), ReversePrism.DataModels.MemberFilter.FromPointer); // 0245A154AA98 0x28 FilterName                  ( 0001865F1540 ModelClassType MemberFilter MemberFilter MemberFilter Pointer )
            value.FilterNameIgnoreCase                      = GetObject<MemberFilter>(new IntPtr(p + 0x030), ReversePrism.DataModels.MemberFilter.FromPointer); // 0245A154AAB8 0x30 FilterNameIgnoreCase        ( 0001865F1540 ModelClassType MemberFilter MemberFilter MemberFilter Pointer )
            value.Impl                                      = (RuntimeTypeHandle)GetInt32(new IntPtr(p + 0x010)); // 0245A154AAF8 0x10 Impl                        ( 0001866A0050 ModelEnumType RuntimeTypeHandle RuntimeTypeHandle RuntimeTypeHandle Int32 )

            return value;
        }
    }
}
