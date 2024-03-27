using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Scanner                                  000186580D50 ModelClassType XPathScanner XPathScanner XPathScanner Pointer
    // 018 ParseDepth                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 s_temparray1                             XPathResultType[] IL2CPP_TYPE_SZARRAY
    // 008 s_temparray2                             XPathResultType[] IL2CPP_TYPE_SZARRAY
    // 010 S_temparray3                             000185CB3408 ModelEnumListType XPathResultType[] XPathResultType[] List<XPathResultType> Pointer
    // 018 S_temparray4                             000185CB3408 ModelEnumListType XPathResultType[] XPathResultType[] List<XPathResultType> Pointer
    // 020 S_temparray5                             000185CB3408 ModelEnumListType XPathResultType[] XPathResultType[] List<XPathResultType> Pointer
    // 028 S_temparray6                             000185CB3408 ModelEnumListType XPathResultType[] XPathResultType[] List<XPathResultType> Pointer
    // 030 S_temparray7                             000185CB3408 ModelEnumListType XPathResultType[] XPathResultType[] List<XPathResultType> Pointer
    // 038 S_temparray8                             000185CB3408 ModelEnumListType XPathResultType[] XPathResultType[] List<XPathResultType> Pointer
    // 040 S_temparray9                             000185CB3408 ModelEnumListType XPathResultType[] XPathResultType[] List<XPathResultType> Pointer
    // 048 s_functionTable                          Dictionary`2<string, ParamInfo> IL2CPP_TYPE_GENERICINST
    // 050 s_AxesTable                              Dictionary`2<string, AxisType> IL2CPP_TYPE_GENERICINST
    public partial class XPathParser
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
            var value   = new XPathParser();

            value.Scanner                                   = GetObject<XPathScanner>(new IntPtr(p + 0x010), ReversePrism.DataModels.XPathScanner.FromPointer); // 0270D761B710 0x10 Scanner                     ( 000186580D50 ModelClassType XPathScanner XPathScanner XPathScanner Pointer )
            value.ParseDepth                                = GetInt32(new IntPtr(p + 0x018)); // 0270D761B730 0x18 ParseDepth                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.S_temparray3                              = GetEnumList<XPathResultType>(new IntPtr(p + 0x010)); // 0270D761B790 0x10 S_temparray3                ( 000185CB3408 ModelEnumListType XPathResultType[] XPathResultType[] List<XPathResultType> Pointer )
            value.S_temparray4                              = GetEnumList<XPathResultType>(new IntPtr(p + 0x018)); // 0270D761B7B0 0x18 S_temparray4                ( 000185CB3408 ModelEnumListType XPathResultType[] XPathResultType[] List<XPathResultType> Pointer )
            value.S_temparray5                              = GetEnumList<XPathResultType>(new IntPtr(p + 0x020)); // 0270D761B7D0 0x20 S_temparray5                ( 000185CB3408 ModelEnumListType XPathResultType[] XPathResultType[] List<XPathResultType> Pointer )
            value.S_temparray6                              = GetEnumList<XPathResultType>(new IntPtr(p + 0x028)); // 0270D761B7F0 0x28 S_temparray6                ( 000185CB3408 ModelEnumListType XPathResultType[] XPathResultType[] List<XPathResultType> Pointer )
            value.S_temparray7                              = GetEnumList<XPathResultType>(new IntPtr(p + 0x030)); // 0270D761B810 0x30 S_temparray7                ( 000185CB3408 ModelEnumListType XPathResultType[] XPathResultType[] List<XPathResultType> Pointer )
            value.S_temparray8                              = GetEnumList<XPathResultType>(new IntPtr(p + 0x038)); // 0270D761B830 0x38 S_temparray8                ( 000185CB3408 ModelEnumListType XPathResultType[] XPathResultType[] List<XPathResultType> Pointer )
            value.S_temparray9                              = GetEnumList<XPathResultType>(new IntPtr(p + 0x040)); // 0270D761B850 0x40 S_temparray9                ( 000185CB3408 ModelEnumListType XPathResultType[] XPathResultType[] List<XPathResultType> Pointer )

            return value;
        }
    }
}
