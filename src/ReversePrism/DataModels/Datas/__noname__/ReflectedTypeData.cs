using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     ModelClassType Type Type Type Pointer
    // 018 Attributes                               ModelClassType AttributeCollection AttributeCollection AttributeCollection Pointer
    // 020 Events                                   ModelClassType EventDescriptorCollection EventDescriptorCollection EventDescriptorCollection Pointer
    // 028 Properties                               ModelClassType PropertyDescriptorCollection PropertyDescriptorCollection PropertyDescriptorCollection Pointer
    // 030 Converter                                ModelClassType TypeConverter TypeConverter TypeConverter Pointer
    // 038 _editors                                 <object>[] IL2CPP_TYPE_SZARRAY
    // 040 EditorTypes                              ModelClassListType Type[] Type[] List<Type> Pointer
    // 048 EditorCount                              ModelPrimitiveType int int int Int32
    public partial class ReflectedTypeData : DataModel
    {
        public Type?                                    Type                                    { get; set; }
        public AttributeCollection?                     Attributes                              { get; set; }
        public EventDescriptorCollection?               Events                                  { get; set; }
        public PropertyDescriptorCollection?            Properties                              { get; set; }
        public TypeConverter?                           Converter                               { get; set; }
        public List<Type>?                              EditorTypes                             { get; set; }
        public int                                      EditorCount                             { get; set; }

        public static ReflectedTypeData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReflectedTypeData() { Pointer= p0 };

            value.Type                                      = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 0x10 Type                        ( ModelClassType Type Type Type Pointer )
            value.Attributes                                = GetObject<AttributeCollection>(new IntPtr(p + 0x018), ReversePrism.DataModels.AttributeCollection.FromPointer); // 0x18 Attributes                  ( ModelClassType AttributeCollection AttributeCollection AttributeCollection Pointer )
            value.Events                                    = GetObject<EventDescriptorCollection>(new IntPtr(p + 0x020), ReversePrism.DataModels.EventDescriptorCollection.FromPointer); // 0x20 Events                      ( ModelClassType EventDescriptorCollection EventDescriptorCollection EventDescriptorCollection Pointer )
            value.Properties                                = GetObject<PropertyDescriptorCollection>(new IntPtr(p + 0x028), ReversePrism.DataModels.PropertyDescriptorCollection.FromPointer); // 0x28 Properties                  ( ModelClassType PropertyDescriptorCollection PropertyDescriptorCollection PropertyDescriptorCollection Pointer )
            value.Converter                                 = GetObject<TypeConverter>(new IntPtr(p + 0x030), ReversePrism.DataModels.TypeConverter.FromPointer); // 0x30 Converter                   ( ModelClassType TypeConverter TypeConverter TypeConverter Pointer )
            value.EditorTypes                               = GetObjectList<Type>(new IntPtr(p + 0x040), ReversePrism.DataModels.Type.FromPointer); // 0x40 EditorTypes                 ( ModelClassListType Type[] Type[] List<Type> Pointer )
            value.EditorCount                               = GetInt32(new IntPtr(p + 0x048)); // 0x48 EditorCount                 ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
