using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Ks                                       000185CADA78 ModelClassListType TypedObject[] TypedObject[] List<TypedObject> Pointer
    // 018 Dim                                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C Hashcode                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 Posline                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 024 Poscol                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class KeySequence : DataModel
    {
        public List<TypedObject>?                       Ks                                      { get; set; }
        public int                                      Dim                                     { get; set; }
        public int                                      Hashcode                                { get; set; }
        public int                                      Posline                                 { get; set; }
        public int                                      Poscol                                  { get; set; }

        public static KeySequence? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new KeySequence() { Pointer= p0 };

            value.Ks                                        = GetObjectList<TypedObject>(new IntPtr(p + 0x010), ReversePrism.DataModels.TypedObject.FromPointer); // 02466755A508 0x10 Ks                          ( 000185CADA78 ModelClassListType TypedObject[] TypedObject[] List<TypedObject> Pointer )
            value.Dim                                       = GetInt32(new IntPtr(p + 0x018)); // 02466755A528 0x18 Dim                         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Hashcode                                  = GetInt32(new IntPtr(p + 0x01C)); // 02466755A548 0x1C Hashcode                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Posline                                   = GetInt32(new IntPtr(p + 0x020)); // 02466755A568 0x20 Posline                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Poscol                                    = GetInt32(new IntPtr(p + 0x024)); // 02466755A588 0x24 Poscol                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
