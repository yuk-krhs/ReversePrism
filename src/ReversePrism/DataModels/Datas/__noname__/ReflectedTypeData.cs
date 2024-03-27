using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     000186692850 ModelClassType Type Type Type Pointer
    // 018 Attributes                               000186711E70 ModelClassType AttributeCollection AttributeCollection AttributeCollection Pointer
    // 020 Events                                   000186754980 ModelClassType EventDescriptorCollection EventDescriptorCollection EventDescriptorCollection Pointer
    // 028 Properties                               0001865D3470 ModelClassType PropertyDescriptorCollection PropertyDescriptorCollection PropertyDescriptorCollection Pointer
    // 030 Converter                                000186695A80 ModelClassType TypeConverter TypeConverter TypeConverter Pointer
    // 038 _editors                                 <object>[] IL2CPP_TYPE_SZARRAY
    // 040 EditorTypes                              000185B82C10 ModelClassListType Type[] Type[] List<Type> Pointer
    // 048 EditorCount                              0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class ReflectedTypeData
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
            var value   = new ReflectedTypeData();

            value.Type                                      = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 02700602B260 0x10 Type                        ( 000186692850 ModelClassType Type Type Type Pointer )
            value.Attributes                                = GetObject<AttributeCollection>(new IntPtr(p + 0x018), ReversePrism.DataModels.AttributeCollection.FromPointer); // 02700602B280 0x18 Attributes                  ( 000186711E70 ModelClassType AttributeCollection AttributeCollection AttributeCollection Pointer )
            value.Events                                    = GetObject<EventDescriptorCollection>(new IntPtr(p + 0x020), ReversePrism.DataModels.EventDescriptorCollection.FromPointer); // 02700602B2A0 0x20 Events                      ( 000186754980 ModelClassType EventDescriptorCollection EventDescriptorCollection EventDescriptorCollection Pointer )
            value.Properties                                = GetObject<PropertyDescriptorCollection>(new IntPtr(p + 0x028), ReversePrism.DataModels.PropertyDescriptorCollection.FromPointer); // 02700602B2C0 0x28 Properties                  ( 0001865D3470 ModelClassType PropertyDescriptorCollection PropertyDescriptorCollection PropertyDescriptorCollection Pointer )
            value.Converter                                 = GetObject<TypeConverter>(new IntPtr(p + 0x030), ReversePrism.DataModels.TypeConverter.FromPointer); // 02700602B2E0 0x30 Converter                   ( 000186695A80 ModelClassType TypeConverter TypeConverter TypeConverter Pointer )
            value.EditorTypes                               = GetObjectList<Type>(new IntPtr(p + 0x040), ReversePrism.DataModels.Type.FromPointer); // 02700602B320 0x40 EditorTypes                 ( 000185B82C10 ModelClassListType Type[] Type[] List<Type> Pointer )
            value.EditorCount                               = GetInt32(new IntPtr(p + 0x048)); // 02700602B340 0x48 EditorCount                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
