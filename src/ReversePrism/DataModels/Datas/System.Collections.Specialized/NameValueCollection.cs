using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 058 All                                      ModelPrimitiveListType string[] string[] List<string> Pointer
    // 060 AllKeys                                  ModelPrimitiveListType string[] string[] List<string> Pointer
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

            value.All                                       = GetStringList(new IntPtr(p + 0x058)); // 0x58 All                         ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.AllKeys                                   = GetStringList(new IntPtr(p + 0x060)); // 0x60 AllKeys                     ( ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
