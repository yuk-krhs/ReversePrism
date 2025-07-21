using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     ModelEnumType Token Token Token Int32
    // 018 NextStates                               ModelPrimitiveListType int[] int[] List<int> Pointer
    // 020 Attributes                               ModelClassListType XdrAttributeEntry[] XdrAttributeEntry[] List<XdrAttributeEntry> Pointer
    // 028 InitFunc                                 ModelClassType XdrInitFunction XdrInitFunction XdrInitFunction Pointer
    // 030 BeginChildFunc                           ModelClassType XdrBeginChildFunction XdrBeginChildFunction XdrBeginChildFunction Pointer
    // 038 EndChildFunc                             ModelClassType XdrEndChildFunction XdrEndChildFunction XdrEndChildFunction Pointer
    // 040 AllowText                                ModelPrimitiveType bool bool bool Bool
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

            value.Name                                      = (Token)GetInt32(new IntPtr(p + 0x010)); // 0x10 Name                        ( ModelEnumType Token Token Token Int32 )
            value.NextStates                                = GetInt32List(new IntPtr(p + 0x018)); // 0x18 NextStates                  ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.Attributes                                = GetObjectList<XdrAttributeEntry>(new IntPtr(p + 0x020), ReversePrism.DataModels.XdrAttributeEntry.FromPointer); // 0x20 Attributes                  ( ModelClassListType XdrAttributeEntry[] XdrAttributeEntry[] List<XdrAttributeEntry> Pointer )
            value.InitFunc                                  = GetObject<XdrInitFunction>(new IntPtr(p + 0x028), ReversePrism.DataModels.XdrInitFunction.FromPointer); // 0x28 InitFunc                    ( ModelClassType XdrInitFunction XdrInitFunction XdrInitFunction Pointer )
            value.BeginChildFunc                            = GetObject<XdrBeginChildFunction>(new IntPtr(p + 0x030), ReversePrism.DataModels.XdrBeginChildFunction.FromPointer); // 0x30 BeginChildFunc              ( ModelClassType XdrBeginChildFunction XdrBeginChildFunction XdrBeginChildFunction Pointer )
            value.EndChildFunc                              = GetObject<XdrEndChildFunction>(new IntPtr(p + 0x038), ReversePrism.DataModels.XdrEndChildFunction.FromPointer); // 0x38 EndChildFunc                ( ModelClassType XdrEndChildFunction XdrEndChildFunction XdrEndChildFunction Pointer )
            value.AllowText                                 = GetBool(new IntPtr(p + 0x040)); // 0x40 AllowText                   ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
