using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     000186770200 ModelEnumType ListType ListType ListType Int32
    // 018 Set                                      0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 020 TargetNamespace                          000186671910 ModelPrimitiveType string string string String
    public partial class NamespaceList
    {
        public ListType                                 Type                                    { get; set; }
        public Hashtable?                               Set                                     { get; set; }
        public string                                   TargetNamespace                         { get; set; }

        public static NamespaceList? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NamespaceList();

            value.Type                                      = (ListType)GetInt32(new IntPtr(p + 0x010)); // 0270D74FCD28 0x10 Type                        ( 000186770200 ModelEnumType ListType ListType ListType Int32 )
            value.Set                                       = GetObject<Hashtable>(new IntPtr(p + 0x018), ReversePrism.DataModels.Hashtable.FromPointer); // 0270D74FCD48 0x18 Set                         ( 0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.TargetNamespace                           = GetString(new IntPtr(p + 0x020)); // 0270D74FCD68 0x20 TargetNamespace             ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
