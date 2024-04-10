using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 All                                      000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 058 AllKeys                                  000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    public partial class NameValueCollection : DataModel
    {
        public List<string>?                            All                                     { get; set; }
        public List<string>?                            AllKeys                                 { get; set; }

        public static NameValueCollection? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NameValueCollection() { Pointer= p0 };

            value.All                                       = GetStringList(new IntPtr(p + 0x050)); // 0246679EF698 0x50 All                         ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.AllKeys                                   = GetStringList(new IntPtr(p + 0x058)); // 0246679EF6B8 0x58 AllKeys                     ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
