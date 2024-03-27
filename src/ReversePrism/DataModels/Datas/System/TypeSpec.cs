using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     0001866D74F0 ModelClassType TypeIdentifier TypeIdentifier TypeIdentifier Pointer
    // 018 Assembly_name                            000186671910 ModelPrimitiveType string string string String
    // 020 Nested                                   000185D17128 ModelClassListType List`1<TypeIdentifier> List`1<TypeIdentifier> List<TypeIdentifier> Pointer
    // 028 Generic_params                           000185D17338 ModelClassListType List`1<TypeSpec> List`1<TypeSpec> List<TypeSpec> Pointer
    // 030 Modifier_spec                            000185CF4308 ModelClassListType List`1<ModifierSpec> List`1<ModifierSpec> List<ModifierSpec> Pointer
    // 038 Is_byref                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 040 Display_fullname                         000186671910 ModelPrimitiveType string string string String
    public partial class TypeSpec
    {
        public TypeIdentifier?                          Name                                    { get; set; }
        public string                                   Assembly_name                           { get; set; }
        public List<TypeIdentifier>?                    Nested                                  { get; set; }
        public List<TypeSpec>?                          Generic_params                          { get; set; }
        public List<ModifierSpec>?                      Modifier_spec                           { get; set; }
        public bool                                     Is_byref                                { get; set; }
        public string                                   Display_fullname                        { get; set; }

        public static TypeSpec? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TypeSpec();

            value.Name                                      = GetObject<TypeIdentifier>(new IntPtr(p + 0x010), ReversePrism.DataModels.TypeIdentifier.FromPointer); // 0270D6AA1E60 0x10 Name                        ( 0001866D74F0 ModelClassType TypeIdentifier TypeIdentifier TypeIdentifier Pointer )
            value.Assembly_name                             = GetString(new IntPtr(p + 0x018)); // 0270D6AA1E80 0x18 Assembly_name               ( 000186671910 ModelPrimitiveType string string string String )
            value.Nested                                    = GetObjectList<TypeIdentifier>(new IntPtr(p + 0x020), ReversePrism.DataModels.TypeIdentifier.FromPointer); // 0270D6AA1EA0 0x20 Nested                      ( 000185D17128 ModelClassListType List`1<TypeIdentifier> List`1<TypeIdentifier> List<TypeIdentifier> Pointer )
            value.Generic_params                            = GetObjectList<TypeSpec>(new IntPtr(p + 0x028), ReversePrism.DataModels.TypeSpec.FromPointer); // 0270D6AA1EC0 0x28 Generic_params              ( 000185D17338 ModelClassListType List`1<TypeSpec> List`1<TypeSpec> List<TypeSpec> Pointer )
            value.Modifier_spec                             = GetObjectList<ModifierSpec>(new IntPtr(p + 0x030), ReversePrism.DataModels.ModifierSpec.FromPointer); // 0270D6AA1EE0 0x30 Modifier_spec               ( 000185CF4308 ModelClassListType List`1<ModifierSpec> List`1<ModifierSpec> List<ModifierSpec> Pointer )
            value.Is_byref                                  = GetBool(new IntPtr(p + 0x038)); // 0270D6AA1F00 0x38 Is_byref                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Display_fullname                          = GetString(new IntPtr(p + 0x040)); // 0270D6AA1F20 0x40 Display_fullname            ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
