using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Events                                   000185B7C500 ModelClassListType EventDescriptor[] EventDescriptor[] List<EventDescriptor> Pointer
    // 018 NamedSort                                000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 020 Comparer                                 000186735840 ModelClassType IComparer IComparer IComparer Pointer
    // 028 EventsOwned                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 029 NeedSort                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 02A ReadOnly                                 0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 000 Empty                                    EventDescriptorCollection IL2CPP_TYPE_CLASS
    // 02C Count                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class EventDescriptorCollection
    {
        public List<EventDescriptor>?                   Events                                  { get; set; }
        public List<string>?                            NamedSort                               { get; set; }
        public IComparer?                               Comparer                                { get; set; }
        public bool                                     EventsOwned                             { get; set; }
        public bool                                     NeedSort                                { get; set; }
        public bool                                     ReadOnly                                { get; set; }
        public int                                      Count                                   { get; set; }

        public static EventDescriptorCollection? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventDescriptorCollection();

            value.Events                                    = GetObjectList<EventDescriptor>(new IntPtr(p + 0x010), ReversePrism.DataModels.EventDescriptor.FromPointer); // 0270D7B1AC20 0x10 Events                      ( 000185B7C500 ModelClassListType EventDescriptor[] EventDescriptor[] List<EventDescriptor> Pointer )
            value.NamedSort                                 = GetStringList(new IntPtr(p + 0x018)); // 0270D7B1AC40 0x18 NamedSort                   ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.Comparer                                  = GetObject<IComparer>(new IntPtr(p + 0x020), ReversePrism.DataModels.IComparer.FromPointer); // 0270D7B1AC60 0x20 Comparer                    ( 000186735840 ModelClassType IComparer IComparer IComparer Pointer )
            value.EventsOwned                               = GetBool(new IntPtr(p + 0x028)); // 0270D7B1AC80 0x28 EventsOwned                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.NeedSort                                  = GetBool(new IntPtr(p + 0x029)); // 0270D7B1ACA0 0x29 NeedSort                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ReadOnly                                  = GetBool(new IntPtr(p + 0x02A)); // 0270D7B1ACC0 0x2A ReadOnly                    ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.Count                                     = GetInt32(new IntPtr(p + 0x02C)); // 0270D7B1AD00 0x2C Count                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
