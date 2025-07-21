using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Empty                                    PropertyDescriptorCollection IL2CPP_TYPE_CLASS
    // 010 CachedFoundProperties                    ModelClassType IDictionary IDictionary IDictionary Pointer
    // 018 CachedIgnoreCase                         ModelPrimitiveType bool bool bool Bool
    // 020 Properties                               ModelClassListType PropertyDescriptor[] PropertyDescriptor[] List<PropertyDescriptor> Pointer
    // 028 NamedSort                                ModelPrimitiveListType string[] string[] List<string> Pointer
    // 030 Comparer                                 ModelClassType IComparer IComparer IComparer Pointer
    // 038 PropsOwned                               ModelPrimitiveType bool bool bool Bool
    // 039 NeedSort                                 ModelPrimitiveType bool bool bool Bool
    // 03A ReadOnly                                 ModelPrimitiveType bool bool bool Bool
    // 040 _internalSyncObject                      <object> IL2CPP_TYPE_OBJECT
    // 048 Count                                    ModelPrimitiveType int int int Int32
    public partial class PropertyDescriptorCollection : DataModel
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
            var value   = new PropertyDescriptorCollection() { Pointer= p0 };

            value.CachedFoundProperties                     = GetObject<IDictionary>(new IntPtr(p + 0x010), ReversePrism.DataModels.IDictionary.FromPointer); // 0x10 CachedFoundProperties       ( ModelClassType IDictionary IDictionary IDictionary Pointer )
            value.CachedIgnoreCase                          = GetBool(new IntPtr(p + 0x018)); // 0x18 CachedIgnoreCase            ( ModelPrimitiveType bool bool bool Bool )
            value.Properties                                = GetObjectList<PropertyDescriptor>(new IntPtr(p + 0x020), ReversePrism.DataModels.PropertyDescriptor.FromPointer); // 0x20 Properties                  ( ModelClassListType PropertyDescriptor[] PropertyDescriptor[] List<PropertyDescriptor> Pointer )
            value.NamedSort                                 = GetStringList(new IntPtr(p + 0x028)); // 0x28 NamedSort                   ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.Comparer                                  = GetObject<IComparer>(new IntPtr(p + 0x030), ReversePrism.DataModels.IComparer.FromPointer); // 0x30 Comparer                    ( ModelClassType IComparer IComparer IComparer Pointer )
            value.PropsOwned                                = GetBool(new IntPtr(p + 0x038)); // 0x38 PropsOwned                  ( ModelPrimitiveType bool bool bool Bool )
            value.NeedSort                                  = GetBool(new IntPtr(p + 0x039)); // 0x39 NeedSort                    ( ModelPrimitiveType bool bool bool Bool )
            value.ReadOnly                                  = GetBool(new IntPtr(p + 0x03A)); // 0x3A ReadOnly                    ( ModelPrimitiveType bool bool bool Bool )
            value.Count                                     = GetInt32(new IntPtr(p + 0x048)); // 0x48 Count                       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
