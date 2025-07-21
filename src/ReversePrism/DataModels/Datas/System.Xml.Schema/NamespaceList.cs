using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     ModelEnumType ListType ListType ListType Int32
    // 018 Set                                      ModelClassType Hashtable Hashtable Hashtable Pointer
    // 020 TargetNamespace                          ModelPrimitiveType string string string String
    public partial class NamespaceList : DataModel
    {
        public ListType                                 Type                                    { get; set; }
        public Hashtable?                               Set                                     { get; set; }
        public string                                   TargetNamespace                         { get; set; }

        public static NamespaceList? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NamespaceList() { Pointer= p0 };

            value.Type                                      = (ListType)GetInt32(new IntPtr(p + 0x010)); // 0x10 Type                        ( ModelEnumType ListType ListType ListType Int32 )
            value.Set                                       = GetObject<Hashtable>(new IntPtr(p + 0x018), ReversePrism.DataModels.Hashtable.FromPointer); // 0x18 Set                         ( ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.TargetNamespace                           = GetString(new IntPtr(p + 0x020)); // 0x20 TargetNamespace             ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
