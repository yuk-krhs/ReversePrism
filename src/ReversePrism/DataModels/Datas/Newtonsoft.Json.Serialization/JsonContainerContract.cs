using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 ItemContract                             000186602210 ModelClassType JsonContract JsonContract JsonContract Pointer
    // 098 FinalItemContract                        000186602210 ModelClassType JsonContract JsonContract JsonContract Pointer
    // 0A0 ItemConverter                            0001866027B0 ModelClassType JsonConverter JsonConverter JsonConverter Pointer
    // 0A8 <ItemIsReference>k__BackingField         Nullable`1<bool> IL2CPP_TYPE_GENERICINST
    // 0AC <ItemReferenceLoopHandling>k__BackingField Nullable`1<ReferenceLoopHandling> IL2CPP_TYPE_GENERICINST
    // 0B4 <ItemTypeNameHandling>k__BackingField    Nullable`1<TypeNameHandling> IL2CPP_TYPE_GENERICINST
    public partial class JsonContainerContract : DataModel
    {
        public JsonContract?                            ItemContract                            { get; set; }
        public JsonContract?                            FinalItemContract                       { get; set; }
        public JsonConverter?                           ItemConverter                           { get; set; }

        public static JsonContainerContract? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JsonContainerContract() { Pointer= p0 };

            value.ItemContract                              = GetObject<JsonContract>(new IntPtr(p + 0x090), ReversePrism.DataModels.JsonContract.FromPointer); // 0245A600BF80 0x90 ItemContract                ( 000186602210 ModelClassType JsonContract JsonContract JsonContract Pointer )
            value.FinalItemContract                         = GetObject<JsonContract>(new IntPtr(p + 0x098), ReversePrism.DataModels.JsonContract.FromPointer); // 0245A600BFA0 0x98 FinalItemContract           ( 000186602210 ModelClassType JsonContract JsonContract JsonContract Pointer )
            value.ItemConverter                             = GetObject<JsonConverter>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.JsonConverter.FromPointer); // 0245A600BFC0 0xA0 ItemConverter               ( 0001866027B0 ModelClassType JsonConverter JsonConverter JsonConverter Pointer )

            return value;
        }
    }
}
