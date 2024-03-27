using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     000186671910 ModelPrimitiveType string string string String
    // 018 DisplayName                              000186671910 ModelPrimitiveType string string string String
    // 020 NameHash                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 AttributeCollection                      000186711E70 ModelClassType AttributeCollection AttributeCollection AttributeCollection Pointer
    // 030 Attributes                               000185B70E90 ModelClassListType Attribute[] Attribute[] List<Attribute> Pointer
    // 038 OriginalAttributes                       000185B70E90 ModelClassListType Attribute[] Attribute[] List<Attribute> Pointer
    // 040 AttributesFiltered                       000186594D10 ModelPrimitiveType bool bool bool Bool
    // 041 AttributesFilled                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 044 MetadataVersion                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 048 Category                                 000186671910 ModelPrimitiveType string string string String
    // 050 Description                              000186671910 ModelPrimitiveType string string string String
    // 058 lockCookie                               <object> IL2CPP_TYPE_OBJECT
    public partial class MemberDescriptor
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
            var value   = new MemberDescriptor();

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0270D7B14E98 0x10 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.DisplayName                               = GetString(new IntPtr(p + 0x018)); // 0270D7B14EB8 0x18 DisplayName                 ( 000186671910 ModelPrimitiveType string string string String )
            value.NameHash                                  = GetInt32(new IntPtr(p + 0x020)); // 0270D7B14ED8 0x20 NameHash                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.AttributeCollection                       = GetObject<AttributeCollection>(new IntPtr(p + 0x028), ReversePrism.DataModels.AttributeCollection.FromPointer); // 0270D7B14EF8 0x28 AttributeCollection         ( 000186711E70 ModelClassType AttributeCollection AttributeCollection AttributeCollection Pointer )
            value.Attributes                                = GetObjectList<Attribute>(new IntPtr(p + 0x030), ReversePrism.DataModels.Attribute.FromPointer); // 0270D7B14F18 0x30 Attributes                  ( 000185B70E90 ModelClassListType Attribute[] Attribute[] List<Attribute> Pointer )
            value.OriginalAttributes                        = GetObjectList<Attribute>(new IntPtr(p + 0x038), ReversePrism.DataModels.Attribute.FromPointer); // 0270D7B14F38 0x38 OriginalAttributes          ( 000185B70E90 ModelClassListType Attribute[] Attribute[] List<Attribute> Pointer )
            value.AttributesFiltered                        = GetBool(new IntPtr(p + 0x040)); // 0270D7B14F58 0x40 AttributesFiltered          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.AttributesFilled                          = GetBool(new IntPtr(p + 0x041)); // 0270D7B14F78 0x41 AttributesFilled            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.MetadataVersion                           = GetInt32(new IntPtr(p + 0x044)); // 0270D7B14F98 0x44 MetadataVersion             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Category                                  = GetString(new IntPtr(p + 0x048)); // 0270D7B14FB8 0x48 Category                    ( 000186671910 ModelPrimitiveType string string string String )
            value.Description                               = GetString(new IntPtr(p + 0x050)); // 0270D7B14FD8 0x50 Description                 ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
