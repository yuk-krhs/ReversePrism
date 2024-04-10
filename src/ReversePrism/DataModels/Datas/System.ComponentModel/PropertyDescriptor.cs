using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 Converter                                000186695A80 ModelClassType TypeConverter TypeConverter TypeConverter Pointer
    // 068 ValueChangedHandlers                     0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 070 _editors                                 <object>[] IL2CPP_TYPE_SZARRAY
    // 078 EditorTypes                              000185B82C10 ModelClassListType Type[] Type[] List<Type> Pointer
    // 080 EditorCount                              0001865F2AF0 ModelPrimitiveType int int int Int32
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

            value.Converter                                 = GetObject<TypeConverter>(new IntPtr(p + 0x060), ReversePrism.DataModels.TypeConverter.FromPointer); // 024667B7D018 0x60 Converter                   ( 000186695A80 ModelClassType TypeConverter TypeConverter TypeConverter Pointer )
            value.ValueChangedHandlers                      = GetObject<Hashtable>(new IntPtr(p + 0x068), ReversePrism.DataModels.Hashtable.FromPointer); // 024667B7D038 0x68 ValueChangedHandlers        ( 0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.EditorTypes                               = GetObjectList<Type>(new IntPtr(p + 0x078), ReversePrism.DataModels.Type.FromPointer); // 024667B7D078 0x78 EditorTypes                 ( 000185B82C10 ModelClassListType Type[] Type[] List<Type> Pointer )
            value.EditorCount                               = GetInt32(new IntPtr(p + 0x080)); // 024667B7D098 0x80 EditorCount                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
