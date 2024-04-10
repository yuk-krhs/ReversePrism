using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Parent                                   0001865735E0 ModelClassType XContainer XContainer XContainer Pointer
    // 018 annotations                              <object> IL2CPP_TYPE_OBJECT
    public partial class XObject : DataModel
    {
        public XContainer?                              Parent                                  { get; set; }

        public static XObject? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XObject() { Pointer= p0 };

            value.Parent                                    = GetObject<XContainer>(new IntPtr(p + 0x010), ReversePrism.DataModels.XContainer.FromPointer); // 0246686DAF58 0x10 Parent                      ( 0001865735E0 ModelClassType XContainer XContainer XContainer Pointer )

            return value;
        }
    }
}
