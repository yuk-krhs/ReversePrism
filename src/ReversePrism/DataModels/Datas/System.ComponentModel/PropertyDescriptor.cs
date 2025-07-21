using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 Converter                                ModelClassType TypeConverter TypeConverter TypeConverter Pointer
    // 068 ValueChangedHandlers                     ModelClassType Hashtable Hashtable Hashtable Pointer
    // 070 _editors                                 <object>[] IL2CPP_TYPE_SZARRAY
    // 078 EditorTypes                              ModelClassListType Type[] Type[] List<Type> Pointer
    // 080 EditorCount                              ModelPrimitiveType int int int Int32
    public partial class PropertyDescriptor : DataModel
    {
        public TypeConverter?                           Converter                               { get; set; }
        public Hashtable?                               ValueChangedHandlers                    { get; set; }
        public List<Type>?                              EditorTypes                             { get; set; }
        public int                                      EditorCount                             { get; set; }

        public static PropertyDescriptor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PropertyDescriptor() { Pointer= p0 };

            value.Converter                                 = GetObject<TypeConverter>(new IntPtr(p + 0x060), ReversePrism.DataModels.TypeConverter.FromPointer); // 0x60 Converter                   ( ModelClassType TypeConverter TypeConverter TypeConverter Pointer )
            value.ValueChangedHandlers                      = GetObject<Hashtable>(new IntPtr(p + 0x068), ReversePrism.DataModels.Hashtable.FromPointer); // 0x68 ValueChangedHandlers        ( ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.EditorTypes                               = GetObjectList<Type>(new IntPtr(p + 0x078), ReversePrism.DataModels.Type.FromPointer); // 0x78 EditorTypes                 ( ModelClassListType Type[] Type[] List<Type> Pointer )
            value.EditorCount                               = GetInt32(new IntPtr(p + 0x080)); // 0x80 EditorCount                 ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
