using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Events                                   ModelClassListType EventDescriptor[] EventDescriptor[] List<EventDescriptor> Pointer
    // 018 NamedSort                                ModelPrimitiveListType string[] string[] List<string> Pointer
    // 020 Comparer                                 ModelClassType IComparer IComparer IComparer Pointer
    // 028 EventsOwned                              ModelPrimitiveType bool bool bool Bool
    // 029 NeedSort                                 ModelPrimitiveType bool bool bool Bool
    // 02A ReadOnly                                 ModelPrimitiveType bool bool bool Bool
    // 000 Empty                                    EventDescriptorCollection IL2CPP_TYPE_CLASS
    // 02C Count                                    ModelPrimitiveType int int int Int32
    public partial class EventDescriptorCollection : DataModel
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
            var value   = new EventDescriptorCollection() { Pointer= p0 };

            value.Events                                    = GetObjectList<EventDescriptor>(new IntPtr(p + 0x010), ReversePrism.DataModels.EventDescriptor.FromPointer); // 0x10 Events                      ( ModelClassListType EventDescriptor[] EventDescriptor[] List<EventDescriptor> Pointer )
            value.NamedSort                                 = GetStringList(new IntPtr(p + 0x018)); // 0x18 NamedSort                   ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.Comparer                                  = GetObject<IComparer>(new IntPtr(p + 0x020), ReversePrism.DataModels.IComparer.FromPointer); // 0x20 Comparer                    ( ModelClassType IComparer IComparer IComparer Pointer )
            value.EventsOwned                               = GetBool(new IntPtr(p + 0x028)); // 0x28 EventsOwned                 ( ModelPrimitiveType bool bool bool Bool )
            value.NeedSort                                  = GetBool(new IntPtr(p + 0x029)); // 0x29 NeedSort                    ( ModelPrimitiveType bool bool bool Bool )
            value.ReadOnly                                  = GetBool(new IntPtr(p + 0x02A)); // 0x2A ReadOnly                    ( ModelPrimitiveType bool bool bool Bool )
            value.Count                                     = GetInt32(new IntPtr(p + 0x02C)); // 0x2C Count                       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
