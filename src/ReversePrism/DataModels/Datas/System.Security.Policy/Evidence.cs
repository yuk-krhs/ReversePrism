using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Locked                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 018 HostEvidenceList                         00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer
    // 020 AssemblyEvidenceList                     00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer
    public partial class Evidence : DataModel
    {
        public bool                                     Locked                                  { get; set; }
        public ArrayList?                               HostEvidenceList                        { get; set; }
        public ArrayList?                               AssemblyEvidenceList                    { get; set; }

        public static Evidence? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Evidence() { Pointer= p0 };

            value.Locked                                    = GetBool(new IntPtr(p + 0x010)); // 024666AC3F60 0x10 Locked                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.HostEvidenceList                          = GetObject<ArrayList>(new IntPtr(p + 0x018), ReversePrism.DataModels.ArrayList.FromPointer); // 024666AC3F80 0x18 HostEvidenceList            ( 00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.AssemblyEvidenceList                      = GetObject<ArrayList>(new IntPtr(p + 0x020), ReversePrism.DataModels.ArrayList.FromPointer); // 024666AC3FA0 0x20 AssemblyEvidenceList        ( 00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer )

            return value;
        }
    }
}
