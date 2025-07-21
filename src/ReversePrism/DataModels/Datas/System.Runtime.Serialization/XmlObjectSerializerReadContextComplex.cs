using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 dataContractTypeCache                    Hashtable IL2CPP_TYPE_CLASS
    // 0C0 PreserveObjectReferences                 ModelPrimitiveType bool bool bool Bool
    // 0C8 DataContractSurrogate                    ModelClassType IDataContractSurrogate IDataContractSurrogate IDataContractSurrogate Pointer
    // 0D0 Mode                                     ModelEnumType SerializationMode SerializationMode SerializationMode Int32
    // 0D8 Binder                                   ModelClassType SerializationBinder SerializationBinder SerializationBinder Pointer
    // 0E0 SurrogateSelector                        ModelClassType ISurrogateSelector ISurrogateSelector ISurrogateSelector Pointer
    // 0E8 AssemblyFormat                           ModelEnumType FormatterAssemblyStyle FormatterAssemblyStyle FormatterAssemblyStyle Int32
    // 0F0 SurrogateDataContracts                   ModelClassType Hashtable Hashtable Hashtable Pointer
    public partial class XmlObjectSerializerReadContextComplex : DataModel
    {
        public bool                                     PreserveObjectReferences                { get; set; }
        public IDataContractSurrogate?                  DataContractSurrogate                   { get; set; }
        public SerializationMode                        Mode                                    { get; set; }
        public SerializationBinder?                     Binder                                  { get; set; }
        public ISurrogateSelector?                      SurrogateSelector                       { get; set; }
        public FormatterAssemblyStyle                   AssemblyFormat                          { get; set; }
        public Hashtable?                               SurrogateDataContracts                  { get; set; }

        public static XmlObjectSerializerReadContextComplex? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlObjectSerializerReadContextComplex() { Pointer= p0 };

            value.PreserveObjectReferences                  = GetBool(new IntPtr(p + 0x0C0)); // 0xC0 PreserveObjectReferences    ( ModelPrimitiveType bool bool bool Bool )
            value.DataContractSurrogate                     = GetObject<IDataContractSurrogate>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.IDataContractSurrogate.FromPointer); // 0xC8 DataContractSurrogate       ( ModelClassType IDataContractSurrogate IDataContractSurrogate IDataContractSurrogate Pointer )
            value.Mode                                      = (SerializationMode)GetInt32(new IntPtr(p + 0x0D0)); // 0xD0 Mode                        ( ModelEnumType SerializationMode SerializationMode SerializationMode Int32 )
            value.Binder                                    = GetObject<SerializationBinder>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.SerializationBinder.FromPointer); // 0xD8 Binder                      ( ModelClassType SerializationBinder SerializationBinder SerializationBinder Pointer )
            value.SurrogateSelector                         = GetObject<ISurrogateSelector>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.ISurrogateSelector.FromPointer); // 0xE0 SurrogateSelector           ( ModelClassType ISurrogateSelector ISurrogateSelector ISurrogateSelector Pointer )
            value.AssemblyFormat                            = (FormatterAssemblyStyle)GetInt32(new IntPtr(p + 0x0E8)); // 0xE8 AssemblyFormat              ( ModelEnumType FormatterAssemblyStyle FormatterAssemblyStyle FormatterAssemblyStyle Int32 )
            value.SurrogateDataContracts                    = GetObject<Hashtable>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.Hashtable.FromPointer); // 0xF0 SurrogateDataContracts      ( ModelClassType Hashtable Hashtable Hashtable Pointer )

            return value;
        }
    }
}
