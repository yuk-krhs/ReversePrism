using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MaxItemsInObjectGraph                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 RootName                                 000186671910 ModelPrimitiveType string string string String
    // 020 <KnownTypes>k__BackingField              IEnumerable`1<Type> IL2CPP_TYPE_GENERICINST
    // 028 IgnoreExtensionDataObject                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 030 DataContractSurrogate                    00018674A640 ModelClassType IDataContractSurrogate IDataContractSurrogate IDataContractSurrogate Pointer
    // 038 EmitTypeInformation                      000186726330 ModelEnumType EmitTypeInformation EmitTypeInformation EmitTypeInformation Int32
    // 040 DateTimeFormat                           000186695190 ModelClassType DateTimeFormat DateTimeFormat DateTimeFormat Pointer
    // 048 SerializeReadOnlyTypes                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 049 UseSimpleDictionaryFormat                000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class DataContractJsonSerializerSettings
    {
        public int                                      MaxItemsInObjectGraph                   { get; set; }
        public string                                   RootName                                { get; set; }
        public bool                                     IgnoreExtensionDataObject               { get; set; }
        public IDataContractSurrogate?                  DataContractSurrogate                   { get; set; }
        public EmitTypeInformation                      EmitTypeInformation                     { get; set; }
        public DateTimeFormat?                          DateTimeFormat                          { get; set; }
        public bool                                     SerializeReadOnlyTypes                  { get; set; }
        public bool                                     UseSimpleDictionaryFormat               { get; set; }

        public static DataContractJsonSerializerSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DataContractJsonSerializerSettings();

            value.MaxItemsInObjectGraph                     = GetInt32(new IntPtr(p + 0x010)); // 027004C31B38 0x10 MaxItemsInObjectGraph       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.RootName                                  = GetString(new IntPtr(p + 0x018)); // 027004C31B58 0x18 RootName                    ( 000186671910 ModelPrimitiveType string string string String )
            value.IgnoreExtensionDataObject                 = GetBool(new IntPtr(p + 0x028)); // 027004C31B98 0x28 IgnoreExtensionDataObject   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.DataContractSurrogate                     = GetObject<IDataContractSurrogate>(new IntPtr(p + 0x030), ReversePrism.DataModels.IDataContractSurrogate.FromPointer); // 027004C31BB8 0x30 DataContractSurrogate       ( 00018674A640 ModelClassType IDataContractSurrogate IDataContractSurrogate IDataContractSurrogate Pointer )
            value.EmitTypeInformation                       = (EmitTypeInformation)GetInt32(new IntPtr(p + 0x038)); // 027004C31BD8 0x38 EmitTypeInformation         ( 000186726330 ModelEnumType EmitTypeInformation EmitTypeInformation EmitTypeInformation Int32 )
            value.DateTimeFormat                            = GetObject<DateTimeFormat>(new IntPtr(p + 0x040), ReversePrism.DataModels.DateTimeFormat.FromPointer); // 027004C31BF8 0x40 DateTimeFormat              ( 000186695190 ModelClassType DateTimeFormat DateTimeFormat DateTimeFormat Pointer )
            value.SerializeReadOnlyTypes                    = GetBool(new IntPtr(p + 0x048)); // 027004C31C18 0x48 SerializeReadOnlyTypes      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.UseSimpleDictionaryFormat                 = GetBool(new IntPtr(p + 0x049)); // 027004C31C38 0x49 UseSimpleDictionaryFormat   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
