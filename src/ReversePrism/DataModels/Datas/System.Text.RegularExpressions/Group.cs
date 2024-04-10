using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_emptyGroup                             Group IL2CPP_TYPE_CLASS
    // 020 Caps                                     000185B7DAC0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 028 Capcount                                 0001865F2F90 ModelPrimitiveType int int int Int32
    // 030 Capcoll                                  000186543910 ModelClassType CaptureCollection CaptureCollection CaptureCollection Pointer
    // 038 Name                                     000186672F10 ModelPrimitiveType string string string String
    public partial class Group : DataModel
    {
        public List<int>?                               Caps                                    { get; set; }
        public int                                      Capcount                                { get; set; }
        public CaptureCollection?                       Capcoll                                 { get; set; }
        public string                                   Name                                    { get; set; }

        public static Group? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Group() { Pointer= p0 };

            value.Caps                                      = GetInt32List(new IntPtr(p + 0x020)); // 0245A01ED020 0x20 Caps                        ( 000185B7DAC0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.Capcount                                  = GetInt32(new IntPtr(p + 0x028)); // 0245A01ED040 0x28 Capcount                    ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Capcoll                                   = GetObject<CaptureCollection>(new IntPtr(p + 0x030), ReversePrism.DataModels.CaptureCollection.FromPointer); // 0245A01ED060 0x30 Capcoll                     ( 000186543910 ModelClassType CaptureCollection CaptureCollection CaptureCollection Pointer )
            value.Name                                      = GetString(new IntPtr(p + 0x038)); // 0245A01ED080 0x38 Name                        ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
