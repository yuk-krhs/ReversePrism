using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Elements                                 0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 018 ElementMembers                           00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer
    // 020 AttributeMembers                         0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 028 AttributeMembersArray                    000185CB4E68 ModelClassListType XmlTypeMapMemberAttribute[] XmlTypeMapMemberAttribute[] List<XmlTypeMapMemberAttribute> Pointer
    // 030 FlatLists                                00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer
    // 038 AllMembers                               00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer
    // 040 MembersWithDefault                       00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer
    // 048 ListMembers                              00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer
    // 050 DefaultAnyElement                        0001865D0980 ModelClassType XmlTypeMapMemberAnyElement XmlTypeMapMemberAnyElement XmlTypeMapMemberAnyElement Pointer
    // 058 DefaultAnyAttribute                      0001865D04E0 ModelClassType XmlTypeMapMemberAnyAttribute XmlTypeMapMemberAnyAttribute XmlTypeMapMemberAnyAttribute Pointer
    // 060 NamespaceDeclarations                    0001865D18C0 ModelClassType XmlTypeMapMemberNamespaces XmlTypeMapMemberNamespaces XmlTypeMapMemberNamespaces Pointer
    // 068 XmlTextCollector                         0001865D0040 ModelClassType XmlTypeMapMember XmlTypeMapMember XmlTypeMapMember Pointer
    // 070 ReturnMember                             0001865D0040 ModelClassType XmlTypeMapMember XmlTypeMapMember XmlTypeMapMember Pointer
    // 078 IgnoreMemberNamespace                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 079 CanBeSimpleType                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 07A _isOrderDependentMap                     Nullable`1<bool> IL2CPP_TYPE_GENERICINST
    public partial class ClassMap
    {
        public Hashtable?                               Elements                                { get; set; }
        public ArrayList?                               ElementMembers                          { get; set; }
        public Hashtable?                               AttributeMembers                        { get; set; }
        public List<XmlTypeMapMemberAttribute>?         AttributeMembersArray                   { get; set; }
        public ArrayList?                               FlatLists                               { get; set; }
        public ArrayList?                               AllMembers                              { get; set; }
        public ArrayList?                               MembersWithDefault                      { get; set; }
        public ArrayList?                               ListMembers                             { get; set; }
        public XmlTypeMapMemberAnyElement?              DefaultAnyElement                       { get; set; }
        public XmlTypeMapMemberAnyAttribute?            DefaultAnyAttribute                     { get; set; }
        public XmlTypeMapMemberNamespaces?              NamespaceDeclarations                   { get; set; }
        public XmlTypeMapMember?                        XmlTextCollector                        { get; set; }
        public XmlTypeMapMember?                        ReturnMember                            { get; set; }
        public bool                                     IgnoreMemberNamespace                   { get; set; }
        public bool                                     CanBeSimpleType                         { get; set; }

        public static ClassMap? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ClassMap();

            value.Elements                                  = GetObject<Hashtable>(new IntPtr(p + 0x010), ReversePrism.DataModels.Hashtable.FromPointer); // 0270D74CD200 0x10 Elements                    ( 0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.ElementMembers                            = GetObject<ArrayList>(new IntPtr(p + 0x018), ReversePrism.DataModels.ArrayList.FromPointer); // 0270D74CD220 0x18 ElementMembers              ( 00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.AttributeMembers                          = GetObject<Hashtable>(new IntPtr(p + 0x020), ReversePrism.DataModels.Hashtable.FromPointer); // 0270D74CD240 0x20 AttributeMembers            ( 0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.AttributeMembersArray                     = GetObjectList<XmlTypeMapMemberAttribute>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlTypeMapMemberAttribute.FromPointer); // 0270D74CD260 0x28 AttributeMembersArray       ( 000185CB4E68 ModelClassListType XmlTypeMapMemberAttribute[] XmlTypeMapMemberAttribute[] List<XmlTypeMapMemberAttribute> Pointer )
            value.FlatLists                                 = GetObject<ArrayList>(new IntPtr(p + 0x030), ReversePrism.DataModels.ArrayList.FromPointer); // 0270D74CD280 0x30 FlatLists                   ( 00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.AllMembers                                = GetObject<ArrayList>(new IntPtr(p + 0x038), ReversePrism.DataModels.ArrayList.FromPointer); // 0270D74CD2A0 0x38 AllMembers                  ( 00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.MembersWithDefault                        = GetObject<ArrayList>(new IntPtr(p + 0x040), ReversePrism.DataModels.ArrayList.FromPointer); // 0270D74CD2C0 0x40 MembersWithDefault          ( 00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.ListMembers                               = GetObject<ArrayList>(new IntPtr(p + 0x048), ReversePrism.DataModels.ArrayList.FromPointer); // 0270D74CD2E0 0x48 ListMembers                 ( 00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.DefaultAnyElement                         = GetObject<XmlTypeMapMemberAnyElement>(new IntPtr(p + 0x050), ReversePrism.DataModels.XmlTypeMapMemberAnyElement.FromPointer); // 0270D74CD300 0x50 DefaultAnyElement           ( 0001865D0980 ModelClassType XmlTypeMapMemberAnyElement XmlTypeMapMemberAnyElement XmlTypeMapMemberAnyElement Pointer )
            value.DefaultAnyAttribute                       = GetObject<XmlTypeMapMemberAnyAttribute>(new IntPtr(p + 0x058), ReversePrism.DataModels.XmlTypeMapMemberAnyAttribute.FromPointer); // 0270D74CD320 0x58 DefaultAnyAttribute         ( 0001865D04E0 ModelClassType XmlTypeMapMemberAnyAttribute XmlTypeMapMemberAnyAttribute XmlTypeMapMemberAnyAttribute Pointer )
            value.NamespaceDeclarations                     = GetObject<XmlTypeMapMemberNamespaces>(new IntPtr(p + 0x060), ReversePrism.DataModels.XmlTypeMapMemberNamespaces.FromPointer); // 0270D74CD340 0x60 NamespaceDeclarations       ( 0001865D18C0 ModelClassType XmlTypeMapMemberNamespaces XmlTypeMapMemberNamespaces XmlTypeMapMemberNamespaces Pointer )
            value.XmlTextCollector                          = GetObject<XmlTypeMapMember>(new IntPtr(p + 0x068), ReversePrism.DataModels.XmlTypeMapMember.FromPointer); // 0270D74CD360 0x68 XmlTextCollector            ( 0001865D0040 ModelClassType XmlTypeMapMember XmlTypeMapMember XmlTypeMapMember Pointer )
            value.ReturnMember                              = GetObject<XmlTypeMapMember>(new IntPtr(p + 0x070), ReversePrism.DataModels.XmlTypeMapMember.FromPointer); // 0270D74CD380 0x70 ReturnMember                ( 0001865D0040 ModelClassType XmlTypeMapMember XmlTypeMapMember XmlTypeMapMember Pointer )
            value.IgnoreMemberNamespace                     = GetBool(new IntPtr(p + 0x078)); // 0270D74CD3A0 0x78 IgnoreMemberNamespace       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CanBeSimpleType                           = GetBool(new IntPtr(p + 0x079)); // 0270D74CD3C0 0x79 CanBeSimpleType             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
