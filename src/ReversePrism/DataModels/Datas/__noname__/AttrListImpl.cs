using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AttrNames                                ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    // 018 AttrValues                               ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    public partial class AttrListImpl : DataModel
    {
        public List<string>?                            AttrNames                               { get; set; }
        public List<string>?                            AttrValues                              { get; set; }

        public static AttrListImpl? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AttrListImpl() { Pointer= p0 };

            value.AttrNames                                 = GetStringList(new IntPtr(p + 0x010)); // 0x10 AttrNames                   ( ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )
            value.AttrValues                                = GetStringList(new IntPtr(p + 0x018)); // 0x18 AttrValues                  ( ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )

            return value;
        }
    }
}
