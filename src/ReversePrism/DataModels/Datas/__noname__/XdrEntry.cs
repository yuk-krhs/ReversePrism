using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     000186733D80 ModelEnumType Token Token Token Int32
    // 018 NextStates                               000185B7D3F0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 020 Attributes                               000185CC6398 ModelClassListType XdrAttributeEntry[] XdrAttributeEntry[] List<XdrAttributeEntry> Pointer
    // 028 InitFunc                                 000186727E20 ModelClassType XdrInitFunction XdrInitFunction XdrInitFunction Pointer
    // 030 BeginChildFunc                           000186726C40 ModelClassType XdrBeginChildFunction XdrBeginChildFunction XdrBeginChildFunction Pointer
    // 038 EndChildFunc                             0001867275E0 ModelClassType XdrEndChildFunction XdrEndChildFunction XdrEndChildFunction Pointer
    // 040 AllowText                                000186595210 ModelPrimitiveType bool bool bool Bool
    public partial class XdrEntry : DataModel
    {
        public Token                                    Name                                    { get; set; }
        public List<int>?                               NextStates                              { get; set; }
        public List<XdrAttributeEntry>?                 Attributes                              { get; set; }
        public XdrInitFunction?                         InitFunc                                { get; set; }
        public XdrBeginChildFunction?                   BeginChildFunc                          { get; set; }
        public XdrEndChildFunction?                     EndChildFunc                            { get; set; }
        public bool                                     AllowText                               { get; set; }

        public static XdrEntry? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XdrEntry() { Pointer= p0 };

            value.Name                                      = (Token)GetInt32(new IntPtr(p + 0x010)); // 0246675FDB58 0x10 Name                        ( 000186733D80 ModelEnumType Token Token Token Int32 )
            value.NextStates                                = GetInt32List(new IntPtr(p + 0x018)); // 0246675FDB78 0x18 NextStates                  ( 000185B7D3F0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.Attributes                                = GetObjectList<XdrAttributeEntry>(new IntPtr(p + 0x020), ReversePrism.DataModels.XdrAttributeEntry.FromPointer); // 0246675FDB98 0x20 Attributes                  ( 000185CC6398 ModelClassListType XdrAttributeEntry[] XdrAttributeEntry[] List<XdrAttributeEntry> Pointer )
            value.InitFunc                                  = GetObject<XdrInitFunction>(new IntPtr(p + 0x028), ReversePrism.DataModels.XdrInitFunction.FromPointer); // 0246675FDBB8 0x28 InitFunc                    ( 000186727E20 ModelClassType XdrInitFunction XdrInitFunction XdrInitFunction Pointer )
            value.BeginChildFunc                            = GetObject<XdrBeginChildFunction>(new IntPtr(p + 0x030), ReversePrism.DataModels.XdrBeginChildFunction.FromPointer); // 0246675FDBD8 0x30 BeginChildFunc              ( 000186726C40 ModelClassType XdrBeginChildFunction XdrBeginChildFunction XdrBeginChildFunction Pointer )
            value.EndChildFunc                              = GetObject<XdrEndChildFunction>(new IntPtr(p + 0x038), ReversePrism.DataModels.XdrEndChildFunction.FromPointer); // 0246675FDBF8 0x38 EndChildFunc                ( 0001867275E0 ModelClassType XdrEndChildFunction XdrEndChildFunction XdrEndChildFunction Pointer )
            value.AllowText                                 = GetBool(new IntPtr(p + 0x040)); // 0246675FDC18 0x40 AllowText                   ( 000186595210 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
