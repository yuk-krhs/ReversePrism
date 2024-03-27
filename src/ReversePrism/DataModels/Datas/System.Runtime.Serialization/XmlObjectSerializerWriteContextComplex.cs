using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0C0 DataContractSurrogate                    00018674A890 ModelClassType IDataContractSurrogate IDataContractSurrogate IDataContractSurrogate Pointer
    // 0C8 Mode                                     00018672EDA0 ModelEnumType SerializationMode SerializationMode SerializationMode Int32
    // 0D0 Binder                                   00018672B3D0 ModelClassType SerializationBinder SerializationBinder SerializationBinder Pointer
    // 0D8 SurrogateSelector                        0001865E4F40 ModelClassType ISurrogateSelector ISurrogateSelector ISurrogateSelector Pointer
    // 0E0 StreamingContext                         0001865B8CC0 ModelEnumType StreamingContext StreamingContext StreamingContext Int32
    // 0F0 SurrogateDataContracts                   0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer
    public partial class XmlObjectSerializerWriteContextComplex
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
            var value   = new XmlObjectSerializerWriteContextComplex();

            value.DataContractSurrogate                     = GetObject<IDataContractSurrogate>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.IDataContractSurrogate.FromPointer); // 027004D92348 0xC0 DataContractSurrogate       ( 00018674A890 ModelClassType IDataContractSurrogate IDataContractSurrogate IDataContractSurrogate Pointer )
            value.Mode                                      = (SerializationMode)GetInt32(new IntPtr(p + 0x0C8)); // 027004D92368 0xC8 Mode                        ( 00018672EDA0 ModelEnumType SerializationMode SerializationMode SerializationMode Int32 )
            value.Binder                                    = GetObject<SerializationBinder>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.SerializationBinder.FromPointer); // 027004D92388 0xD0 Binder                      ( 00018672B3D0 ModelClassType SerializationBinder SerializationBinder SerializationBinder Pointer )
            value.SurrogateSelector                         = GetObject<ISurrogateSelector>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.ISurrogateSelector.FromPointer); // 027004D923A8 0xD8 SurrogateSelector           ( 0001865E4F40 ModelClassType ISurrogateSelector ISurrogateSelector ISurrogateSelector Pointer )
            value.StreamingContext                          = (StreamingContext)GetInt32(new IntPtr(p + 0x0E0)); // 027004D923C8 0xE0 StreamingContext            ( 0001865B8CC0 ModelEnumType StreamingContext StreamingContext StreamingContext Int32 )
            value.SurrogateDataContracts                    = GetObject<Hashtable>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.Hashtable.FromPointer); // 027004D923E8 0xF0 SurrogateDataContracts      ( 0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer )

            return value;
        }
    }
}
