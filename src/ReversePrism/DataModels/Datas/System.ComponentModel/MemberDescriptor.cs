using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     ModelPrimitiveType string string string String
    // 018 DisplayName                              ModelPrimitiveType string string string String
    // 020 NameHash                                 ModelPrimitiveType int int int Int32
    // 028 AttributeCollection                      ModelClassType AttributeCollection AttributeCollection AttributeCollection Pointer
    // 030 Attributes                               ModelClassListType Attribute[] Attribute[] List<Attribute> Pointer
    // 038 OriginalAttributes                       ModelClassListType Attribute[] Attribute[] List<Attribute> Pointer
    // 040 AttributesFiltered                       ModelPrimitiveType bool bool bool Bool
    // 041 AttributesFilled                         ModelPrimitiveType bool bool bool Bool
    // 044 MetadataVersion                          ModelPrimitiveType int int int Int32
    // 048 Category                                 ModelPrimitiveType string string string String
    // 050 Description                              ModelPrimitiveType string string string String
    // 058 lockCookie                               <object> IL2CPP_TYPE_OBJECT
    public partial class MemberDescriptor : DataModel
    {
        public string                                   Name                                    { get; set; }
        public string                                   DisplayName                             { get; set; }
        public int                                      NameHash                                { get; set; }
        public AttributeCollection?                     AttributeCollection                     { get; set; }
        public List<Attribute>?                         Attributes                              { get; set; }
        public List<Attribute>?                         OriginalAttributes                      { get; set; }
        public bool                                     AttributesFiltered                      { get; set; }
        public bool                                     AttributesFilled                        { get; set; }
        public int                                      MetadataVersion                         { get; set; }
        public string                                   Category                                { get; set; }
        public string                                   Description                             { get; set; }

        public static MemberDescriptor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MemberDescriptor() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Name                        ( ModelPrimitiveType string string string String )
            value.DisplayName                               = GetString(new IntPtr(p + 0x018)); // 0x18 DisplayName                 ( ModelPrimitiveType string string string String )
            value.NameHash                                  = GetInt32(new IntPtr(p + 0x020)); // 0x20 NameHash                    ( ModelPrimitiveType int int int Int32 )
            value.AttributeCollection                       = GetObject<AttributeCollection>(new IntPtr(p + 0x028), ReversePrism.DataModels.AttributeCollection.FromPointer); // 0x28 AttributeCollection         ( ModelClassType AttributeCollection AttributeCollection AttributeCollection Pointer )
            value.Attributes                                = GetObjectList<Attribute>(new IntPtr(p + 0x030), ReversePrism.DataModels.Attribute.FromPointer); // 0x30 Attributes                  ( ModelClassListType Attribute[] Attribute[] List<Attribute> Pointer )
            value.OriginalAttributes                        = GetObjectList<Attribute>(new IntPtr(p + 0x038), ReversePrism.DataModels.Attribute.FromPointer); // 0x38 OriginalAttributes          ( ModelClassListType Attribute[] Attribute[] List<Attribute> Pointer )
            value.AttributesFiltered                        = GetBool(new IntPtr(p + 0x040)); // 0x40 AttributesFiltered          ( ModelPrimitiveType bool bool bool Bool )
            value.AttributesFilled                          = GetBool(new IntPtr(p + 0x041)); // 0x41 AttributesFilled            ( ModelPrimitiveType bool bool bool Bool )
            value.MetadataVersion                           = GetInt32(new IntPtr(p + 0x044)); // 0x44 MetadataVersion             ( ModelPrimitiveType int int int Int32 )
            value.Category                                  = GetString(new IntPtr(p + 0x048)); // 0x48 Category                    ( ModelPrimitiveType string string string String )
            value.Description                               = GetString(new IntPtr(p + 0x050)); // 0x50 Description                 ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
