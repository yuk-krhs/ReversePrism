using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Parent                                   ModelClassType Type Type Type Pointer
    // 018 Declaring_type                           ModelClassType Type Type Type Pointer
    // 020 Name                                     ModelPrimitiveType string string string String
    // 028 Get_method                               ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 030 Set_method                               ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 038 Attrs                                    ModelEnumType PropertyAttributes PropertyAttributes PropertyAttributes Int32
    public partial class MonoPropertyInfo : DataModel
    {
        public Type?                                    Parent                                  { get; set; }
        public Type?                                    Declaring_type                          { get; set; }
        public string                                   Name                                    { get; set; }
        public MethodInfo?                              Get_method                              { get; set; }
        public MethodInfo?                              Set_method                              { get; set; }
        public PropertyAttributes                       Attrs                                   { get; set; }

        public static MonoPropertyInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MonoPropertyInfo() { Pointer= p0 };

            value.Parent                                    = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 0x10 Parent                      ( ModelClassType Type Type Type Pointer )
            value.Declaring_type                            = GetObject<Type>(new IntPtr(p + 0x018), ReversePrism.DataModels.Type.FromPointer); // 0x18 Declaring_type              ( ModelClassType Type Type Type Pointer )
            value.Name                                      = GetString(new IntPtr(p + 0x020)); // 0x20 Name                        ( ModelPrimitiveType string string string String )
            value.Get_method                                = GetObject<MethodInfo>(new IntPtr(p + 0x028), ReversePrism.DataModels.MethodInfo.FromPointer); // 0x28 Get_method                  ( ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.Set_method                                = GetObject<MethodInfo>(new IntPtr(p + 0x030), ReversePrism.DataModels.MethodInfo.FromPointer); // 0x30 Set_method                  ( ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.Attrs                                     = (PropertyAttributes)GetInt32(new IntPtr(p + 0x038)); // 0x38 Attrs                       ( ModelEnumType PropertyAttributes PropertyAttributes PropertyAttributes Int32 )

            return value;
        }
    }
}
