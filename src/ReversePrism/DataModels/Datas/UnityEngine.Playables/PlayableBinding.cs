using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_StreamName                             000186671910 ModelPrimitiveType string string string String
    // 018 M_SourceObject                           000186638250 ModelClassType Object Object Object Pointer
    // 020 M_SourceBindingType                      000186692850 ModelClassType Type Type Type Pointer
    // 028 M_CreateOutputMethod                     000186577320 ModelClassType CreateOutputMethod CreateOutputMethod CreateOutputMethod Pointer
    // 000 None                                     PlayableBinding[] IL2CPP_TYPE_SZARRAY
    // 008 DefaultDuration                          double IL2CPP_TYPE_R8
    public partial class PlayableBinding
    {
        public string                                   M_StreamName                            { get; set; }
        public Object?                                  M_SourceObject                          { get; set; }
        public Type?                                    M_SourceBindingType                     { get; set; }
        public CreateOutputMethod?                      M_CreateOutputMethod                    { get; set; }

        public static PlayableBinding? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PlayableBinding();

            value.M_StreamName                              = GetString(new IntPtr(p + 0x010)); // 0270068D6F50 0x10 M_StreamName                ( 000186671910 ModelPrimitiveType string string string String )
            value.M_SourceObject                            = GetObject<Object>(new IntPtr(p + 0x018), ReversePrism.DataModels.Object.FromPointer); // 0270068D6F70 0x18 M_SourceObject              ( 000186638250 ModelClassType Object Object Object Pointer )
            value.M_SourceBindingType                       = GetObject<Type>(new IntPtr(p + 0x020), ReversePrism.DataModels.Type.FromPointer); // 0270068D6F90 0x20 M_SourceBindingType         ( 000186692850 ModelClassType Type Type Type Pointer )
            value.M_CreateOutputMethod                      = GetObject<CreateOutputMethod>(new IntPtr(p + 0x028), ReversePrism.DataModels.CreateOutputMethod.FromPointer); // 0270068D6FB0 0x28 M_CreateOutputMethod        ( 000186577320 ModelClassType CreateOutputMethod CreateOutputMethod CreateOutputMethod Pointer )

            return value;
        }
    }
}
