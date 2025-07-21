using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Renderer                                 ModelClassType Type Type Type Pointer
    // 018 EventType                                ModelEnumType PostProcessEvent PostProcessEvent PostProcessEvent Int32
    // 020 MenuItem                                 ModelPrimitiveType string string string String
    // 028 AllowInSceneView                         ModelPrimitiveType bool bool bool Bool
    // 029 BuiltinEffect                            ModelPrimitiveType bool bool bool Bool
    public partial class PostProcessAttribute : DataModel
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
            var value   = new PostProcessAttribute() { Pointer= p0 };

            value.Renderer                                  = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 0x10 Renderer                    ( ModelClassType Type Type Type Pointer )
            value.EventType                                 = (PostProcessEvent)GetInt32(new IntPtr(p + 0x018)); // 0x18 EventType                   ( ModelEnumType PostProcessEvent PostProcessEvent PostProcessEvent Int32 )
            value.MenuItem                                  = GetString(new IntPtr(p + 0x020)); // 0x20 MenuItem                    ( ModelPrimitiveType string string string String )
            value.AllowInSceneView                          = GetBool(new IntPtr(p + 0x028)); // 0x28 AllowInSceneView            ( ModelPrimitiveType bool bool bool Bool )
            value.BuiltinEffect                             = GetBool(new IntPtr(p + 0x029)); // 0x29 BuiltinEffect               ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
