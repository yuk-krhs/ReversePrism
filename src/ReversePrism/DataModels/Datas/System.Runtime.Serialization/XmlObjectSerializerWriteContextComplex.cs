using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0C0 DataContractSurrogate                    ModelClassType IDataContractSurrogate IDataContractSurrogate IDataContractSurrogate Pointer
    // 0C8 Mode                                     ModelEnumType SerializationMode SerializationMode SerializationMode Int32
    // 0D0 Binder                                   ModelClassType SerializationBinder SerializationBinder SerializationBinder Pointer
    // 0D8 SurrogateSelector                        ModelClassType ISurrogateSelector ISurrogateSelector ISurrogateSelector Pointer
    // 0E0 StreamingContext                         ModelEnumType StreamingContext StreamingContext StreamingContext Int32
    // 0F0 SurrogateDataContracts                   ModelClassType Hashtable Hashtable Hashtable Pointer
    public partial class XmlObjectSerializerWriteContextComplex : DataModel
    {
        public IDataContractSurrogate?                  DataContractSurrogate                   { get; set; }
        public SerializationMode                        Mode                                    { get; set; }
        public SerializationBinder?                     Binder                                  { get; set; }
        public ISurrogateSelector?                      SurrogateSelector                       { get; set; }
        public StreamingContext                         StreamingContext                        { get; set; }
        public Hashtable?                               SurrogateDataContracts                  { get; set; }

        public static XmlObjectSerializerWriteContextComplex? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlObjectSerializerWriteContextComplex() { Pointer= p0 };

            value.DataContractSurrogate                     = GetObject<IDataContractSurrogate>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.IDataContractSurrogate.FromPointer); // 0xC0 DataContractSurrogate       ( ModelClassType IDataContractSurrogate IDataContractSurrogate IDataContractSurrogate Pointer )
            value.Mode                                      = (SerializationMode)GetInt32(new IntPtr(p + 0x0C8)); // 0xC8 Mode                        ( ModelEnumType SerializationMode SerializationMode SerializationMode Int32 )
            value.Binder                                    = GetObject<SerializationBinder>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.SerializationBinder.FromPointer); // 0xD0 Binder                      ( ModelClassType SerializationBinder SerializationBinder SerializationBinder Pointer )
            value.SurrogateSelector                         = GetObject<ISurrogateSelector>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.ISurrogateSelector.FromPointer); // 0xD8 SurrogateSelector           ( ModelClassType ISurrogateSelector ISurrogateSelector ISurrogateSelector Pointer )
            value.StreamingContext                          = (StreamingContext)GetInt32(new IntPtr(p + 0x0E0)); // 0xE0 StreamingContext            ( ModelEnumType StreamingContext StreamingContext StreamingContext Int32 )
            value.SurrogateDataContracts                    = GetObject<Hashtable>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.Hashtable.FromPointer); // 0xF0 SurrogateDataContracts      ( ModelClassType Hashtable Hashtable Hashtable Pointer )

            return value;
        }
    }
}
