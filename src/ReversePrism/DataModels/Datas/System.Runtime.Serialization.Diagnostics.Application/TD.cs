using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 resourceManager                          ResourceManager IL2CPP_TYPE_CLASS
    // 008 resourceCulture                          CultureInfo IL2CPP_TYPE_CLASS
    // 010 EventDescriptors                         ModelEnumListType EventDescriptor[] EventDescriptor[] List<EventDescriptor> Pointer
    // 018 syncLock                                 <object> IL2CPP_TYPE_OBJECT
    // 020 EventDescriptorsCreated                  ModelPrimitiveType bool bool bool Bool
    public partial class TD : DataModel
    {
        public List<EventDescriptor>?                   EventDescriptors                        { get; set; }
        public bool                                     EventDescriptorsCreated                 { get; set; }

        public static TD? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TD() { Pointer= p0 };

            value.EventDescriptors                          = GetEnumList<EventDescriptor>(new IntPtr(p + 0x010)); // 0x10 EventDescriptors            ( ModelEnumListType EventDescriptor[] EventDescriptor[] List<EventDescriptor> Pointer )
            value.EventDescriptorsCreated                   = GetBool(new IntPtr(p + 0x020)); // 0x20 EventDescriptorsCreated     ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
