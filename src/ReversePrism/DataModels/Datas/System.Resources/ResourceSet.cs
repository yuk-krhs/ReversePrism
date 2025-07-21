using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Reader                                   ModelClassType IResourceReader IResourceReader IResourceReader Pointer
    // 018 Table                                    ModelClassType Hashtable Hashtable Hashtable Pointer
    // 020 CaseInsensitiveTable                     ModelClassType Hashtable Hashtable Hashtable Pointer
    public partial class ResourceSet : DataModel
    {
        public IResourceReader?                         Reader                                  { get; set; }
        public Hashtable?                               Table                                   { get; set; }
        public Hashtable?                               CaseInsensitiveTable                    { get; set; }

        public static ResourceSet? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ResourceSet() { Pointer= p0 };

            value.Reader                                    = GetObject<IResourceReader>(new IntPtr(p + 0x010), ReversePrism.DataModels.IResourceReader.FromPointer); // 0x10 Reader                      ( ModelClassType IResourceReader IResourceReader IResourceReader Pointer )
            value.Table                                     = GetObject<Hashtable>(new IntPtr(p + 0x018), ReversePrism.DataModels.Hashtable.FromPointer); // 0x18 Table                       ( ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.CaseInsensitiveTable                      = GetObject<Hashtable>(new IntPtr(p + 0x020), ReversePrism.DataModels.Hashtable.FromPointer); // 0x20 CaseInsensitiveTable        ( ModelClassType Hashtable Hashtable Hashtable Pointer )

            return value;
        }
    }
}
