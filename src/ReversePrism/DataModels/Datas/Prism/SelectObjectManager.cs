using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SelectObjectKeyTable                     ModelPrimitiveListType string[] string[] List<string> Pointer
    // 028 SelectObjectValueTable                   ModelPrimitiveListType string[] string[] List<string> Pointer
    public partial class SelectObjectManager : DataModel
    {
        public List<string>?                            SelectObjectKeyTable                    { get; set; }
        public List<string>?                            SelectObjectValueTable                  { get; set; }

        public static SelectObjectManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SelectObjectManager() { Pointer= p0 };

            value.SelectObjectKeyTable                      = GetStringList(new IntPtr(p + 0x020)); // 0x20 SelectObjectKeyTable        ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.SelectObjectValueTable                    = GetStringList(new IntPtr(p + 0x028)); // 0x28 SelectObjectValueTable      ( ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
