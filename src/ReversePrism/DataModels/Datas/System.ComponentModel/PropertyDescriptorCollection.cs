using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Empty                                    PropertyDescriptorCollection IL2CPP_TYPE_CLASS
    // 010 CachedFoundProperties                    000186750200 ModelClassType IDictionary IDictionary IDictionary Pointer
    // 018 CachedIgnoreCase                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 020 Properties                               000185B9F520 ModelClassListType PropertyDescriptor[] PropertyDescriptor[] List<PropertyDescriptor> Pointer
    // 028 NamedSort                                000185B81DA0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 030 Comparer                                 000186735840 ModelClassType IComparer IComparer IComparer Pointer
    // 038 PropsOwned                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 039 NeedSort                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 03A ReadOnly                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 040 _internalSyncObject                      <object> IL2CPP_TYPE_OBJECT
    // 048 Count                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class PropertyDescriptorCollection
    {
        public IDictionary?                             CachedFoundProperties                   { get; set; }
        public bool                                     CachedIgnoreCase                        { get; set; }
        public List<PropertyDescriptor>?                Properties                              { get; set; }
        public List<string>?                            NamedSort                               { get; set; }
        public IComparer?                               Comparer                                { get; set; }
        public bool                                     PropsOwned                              { get; set; }
        public bool                                     NeedSort                                { get; set; }
        public bool                                     ReadOnly                                { get; set; }
        public int                                      Count                                   { get; set; }

        public static PropertyDescriptorCollection? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PropertyDescriptorCollection();

            value.CachedFoundProperties                     = GetObject<IDictionary>(new IntPtr(p + 0x010), ReversePrism.DataModels.IDictionary.FromPointer); // 0270D7B16838 0x10 CachedFoundProperties       ( 000186750200 ModelClassType IDictionary IDictionary IDictionary Pointer )
            value.CachedIgnoreCase                          = GetBool(new IntPtr(p + 0x018)); // 0270D7B16858 0x18 CachedIgnoreCase            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Properties                                = GetObjectList<PropertyDescriptor>(new IntPtr(p + 0x020), ReversePrism.DataModels.PropertyDescriptor.FromPointer); // 0270D7B16878 0x20 Properties                  ( 000185B9F520 ModelClassListType PropertyDescriptor[] PropertyDescriptor[] List<PropertyDescriptor> Pointer )
            value.NamedSort                                 = GetStringList(new IntPtr(p + 0x028)); // 0270D7B16898 0x28 NamedSort                   ( 000185B81DA0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.Comparer                                  = GetObject<IComparer>(new IntPtr(p + 0x030), ReversePrism.DataModels.IComparer.FromPointer); // 0270D7B168B8 0x30 Comparer                    ( 000186735840 ModelClassType IComparer IComparer IComparer Pointer )
            value.PropsOwned                                = GetBool(new IntPtr(p + 0x038)); // 0270D7B168D8 0x38 PropsOwned                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.NeedSort                                  = GetBool(new IntPtr(p + 0x039)); // 0270D7B168F8 0x39 NeedSort                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ReadOnly                                  = GetBool(new IntPtr(p + 0x03A)); // 0270D7B16918 0x3A ReadOnly                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Count                                     = GetInt32(new IntPtr(p + 0x048)); // 0270D7B16958 0x48 Count                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
