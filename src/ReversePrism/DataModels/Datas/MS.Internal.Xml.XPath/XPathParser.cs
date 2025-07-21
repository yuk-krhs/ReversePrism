using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Scanner                                  ModelClassType XPathScanner XPathScanner XPathScanner Pointer
    // 018 ParseDepth                               ModelPrimitiveType int int int Int32
    // 000 s_temparray1                             XPathResultType[] IL2CPP_TYPE_SZARRAY
    // 008 s_temparray2                             XPathResultType[] IL2CPP_TYPE_SZARRAY
    // 010 S_temparray3                             ModelEnumListType XPathResultType[] XPathResultType[] List<XPathResultType> Pointer
    // 018 S_temparray4                             ModelEnumListType XPathResultType[] XPathResultType[] List<XPathResultType> Pointer
    // 020 S_temparray5                             ModelEnumListType XPathResultType[] XPathResultType[] List<XPathResultType> Pointer
    // 028 S_temparray6                             ModelEnumListType XPathResultType[] XPathResultType[] List<XPathResultType> Pointer
    // 030 S_temparray7                             ModelEnumListType XPathResultType[] XPathResultType[] List<XPathResultType> Pointer
    // 038 S_temparray8                             ModelEnumListType XPathResultType[] XPathResultType[] List<XPathResultType> Pointer
    // 040 S_temparray9                             ModelEnumListType XPathResultType[] XPathResultType[] List<XPathResultType> Pointer
    // 048 s_functionTable                          Dictionary`2<string, ParamInfo> IL2CPP_TYPE_GENERICINST
    // 050 s_AxesTable                              Dictionary`2<string, AxisType> IL2CPP_TYPE_GENERICINST
    public partial class XPathParser : DataModel
    {
        public XPathScanner?                            Scanner                                 { get; set; }
        public int                                      ParseDepth                              { get; set; }
        public List<XPathResultType>?                   S_temparray3                            { get; set; }
        public List<XPathResultType>?                   S_temparray4                            { get; set; }
        public List<XPathResultType>?                   S_temparray5                            { get; set; }
        public List<XPathResultType>?                   S_temparray6                            { get; set; }
        public List<XPathResultType>?                   S_temparray7                            { get; set; }
        public List<XPathResultType>?                   S_temparray8                            { get; set; }
        public List<XPathResultType>?                   S_temparray9                            { get; set; }

        public static XPathParser? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XPathParser() { Pointer= p0 };

            value.Scanner                                   = GetObject<XPathScanner>(new IntPtr(p + 0x010), ReversePrism.DataModels.XPathScanner.FromPointer); // 0x10 Scanner                     ( ModelClassType XPathScanner XPathScanner XPathScanner Pointer )
            value.ParseDepth                                = GetInt32(new IntPtr(p + 0x018)); // 0x18 ParseDepth                  ( ModelPrimitiveType int int int Int32 )
            value.S_temparray3                              = GetEnumList<XPathResultType>(new IntPtr(p + 0x010)); // 0x10 S_temparray3                ( ModelEnumListType XPathResultType[] XPathResultType[] List<XPathResultType> Pointer )
            value.S_temparray4                              = GetEnumList<XPathResultType>(new IntPtr(p + 0x018)); // 0x18 S_temparray4                ( ModelEnumListType XPathResultType[] XPathResultType[] List<XPathResultType> Pointer )
            value.S_temparray5                              = GetEnumList<XPathResultType>(new IntPtr(p + 0x020)); // 0x20 S_temparray5                ( ModelEnumListType XPathResultType[] XPathResultType[] List<XPathResultType> Pointer )
            value.S_temparray6                              = GetEnumList<XPathResultType>(new IntPtr(p + 0x028)); // 0x28 S_temparray6                ( ModelEnumListType XPathResultType[] XPathResultType[] List<XPathResultType> Pointer )
            value.S_temparray7                              = GetEnumList<XPathResultType>(new IntPtr(p + 0x030)); // 0x30 S_temparray7                ( ModelEnumListType XPathResultType[] XPathResultType[] List<XPathResultType> Pointer )
            value.S_temparray8                              = GetEnumList<XPathResultType>(new IntPtr(p + 0x038)); // 0x38 S_temparray8                ( ModelEnumListType XPathResultType[] XPathResultType[] List<XPathResultType> Pointer )
            value.S_temparray9                              = GetEnumList<XPathResultType>(new IntPtr(p + 0x040)); // 0x40 S_temparray9                ( ModelEnumListType XPathResultType[] XPathResultType[] List<XPathResultType> Pointer )

            return value;
        }
    }
}
