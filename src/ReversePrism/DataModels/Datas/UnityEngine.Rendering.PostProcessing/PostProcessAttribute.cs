using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Renderer                                 000186693B90 ModelClassType Type Type Type Pointer
    // 018 EventType                                00018676B860 ModelEnumType PostProcessEvent PostProcessEvent PostProcessEvent Int32
    // 020 MenuItem                                 0001866736C0 ModelPrimitiveType string string string String
    // 028 AllowInSceneView                         000186596AF0 ModelPrimitiveType bool bool bool Bool
    // 029 BuiltinEffect                            000186596860 ModelPrimitiveType bool bool bool Bool
    public partial class PostProcessAttribute
    {
        public Type?                                    Renderer                                { get; set; }
        public PostProcessEvent                         EventType                               { get; set; }
        public string                                   MenuItem                                { get; set; }
        public bool                                     AllowInSceneView                        { get; set; }
        public bool                                     BuiltinEffect                           { get; set; }

        public static PostProcessAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PostProcessAttribute();

            value.Renderer                                  = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 027006134468 0x10 Renderer                    ( 000186693B90 ModelClassType Type Type Type Pointer )
            value.EventType                                 = (PostProcessEvent)GetInt32(new IntPtr(p + 0x018)); // 027006134488 0x18 EventType                   ( 00018676B860 ModelEnumType PostProcessEvent PostProcessEvent PostProcessEvent Int32 )
            value.MenuItem                                  = GetString(new IntPtr(p + 0x020)); // 0270061344A8 0x20 MenuItem                    ( 0001866736C0 ModelPrimitiveType string string string String )
            value.AllowInSceneView                          = GetBool(new IntPtr(p + 0x028)); // 0270061344C8 0x28 AllowInSceneView            ( 000186596AF0 ModelPrimitiveType bool bool bool Bool )
            value.BuiltinEffect                             = GetBool(new IntPtr(p + 0x029)); // 0270061344E8 0x29 BuiltinEffect               ( 000186596860 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
