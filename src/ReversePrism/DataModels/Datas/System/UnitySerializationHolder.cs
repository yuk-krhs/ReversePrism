using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_instantiation                          000185B82C10 ModelClassListType Type[] Type[] List<Type> Pointer
    // 018 M_elementTypes                           000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 020 M_genericParameterPosition               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 M_declaringType                          000186692850 ModelClassType Type Type Type Pointer
    // 030 M_declaringMethod                        000186612B80 ModelClassType MethodBase MethodBase MethodBase Pointer
    // 038 M_data                                   000186671910 ModelPrimitiveType string string string String
    // 040 M_assemblyName                           000186671910 ModelPrimitiveType string string string String
    // 048 M_unityType                              0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class UnitySerializationHolder
    {
        public List<Type>?                              M_instantiation                         { get; set; }
        public List<int>?                               M_elementTypes                          { get; set; }
        public int                                      M_genericParameterPosition              { get; set; }
        public Type?                                    M_declaringType                         { get; set; }
        public MethodBase?                              M_declaringMethod                       { get; set; }
        public string                                   M_data                                  { get; set; }
        public string                                   M_assemblyName                          { get; set; }
        public int                                      M_unityType                             { get; set; }

        public static UnitySerializationHolder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnitySerializationHolder();

            value.M_instantiation                           = GetObjectList<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 0270D6A63480 0x10 M_instantiation             ( 000185B82C10 ModelClassListType Type[] Type[] List<Type> Pointer )
            value.M_elementTypes                            = GetInt32List(new IntPtr(p + 0x018)); // 0270D6A634A0 0x18 M_elementTypes              ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.M_genericParameterPosition                = GetInt32(new IntPtr(p + 0x020)); // 0270D6A634C0 0x20 M_genericParameterPosition  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_declaringType                           = GetObject<Type>(new IntPtr(p + 0x028), ReversePrism.DataModels.Type.FromPointer); // 0270D6A634E0 0x28 M_declaringType             ( 000186692850 ModelClassType Type Type Type Pointer )
            value.M_declaringMethod                         = GetObject<MethodBase>(new IntPtr(p + 0x030), ReversePrism.DataModels.MethodBase.FromPointer); // 0270D6A63500 0x30 M_declaringMethod           ( 000186612B80 ModelClassType MethodBase MethodBase MethodBase Pointer )
            value.M_data                                    = GetString(new IntPtr(p + 0x038)); // 0270D6A63520 0x38 M_data                      ( 000186671910 ModelPrimitiveType string string string String )
            value.M_assemblyName                            = GetString(new IntPtr(p + 0x040)); // 0270D6A63540 0x40 M_assemblyName              ( 000186671910 ModelPrimitiveType string string string String )
            value.M_unityType                               = GetInt32(new IntPtr(p + 0x048)); // 0270D6A63560 0x48 M_unityType                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
