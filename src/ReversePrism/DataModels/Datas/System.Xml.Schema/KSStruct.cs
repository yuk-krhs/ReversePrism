using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Depth                                    ModelPrimitiveType int int int Int32
    // 018 Ks                                       ModelClassType KeySequence KeySequence KeySequence Pointer
    // 020 Fields                                   ModelClassListType LocatedActiveAxis[] LocatedActiveAxis[] List<LocatedActiveAxis> Pointer
    public partial class KSStruct : DataModel
    {
        public int                                      Depth                                   { get; set; }
        public KeySequence?                             Ks                                      { get; set; }
        public List<LocatedActiveAxis>?                 Fields                                  { get; set; }

        public static KSStruct? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new KSStruct() { Pointer= p0 };

            value.Depth                                     = GetInt32(new IntPtr(p + 0x010)); // 0x10 Depth                       ( ModelPrimitiveType int int int Int32 )
            value.Ks                                        = GetObject<KeySequence>(new IntPtr(p + 0x018), ReversePrism.DataModels.KeySequence.FromPointer); // 0x18 Ks                          ( ModelClassType KeySequence KeySequence KeySequence Pointer )
            value.Fields                                    = GetObjectList<LocatedActiveAxis>(new IntPtr(p + 0x020), ReversePrism.DataModels.LocatedActiveAxis.FromPointer); // 0x20 Fields                      ( ModelClassListType LocatedActiveAxis[] LocatedActiveAxis[] List<LocatedActiveAxis> Pointer )

            return value;
        }
    }
}
