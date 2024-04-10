using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_default                                UTF7Encoding IL2CPP_TYPE_CLASS
    // 038 Base64Bytes                              000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 040 Base64Values                             000185CA2298 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 048 DirectEncode                             000185B78CA0 ModelPrimitiveListType bool[] bool[] List<bool> Pointer
    // 050 AllowOptionals                           000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class UTF7Encoding : DataModel
    {
        public List<sbyte>?                             Base64Bytes                             { get; set; }
        public List<sbyte>?                             Base64Values                            { get; set; }
        public List<bool>?                              DirectEncode                            { get; set; }
        public bool                                     AllowOptionals                          { get; set; }

        public static UTF7Encoding? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UTF7Encoding() { Pointer= p0 };

            value.Base64Bytes                               = GetSByteList(new IntPtr(p + 0x038)); // 024666BDD588 0x38 Base64Bytes                 ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Base64Values                              = GetSByteList(new IntPtr(p + 0x040)); // 024666BDD5A8 0x40 Base64Values                ( 000185CA2298 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.DirectEncode                              = GetBoolList(new IntPtr(p + 0x048)); // 024666BDD5C8 0x48 DirectEncode                ( 000185B78CA0 ModelPrimitiveListType bool[] bool[] List<bool> Pointer )
            value.AllowOptionals                            = GetBool(new IntPtr(p + 0x050)); // 024666BDD5E8 0x50 AllowOptionals              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
