using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     ModelClassType TypeIdentifier TypeIdentifier TypeIdentifier Pointer
    // 018 Assembly_name                            ModelPrimitiveType string string string String
    // 020 Nested                                   ModelClassListType List`1<TypeIdentifier> List`1<TypeIdentifier> List<TypeIdentifier> Pointer
    // 028 Generic_params                           ModelClassListType List`1<TypeSpec> List`1<TypeSpec> List<TypeSpec> Pointer
    // 030 Modifier_spec                            ModelClassListType List`1<ModifierSpec> List`1<ModifierSpec> List<ModifierSpec> Pointer
    // 038 Is_byref                                 ModelPrimitiveType bool bool bool Bool
    // 040 Display_fullname                         ModelPrimitiveType string string string String
    public partial class TypeSpec : DataModel
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
            var value   = new TypeSpec() { Pointer= p0 };

            value.Name                                      = GetObject<TypeIdentifier>(new IntPtr(p + 0x010), ReversePrism.DataModels.TypeIdentifier.FromPointer); // 0x10 Name                        ( ModelClassType TypeIdentifier TypeIdentifier TypeIdentifier Pointer )
            value.Assembly_name                             = GetString(new IntPtr(p + 0x018)); // 0x18 Assembly_name               ( ModelPrimitiveType string string string String )
            value.Nested                                    = GetObjectList<TypeIdentifier>(new IntPtr(p + 0x020), ReversePrism.DataModels.TypeIdentifier.FromPointer); // 0x20 Nested                      ( ModelClassListType List`1<TypeIdentifier> List`1<TypeIdentifier> List<TypeIdentifier> Pointer )
            value.Generic_params                            = GetObjectList<TypeSpec>(new IntPtr(p + 0x028), ReversePrism.DataModels.TypeSpec.FromPointer); // 0x28 Generic_params              ( ModelClassListType List`1<TypeSpec> List`1<TypeSpec> List<TypeSpec> Pointer )
            value.Modifier_spec                             = GetObjectList<ModifierSpec>(new IntPtr(p + 0x030), ReversePrism.DataModels.ModifierSpec.FromPointer); // 0x30 Modifier_spec               ( ModelClassListType List`1<ModifierSpec> List`1<ModifierSpec> List<ModifierSpec> Pointer )
            value.Is_byref                                  = GetBool(new IntPtr(p + 0x038)); // 0x38 Is_byref                    ( ModelPrimitiveType bool bool bool Bool )
            value.Display_fullname                          = GetString(new IntPtr(p + 0x040)); // 0x40 Display_fullname            ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
