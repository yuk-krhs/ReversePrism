using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Entries                                  000185D318A8 ModelEnumListType List`1<XmlSchemaObjectEntry> List`1<XmlSchemaObjectEntry> List<XmlSchemaObjectEntry> Pointer
    // 018 EnumType                                 00018673C490 ModelEnumType EnumeratorType EnumeratorType EnumeratorType Int32
    // 01C CurrentIndex                             0001865F3220 ModelPrimitiveType int int int Int32
    // 020 Size                                     0001865F3220 ModelPrimitiveType int int int Int32
    // 028 CurrentKey                               0001866BCCE0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 030 CurrentValue                             0001865BBE60 ModelClassType XmlSchemaObject XmlSchemaObject XmlSchemaObject Pointer
    public partial class XSOEnumerator
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
            var value   = new XSOEnumerator();

            value.Entries                                   = GetEnumList<XmlSchemaObjectEntry>(new IntPtr(p + 0x010)); // 0270D75B6358 0x10 Entries                     ( 000185D318A8 ModelEnumListType List`1<XmlSchemaObjectEntry> List`1<XmlSchemaObjectEntry> List<XmlSchemaObjectEntry> Pointer )
            value.EnumType                                  = (EnumeratorType)GetInt32(new IntPtr(p + 0x018)); // 0270D75B6378 0x18 EnumType                    ( 00018673C490 ModelEnumType EnumeratorType EnumeratorType EnumeratorType Int32 )
            value.CurrentIndex                              = GetInt32(new IntPtr(p + 0x01C)); // 0270D75B6398 0x1C CurrentIndex                ( 0001865F3220 ModelPrimitiveType int int int Int32 )
            value.Size                                      = GetInt32(new IntPtr(p + 0x020)); // 0270D75B63B8 0x20 Size                        ( 0001865F3220 ModelPrimitiveType int int int Int32 )
            value.CurrentKey                                = GetObject<XmlQualifiedName>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0270D75B63D8 0x28 CurrentKey                  ( 0001866BCCE0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.CurrentValue                              = GetObject<XmlSchemaObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.XmlSchemaObject.FromPointer); // 0270D75B63F8 0x30 CurrentValue                ( 0001865BBE60 ModelClassType XmlSchemaObject XmlSchemaObject XmlSchemaObject Pointer )

            return value;
        }
    }
}
