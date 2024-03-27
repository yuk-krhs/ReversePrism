using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 KeywordNames                             string[] IL2CPP_TYPE_SZARRAY
    // 008 EnumNames                                string[] IL2CPP_TYPE_SZARRAY
    // 010 Keywords                                 000185CA37A8 ModelEnumListType ShaderKeyword[] ShaderKeyword[] List<ShaderKeyword> Pointer
    public partial class MaterialQualityUtilities
    {
        public List<ShaderKeyword>?                     Keywords                                { get; set; }

        public static MaterialQualityUtilities? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MaterialQualityUtilities();

            value.Keywords                                  = GetEnumList<ShaderKeyword>(new IntPtr(p + 0x010)); // 0270055787B8 0x10 Keywords                    ( 000185CA37A8 ModelEnumListType ShaderKeyword[] ShaderKeyword[] List<ShaderKeyword> Pointer )

            return value;
        }
    }
}
