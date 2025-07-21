using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MaxItemsInObjectGraph                    ModelPrimitiveType int int int Int32
    // 018 RootName                                 ModelPrimitiveType string string string String
    // 020 <KnownTypes>k__BackingField              IEnumerable`1<Type> IL2CPP_TYPE_GENERICINST
    // 028 IgnoreExtensionDataObject                ModelPrimitiveType bool bool bool Bool
    // 030 DataContractSurrogate                    ModelClassType IDataContractSurrogate IDataContractSurrogate IDataContractSurrogate Pointer
    // 038 EmitTypeInformation                      ModelEnumType EmitTypeInformation EmitTypeInformation EmitTypeInformation Int32
    // 040 DateTimeFormat                           ModelClassType DateTimeFormat DateTimeFormat DateTimeFormat Pointer
    // 048 SerializeReadOnlyTypes                   ModelPrimitiveType bool bool bool Bool
    // 049 UseSimpleDictionaryFormat                ModelPrimitiveType bool bool bool Bool
    public partial class DataContractJsonSerializerSettings : DataModel
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
            var value   = new DataContractJsonSerializerSettings() { Pointer= p0 };

            value.MaxItemsInObjectGraph                     = GetInt32(new IntPtr(p + 0x010)); // 0x10 MaxItemsInObjectGraph       ( ModelPrimitiveType int int int Int32 )
            value.RootName                                  = GetString(new IntPtr(p + 0x018)); // 0x18 RootName                    ( ModelPrimitiveType string string string String )
            value.IgnoreExtensionDataObject                 = GetBool(new IntPtr(p + 0x028)); // 0x28 IgnoreExtensionDataObject   ( ModelPrimitiveType bool bool bool Bool )
            value.DataContractSurrogate                     = GetObject<IDataContractSurrogate>(new IntPtr(p + 0x030), ReversePrism.DataModels.IDataContractSurrogate.FromPointer); // 0x30 DataContractSurrogate       ( ModelClassType IDataContractSurrogate IDataContractSurrogate IDataContractSurrogate Pointer )
            value.EmitTypeInformation                       = (EmitTypeInformation)GetInt32(new IntPtr(p + 0x038)); // 0x38 EmitTypeInformation         ( ModelEnumType EmitTypeInformation EmitTypeInformation EmitTypeInformation Int32 )
            value.DateTimeFormat                            = GetObject<DateTimeFormat>(new IntPtr(p + 0x040), ReversePrism.DataModels.DateTimeFormat.FromPointer); // 0x40 DateTimeFormat              ( ModelClassType DateTimeFormat DateTimeFormat DateTimeFormat Pointer )
            value.SerializeReadOnlyTypes                    = GetBool(new IntPtr(p + 0x048)); // 0x48 SerializeReadOnlyTypes      ( ModelPrimitiveType bool bool bool Bool )
            value.UseSimpleDictionaryFormat                 = GetBool(new IntPtr(p + 0x049)); // 0x49 UseSimpleDictionaryFormat   ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
