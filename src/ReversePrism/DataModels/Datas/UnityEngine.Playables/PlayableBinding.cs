using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_StreamName                             ModelPrimitiveType string string string String
    // 018 M_SourceObject                           ModelClassType Object Object Object Pointer
    // 020 M_SourceBindingType                      ModelClassType Type Type Type Pointer
    // 028 M_CreateOutputMethod                     ModelClassType CreateOutputMethod CreateOutputMethod CreateOutputMethod Pointer
    // 000 None                                     PlayableBinding[] IL2CPP_TYPE_SZARRAY
    // 008 DefaultDuration                          double IL2CPP_TYPE_R8
    public partial class PlayableBinding : DataModel
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
            var value   = new PlayableBinding() { Pointer= p0 };

            value.M_StreamName                              = GetString(new IntPtr(p + 0x010)); // 0x10 M_StreamName                ( ModelPrimitiveType string string string String )
            value.M_SourceObject                            = GetObject<Object>(new IntPtr(p + 0x018), ReversePrism.DataModels.Object.FromPointer); // 0x18 M_SourceObject              ( ModelClassType Object Object Object Pointer )
            value.M_SourceBindingType                       = GetObject<Type>(new IntPtr(p + 0x020), ReversePrism.DataModels.Type.FromPointer); // 0x20 M_SourceBindingType         ( ModelClassType Type Type Type Pointer )
            value.M_CreateOutputMethod                      = GetObject<CreateOutputMethod>(new IntPtr(p + 0x028), ReversePrism.DataModels.CreateOutputMethod.FromPointer); // 0x28 M_CreateOutputMethod        ( ModelClassType CreateOutputMethod CreateOutputMethod CreateOutputMethod Pointer )

            return value;
        }
    }
}
