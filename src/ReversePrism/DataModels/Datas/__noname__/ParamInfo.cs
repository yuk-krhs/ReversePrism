using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Ftype                                    ModelEnumType FunctionType FunctionType FunctionType Int32
    // 014 Minargs                                  ModelPrimitiveType int int int Int32
    // 018 Maxargs                                  ModelPrimitiveType int int int Int32
    // 020 ArgTypes                                 ModelEnumListType XPathResultType[] XPathResultType[] List<XPathResultType> Pointer
    public partial class ParamInfo : DataModel
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
            var value   = new ParamInfo() { Pointer= p0 };

            value.Ftype                                     = (FunctionType)GetInt32(new IntPtr(p + 0x010)); // 0x10 Ftype                       ( ModelEnumType FunctionType FunctionType FunctionType Int32 )
            value.Minargs                                   = GetInt32(new IntPtr(p + 0x014)); // 0x14 Minargs                     ( ModelPrimitiveType int int int Int32 )
            value.Maxargs                                   = GetInt32(new IntPtr(p + 0x018)); // 0x18 Maxargs                     ( ModelPrimitiveType int int int Int32 )
            value.ArgTypes                                  = GetEnumList<XPathResultType>(new IntPtr(p + 0x020)); // 0x20 ArgTypes                    ( ModelEnumListType XPathResultType[] XPathResultType[] List<XPathResultType> Pointer )

            return value;
        }
    }
}
