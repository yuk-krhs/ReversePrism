using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _xmlTypes                                Hashtable IL2CPP_TYPE_CLASS
    // 008 _xmlElements                             Hashtable IL2CPP_TYPE_CLASS
    // 010 SoapActions                              ModelClassType Hashtable Hashtable Hashtable Pointer
    // 018 SoapActionsMethods                       ModelClassType Hashtable Hashtable Hashtable Pointer
    // 020 TypeInfos                                ModelClassType Hashtable Hashtable Hashtable Pointer
    public partial class SoapServices : DataModel
    {
        public Hashtable?                               SoapActions                             { get; set; }
        public Hashtable?                               SoapActionsMethods                      { get; set; }
        public Hashtable?                               TypeInfos                               { get; set; }

        public static SoapServices? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SoapServices() { Pointer= p0 };

            value.SoapActions                               = GetObject<Hashtable>(new IntPtr(p + 0x010), ReversePrism.DataModels.Hashtable.FromPointer); // 0x10 SoapActions                 ( ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.SoapActionsMethods                        = GetObject<Hashtable>(new IntPtr(p + 0x018), ReversePrism.DataModels.Hashtable.FromPointer); // 0x18 SoapActionsMethods          ( ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.TypeInfos                                 = GetObject<Hashtable>(new IntPtr(p + 0x020), ReversePrism.DataModels.Hashtable.FromPointer); // 0x20 TypeInfos                   ( ModelClassType Hashtable Hashtable Hashtable Pointer )

            return value;
        }
    }
}
