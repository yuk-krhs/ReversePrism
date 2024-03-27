using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0C0 Properties                               000186759680 ModelClassType JsonPropertyCollection JsonPropertyCollection JsonPropertyCollection Pointer
    // 0C8 <PropertyNameResolver>k__BackingField    Func`2<string, string> IL2CPP_TYPE_GENERICINST
    // 0D0 _callSiteGetters                         ThreadSafeStore`2<string, CallSite`1<Func`3<CallSite, <object>, <object>>>> IL2CPP_TYPE_GENERICINST
    // 0D8 _callSiteSetters                         ThreadSafeStore`2<string, CallSite`1<Func`4<CallSite, <object>, <object>, <object>>>> IL2CPP_TYPE_GENERICINST
    public partial class JsonDynamicContract
    {
        public JsonPropertyCollection?                  Properties                              { get; set; }

        public static JsonDynamicContract? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JsonDynamicContract();

            value.Properties                                = GetObject<JsonPropertyCollection>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.JsonPropertyCollection.FromPointer); // 0270060C65B0 0xC0 Properties                  ( 000186759680 ModelClassType JsonPropertyCollection JsonPropertyCollection JsonPropertyCollection Pointer )

            return value;
        }
    }
}
