using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IncludedTypes                            ModelClassListType Type[] Type[] List<Type> Pointer
    // 018 Namspace                                 ModelPrimitiveType string string string String
    // 020 CanBeGenerated                           ModelPrimitiveType bool bool bool Bool
    public partial class SerializationSource : DataModel
    {
        public List<Type>?                              IncludedTypes                           { get; set; }
        public string                                   Namspace                                { get; set; }
        public bool                                     CanBeGenerated                          { get; set; }

        public static SerializationSource? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SerializationSource() { Pointer= p0 };

            value.IncludedTypes                             = GetObjectList<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 0x10 IncludedTypes               ( ModelClassListType Type[] Type[] List<Type> Pointer )
            value.Namspace                                  = GetString(new IntPtr(p + 0x018)); // 0x18 Namspace                    ( ModelPrimitiveType string string string String )
            value.CanBeGenerated                            = GetBool(new IntPtr(p + 0x020)); // 0x20 CanBeGenerated              ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
