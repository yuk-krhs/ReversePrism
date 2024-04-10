using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     0001866BCA70 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 018 Role                                     000186511F10 ModelEnumType ConstraintRole ConstraintRole ConstraintRole Int32
    // 020 Selector                                 0001866EA170 ModelClassType Asttree Asttree Asttree Pointer
    // 028 Fields                                   000185B70CF0 ModelClassListType Asttree[] Asttree[] List<Asttree> Pointer
    // 030 Refer                                    0001866BCA70 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 000 Empty                                    CompiledIdentityConstraint IL2CPP_TYPE_CLASS
    public partial class CompiledIdentityConstraint : DataModel
    {
        public XmlQualifiedName?                        Name                                    { get; set; }
        public ConstraintRole                           Role                                    { get; set; }
        public Asttree?                                 Selector                                { get; set; }
        public List<Asttree>?                           Fields                                  { get; set; }
        public XmlQualifiedName?                        Refer                                   { get; set; }

        public static CompiledIdentityConstraint? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CompiledIdentityConstraint() { Pointer= p0 };

            value.Name                                      = GetObject<XmlQualifiedName>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 024667559550 0x10 Name                        ( 0001866BCA70 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.Role                                      = (ConstraintRole)GetInt32(new IntPtr(p + 0x018)); // 024667559570 0x18 Role                        ( 000186511F10 ModelEnumType ConstraintRole ConstraintRole ConstraintRole Int32 )
            value.Selector                                  = GetObject<Asttree>(new IntPtr(p + 0x020), ReversePrism.DataModels.Asttree.FromPointer); // 024667559590 0x20 Selector                    ( 0001866EA170 ModelClassType Asttree Asttree Asttree Pointer )
            value.Fields                                    = GetObjectList<Asttree>(new IntPtr(p + 0x028), ReversePrism.DataModels.Asttree.FromPointer); // 0246675595B0 0x28 Fields                      ( 000185B70CF0 ModelClassListType Asttree[] Asttree[] List<Asttree> Pointer )
            value.Refer                                     = GetObject<XmlQualifiedName>(new IntPtr(p + 0x030), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0246675595D0 0x30 Refer                       ( 0001866BCA70 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )

            return value;
        }
    }
}
