using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Ftype                                    0001866DC9E0 ModelEnumType FunctionType FunctionType FunctionType Int32
    // 014 Minargs                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 Maxargs                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 ArgTypes                                 000185CB31F8 ModelEnumListType XPathResultType[] XPathResultType[] List<XPathResultType> Pointer
    public partial class ParamInfo
    {
        public FunctionType                             Ftype                                   { get; set; }
        public int                                      Minargs                                 { get; set; }
        public int                                      Maxargs                                 { get; set; }
        public List<XPathResultType>?                   ArgTypes                                { get; set; }

        public static ParamInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ParamInfo();

            value.Ftype                                     = (FunctionType)GetInt32(new IntPtr(p + 0x010)); // 0270D761B3F0 0x10 Ftype                       ( 0001866DC9E0 ModelEnumType FunctionType FunctionType FunctionType Int32 )
            value.Minargs                                   = GetInt32(new IntPtr(p + 0x014)); // 0270D761B410 0x14 Minargs                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Maxargs                                   = GetInt32(new IntPtr(p + 0x018)); // 0270D761B430 0x18 Maxargs                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ArgTypes                                  = GetEnumList<XPathResultType>(new IntPtr(p + 0x020)); // 0270D761B450 0x20 ArgTypes                    ( 000185CB31F8 ModelEnumListType XPathResultType[] XPathResultType[] List<XPathResultType> Pointer )

            return value;
        }
    }
}
