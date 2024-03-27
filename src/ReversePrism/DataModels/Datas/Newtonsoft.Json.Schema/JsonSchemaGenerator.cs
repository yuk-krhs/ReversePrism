using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UndefinedSchemaIdHandling                000186701F30 ModelEnumType UndefinedSchemaIdHandling UndefinedSchemaIdHandling UndefinedSchemaIdHandling Int32
    // 018 ContractResolver                         00018673D2D0 ModelClassType IContractResolver IContractResolver IContractResolver Pointer
    // 020 Resolver                                 00018675D010 ModelClassType JsonSchemaResolver JsonSchemaResolver JsonSchemaResolver Pointer
    // 028 _stack                                   IList`1<TypeSchema> IL2CPP_TYPE_GENERICINST
    // 030 CurrentSchema                            00018675AD30 ModelClassType JsonSchema JsonSchema JsonSchema Pointer
    public partial class JsonSchemaGenerator
    {
        public UndefinedSchemaIdHandling                UndefinedSchemaIdHandling               { get; set; }
        public IContractResolver?                       ContractResolver                        { get; set; }
        public JsonSchemaResolver?                      Resolver                                { get; set; }
        public JsonSchema?                              CurrentSchema                           { get; set; }

        public static JsonSchemaGenerator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JsonSchemaGenerator();

            value.UndefinedSchemaIdHandling                 = (UndefinedSchemaIdHandling)GetInt32(new IntPtr(p + 0x010)); // 0270D87B0B08 0x10 UndefinedSchemaIdHandling   ( 000186701F30 ModelEnumType UndefinedSchemaIdHandling UndefinedSchemaIdHandling UndefinedSchemaIdHandling Int32 )
            value.ContractResolver                          = GetObject<IContractResolver>(new IntPtr(p + 0x018), ReversePrism.DataModels.IContractResolver.FromPointer); // 0270D87B0B28 0x18 ContractResolver            ( 00018673D2D0 ModelClassType IContractResolver IContractResolver IContractResolver Pointer )
            value.Resolver                                  = GetObject<JsonSchemaResolver>(new IntPtr(p + 0x020), ReversePrism.DataModels.JsonSchemaResolver.FromPointer); // 0270D87B0B48 0x20 Resolver                    ( 00018675D010 ModelClassType JsonSchemaResolver JsonSchemaResolver JsonSchemaResolver Pointer )
            value.CurrentSchema                             = GetObject<JsonSchema>(new IntPtr(p + 0x030), ReversePrism.DataModels.JsonSchema.FromPointer); // 0270D87B0B88 0x30 CurrentSchema               ( 00018675AD30 ModelClassType JsonSchema JsonSchema JsonSchema Pointer )

            return value;
        }
    }
}
