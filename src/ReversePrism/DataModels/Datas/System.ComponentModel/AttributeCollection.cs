using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Empty                                    AttributeCollection IL2CPP_TYPE_CLASS
    // 008 s_defaultAttributes                      Hashtable IL2CPP_TYPE_CLASS
    // 010 Attributes                               000185B70FB0 ModelClassListType Attribute[] Attribute[] List<Attribute> Pointer
    // 010 s_internalSyncObject                     <object> IL2CPP_TYPE_OBJECT
    // 018 FoundAttributeTypes                      000185CB68A8 ModelEnumListType AttributeEntry[] AttributeEntry[] List<AttributeEntry> Pointer
    // 020 Index                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class AttributeCollection
    {
        public List<Attribute>?                         Attributes                              { get; set; }
        public List<AttributeEntry>?                    FoundAttributeTypes                     { get; set; }
        public int                                      Index                                   { get; set; }

        public static AttributeCollection? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AttributeCollection();

            value.Attributes                                = GetObjectList<Attribute>(new IntPtr(p + 0x010), ReversePrism.DataModels.Attribute.FromPointer); // 02700602CD98 0x10 Attributes                  ( 000185B70FB0 ModelClassListType Attribute[] Attribute[] List<Attribute> Pointer )
            value.FoundAttributeTypes                       = GetEnumList<AttributeEntry>(new IntPtr(p + 0x018)); // 02700602CDD8 0x18 FoundAttributeTypes         ( 000185CB68A8 ModelEnumListType AttributeEntry[] AttributeEntry[] List<AttributeEntry> Pointer )
            value.Index                                     = GetInt32(new IntPtr(p + 0x020)); // 02700602CDF8 0x20 Index                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
