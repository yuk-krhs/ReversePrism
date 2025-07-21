using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SeenBeforeTable                          ModelClassType Hashtable Hashtable Hashtable Pointer
    // 018 ObjectInfoIdCount                        ModelPrimitiveType int int int Int32
    // 020 OiPool                                   ModelClassType SerStack SerStack SerStack Pointer
    public partial class SerObjectInfoInit : DataModel
    {
        public Hashtable?                               SeenBeforeTable                         { get; set; }
        public int                                      ObjectInfoIdCount                       { get; set; }
        public SerStack?                                OiPool                                  { get; set; }

        public static SerObjectInfoInit? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SerObjectInfoInit() { Pointer= p0 };

            value.SeenBeforeTable                           = GetObject<Hashtable>(new IntPtr(p + 0x010), ReversePrism.DataModels.Hashtable.FromPointer); // 0x10 SeenBeforeTable             ( ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.ObjectInfoIdCount                         = GetInt32(new IntPtr(p + 0x018)); // 0x18 ObjectInfoIdCount           ( ModelPrimitiveType int int int Int32 )
            value.OiPool                                    = GetObject<SerStack>(new IntPtr(p + 0x020), ReversePrism.DataModels.SerStack.FromPointer); // 0x20 OiPool                      ( ModelClassType SerStack SerStack SerStack Pointer )

            return value;
        }
    }
}
