using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Reader                                   00018661BDA0 ModelClassType IResourceReader IResourceReader IResourceReader Pointer
    // 018 Table                                    0001865DE820 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 020 CaseInsensitiveTable                     0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer
    public partial class ResourceSet
    {
        public IResourceReader?                         Reader                                  { get; set; }
        public Hashtable?                               Table                                   { get; set; }
        public Hashtable?                               CaseInsensitiveTable                    { get; set; }

        public static ResourceSet? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ResourceSet();

            value.Reader                                    = GetObject<IResourceReader>(new IntPtr(p + 0x010), ReversePrism.DataModels.IResourceReader.FromPointer); // 0270D6CC2438 0x10 Reader                      ( 00018661BDA0 ModelClassType IResourceReader IResourceReader IResourceReader Pointer )
            value.Table                                     = GetObject<Hashtable>(new IntPtr(p + 0x018), ReversePrism.DataModels.Hashtable.FromPointer); // 0270D6CC2458 0x18 Table                       ( 0001865DE820 ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.CaseInsensitiveTable                      = GetObject<Hashtable>(new IntPtr(p + 0x020), ReversePrism.DataModels.Hashtable.FromPointer); // 0270D6CC2478 0x20 CaseInsensitiveTable        ( 0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer )

            return value;
        }
    }
}
