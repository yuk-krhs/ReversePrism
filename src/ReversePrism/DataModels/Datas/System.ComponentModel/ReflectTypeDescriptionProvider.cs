using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TypeData                                 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 000 _typeConstructor                         Type[] IL2CPP_TYPE_SZARRAY
    // 008 _editorTables                            Hashtable IL2CPP_TYPE_CLASS
    // 010 IntrinsicTypeConverters                  ModelClassType Hashtable Hashtable Hashtable Pointer
    // 018 _intrinsicReferenceKey                   <object> IL2CPP_TYPE_OBJECT
    // 020 _intrinsicNullableKey                    <object> IL2CPP_TYPE_OBJECT
    // 028 _dictionaryKey                           <object> IL2CPP_TYPE_OBJECT
    // 030 PropertyCache                            ModelClassType Hashtable Hashtable Hashtable Pointer
    // 038 EventCache                               ModelClassType Hashtable Hashtable Hashtable Pointer
    // 040 AttributeCache                           ModelClassType Hashtable Hashtable Hashtable Pointer
    // 048 ExtendedPropertyCache                    ModelClassType Hashtable Hashtable Hashtable Pointer
    // 050 ExtenderProviderKey                      ModelEnumType Guid Guid Guid Int32
    // 060 ExtenderPropertiesKey                    ModelEnumType Guid Guid Guid Int32
    // 070 ExtenderProviderPropertiesKey            ModelEnumType Guid Guid Guid Int32
    // 080 SkipInterfaceAttributeList               ModelClassListType Type[] Type[] List<Type> Pointer
    // 088 _internalSyncObject                      <object> IL2CPP_TYPE_OBJECT
    public partial class ReflectTypeDescriptionProvider : DataModel
    {
        public Hashtable?                               TypeData                                { get; set; }
        public Hashtable?                               IntrinsicTypeConverters                 { get; set; }
        public Hashtable?                               PropertyCache                           { get; set; }
        public Hashtable?                               EventCache                              { get; set; }
        public Hashtable?                               AttributeCache                          { get; set; }
        public Hashtable?                               ExtendedPropertyCache                   { get; set; }
        public Guid                                     ExtenderProviderKey                     { get; set; }
        public Guid                                     ExtenderPropertiesKey                   { get; set; }
        public Guid                                     ExtenderProviderPropertiesKey           { get; set; }
        public List<Type>?                              SkipInterfaceAttributeList              { get; set; }

        public static ReflectTypeDescriptionProvider? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReflectTypeDescriptionProvider() { Pointer= p0 };

            value.TypeData                                  = GetObject<Hashtable>(new IntPtr(p + 0x020), ReversePrism.DataModels.Hashtable.FromPointer); // 0x20 TypeData                    ( ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.IntrinsicTypeConverters                   = GetObject<Hashtable>(new IntPtr(p + 0x010), ReversePrism.DataModels.Hashtable.FromPointer); // 0x10 IntrinsicTypeConverters     ( ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.PropertyCache                             = GetObject<Hashtable>(new IntPtr(p + 0x030), ReversePrism.DataModels.Hashtable.FromPointer); // 0x30 PropertyCache               ( ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.EventCache                                = GetObject<Hashtable>(new IntPtr(p + 0x038), ReversePrism.DataModels.Hashtable.FromPointer); // 0x38 EventCache                  ( ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.AttributeCache                            = GetObject<Hashtable>(new IntPtr(p + 0x040), ReversePrism.DataModels.Hashtable.FromPointer); // 0x40 AttributeCache              ( ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.ExtendedPropertyCache                     = GetObject<Hashtable>(new IntPtr(p + 0x048), ReversePrism.DataModels.Hashtable.FromPointer); // 0x48 ExtendedPropertyCache       ( ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.ExtenderProviderKey                       = (Guid)GetInt32(new IntPtr(p + 0x050)); // 0x50 ExtenderProviderKey         ( ModelEnumType Guid Guid Guid Int32 )
            value.ExtenderPropertiesKey                     = (Guid)GetInt32(new IntPtr(p + 0x060)); // 0x60 ExtenderPropertiesKey       ( ModelEnumType Guid Guid Guid Int32 )
            value.ExtenderProviderPropertiesKey             = (Guid)GetInt32(new IntPtr(p + 0x070)); // 0x70 ExtenderProviderPropertiesKey ( ModelEnumType Guid Guid Guid Int32 )
            value.SkipInterfaceAttributeList                = GetObjectList<Type>(new IntPtr(p + 0x080), ReversePrism.DataModels.Type.FromPointer); // 0x80 SkipInterfaceAttributeList  ( ModelClassListType Type[] Type[] List<Type> Pointer )

            return value;
        }
    }
}
