using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Parent                                   000186692F60 ModelClassType Type Type Type Pointer
    // 018 Declaring_type                           000186692F60 ModelClassType Type Type Type Pointer
    // 020 Name                                     0001866722E0 ModelPrimitiveType string string string String
    // 028 Get_method                               0001866138F0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 030 Set_method                               0001866138F0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 038 Attrs                                    0001865D04D0 ModelEnumType PropertyAttributes PropertyAttributes PropertyAttributes Int32
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

            value.Parent                                    = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 0245A34D0668 0x10 Parent                      ( 000186692F60 ModelClassType Type Type Type Pointer )
            value.Declaring_type                            = GetObject<Type>(new IntPtr(p + 0x018), ReversePrism.DataModels.Type.FromPointer); // 0245A34D0688 0x18 Declaring_type              ( 000186692F60 ModelClassType Type Type Type Pointer )
            value.Name                                      = GetString(new IntPtr(p + 0x020)); // 0245A34D06A8 0x20 Name                        ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Get_method                                = GetObject<MethodInfo>(new IntPtr(p + 0x028), ReversePrism.DataModels.MethodInfo.FromPointer); // 0245A34D06C8 0x28 Get_method                  ( 0001866138F0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.Set_method                                = GetObject<MethodInfo>(new IntPtr(p + 0x030), ReversePrism.DataModels.MethodInfo.FromPointer); // 0245A34D06E8 0x30 Set_method                  ( 0001866138F0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.Attrs                                     = (PropertyAttributes)GetInt32(new IntPtr(p + 0x038)); // 0245A34D0708 0x38 Attrs                       ( 0001865D04D0 ModelEnumType PropertyAttributes PropertyAttributes PropertyAttributes Int32 )

            return value;
        }
    }
}
