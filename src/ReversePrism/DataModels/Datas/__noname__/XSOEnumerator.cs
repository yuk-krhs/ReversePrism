using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Entries                                  ModelEnumListType List`1<XmlSchemaObjectEntry> List`1<XmlSchemaObjectEntry> List<XmlSchemaObjectEntry> Pointer
    // 018 EnumType                                 ModelEnumType EnumeratorType EnumeratorType EnumeratorType Int32
    // 01C CurrentIndex                             ModelPrimitiveType int int int Int32
    // 020 Size                                     ModelPrimitiveType int int int Int32
    // 028 CurrentKey                               ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 030 CurrentValue                             ModelClassType XmlSchemaObject XmlSchemaObject XmlSchemaObject Pointer
    public partial class XSOEnumerator : DataModel
    {
        public List<XmlSchemaObjectEntry>?              Entries                                 { get; set; }
        public EnumeratorType                           EnumType                                { get; set; }
        public int                                      CurrentIndex                            { get; set; }
        public int                                      Size                                    { get; set; }
        public XmlQualifiedName?                        CurrentKey                              { get; set; }
        public XmlSchemaObject?                         CurrentValue                            { get; set; }

        public static XSOEnumerator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XSOEnumerator() { Pointer= p0 };

            value.Entries                                   = GetEnumList<XmlSchemaObjectEntry>(new IntPtr(p + 0x010)); // 0x10 Entries                     ( ModelEnumListType List`1<XmlSchemaObjectEntry> List`1<XmlSchemaObjectEntry> List<XmlSchemaObjectEntry> Pointer )
            value.EnumType                                  = (EnumeratorType)GetInt32(new IntPtr(p + 0x018)); // 0x18 EnumType                    ( ModelEnumType EnumeratorType EnumeratorType EnumeratorType Int32 )
            value.CurrentIndex                              = GetInt32(new IntPtr(p + 0x01C)); // 0x1C CurrentIndex                ( ModelPrimitiveType int int int Int32 )
            value.Size                                      = GetInt32(new IntPtr(p + 0x020)); // 0x20 Size                        ( ModelPrimitiveType int int int Int32 )
            value.CurrentKey                                = GetObject<XmlQualifiedName>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x28 CurrentKey                  ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.CurrentValue                              = GetObject<XmlSchemaObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.XmlSchemaObject.FromPointer); // 0x30 CurrentValue                ( ModelClassType XmlSchemaObject XmlSchemaObject XmlSchemaObject Pointer )

            return value;
        }
    }
}
