using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_surrogates                             ModelClassType ISurrogateSelector ISurrogateSelector ISurrogateSelector Pointer
    // 018 M_context                                ModelEnumType StreamingContext StreamingContext StreamingContext Int32
    // 028 M_binder                                 ModelClassType SerializationBinder SerializationBinder SerializationBinder Pointer
    // 030 M_typeFormat                             ModelEnumType FormatterTypeStyle FormatterTypeStyle FormatterTypeStyle Int32
    // 034 M_assemblyFormat                         ModelEnumType FormatterAssemblyStyle FormatterAssemblyStyle FormatterAssemblyStyle Int32
    // 038 M_securityLevel                          ModelEnumType TypeFilterLevel TypeFilterLevel TypeFilterLevel Int32
    // 040 m_crossAppDomainArray                    <object>[] IL2CPP_TYPE_SZARRAY
    // 000 typeNameCache                            Dictionary`2<Type, TypeInformation> IL2CPP_TYPE_GENERICINST
    public partial class BinaryFormatter : DataModel
    {
        public ISurrogateSelector?                      M_surrogates                            { get; set; }
        public StreamingContext                         M_context                               { get; set; }
        public SerializationBinder?                     M_binder                                { get; set; }
        public FormatterTypeStyle                       M_typeFormat                            { get; set; }
        public FormatterAssemblyStyle                   M_assemblyFormat                        { get; set; }
        public TypeFilterLevel                          M_securityLevel                         { get; set; }

        public static BinaryFormatter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BinaryFormatter() { Pointer= p0 };

            value.M_surrogates                              = GetObject<ISurrogateSelector>(new IntPtr(p + 0x010), ReversePrism.DataModels.ISurrogateSelector.FromPointer); // 0x10 M_surrogates                ( ModelClassType ISurrogateSelector ISurrogateSelector ISurrogateSelector Pointer )
            value.M_context                                 = (StreamingContext)GetInt32(new IntPtr(p + 0x018)); // 0x18 M_context                   ( ModelEnumType StreamingContext StreamingContext StreamingContext Int32 )
            value.M_binder                                  = GetObject<SerializationBinder>(new IntPtr(p + 0x028), ReversePrism.DataModels.SerializationBinder.FromPointer); // 0x28 M_binder                    ( ModelClassType SerializationBinder SerializationBinder SerializationBinder Pointer )
            value.M_typeFormat                              = (FormatterTypeStyle)GetInt32(new IntPtr(p + 0x030)); // 0x30 M_typeFormat                ( ModelEnumType FormatterTypeStyle FormatterTypeStyle FormatterTypeStyle Int32 )
            value.M_assemblyFormat                          = (FormatterAssemblyStyle)GetInt32(new IntPtr(p + 0x034)); // 0x34 M_assemblyFormat            ( ModelEnumType FormatterAssemblyStyle FormatterAssemblyStyle FormatterAssemblyStyle Int32 )
            value.M_securityLevel                           = (TypeFilterLevel)GetInt32(new IntPtr(p + 0x038)); // 0x38 M_securityLevel             ( ModelEnumType TypeFilterLevel TypeFilterLevel TypeFilterLevel Int32 )

            return value;
        }
    }
}
