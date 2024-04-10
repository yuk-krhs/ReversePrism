using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 pool                                     TaskPool`1<WaitForEndOfFramePromise> IL2CPP_TYPE_GENERICINST
    // 010 NextNode                                 000186719860 ModelClassType WaitForEndOfFramePromise WaitForEndOfFramePromise WaitForEndOfFramePromise Pointer
    // 018 CancellationToken                        00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 020 core                                     UniTaskCompletionSourceCore`1<<object>> IL2CPP_TYPE_GENERICINST
    // 010 WaitForEndOfFrameYieldInstruction        000186541450 ModelClassType WaitForEndOfFrame WaitForEndOfFrame WaitForEndOfFrame Pointer
    // 048 IsFirst                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class WaitForEndOfFramePromise : DataModel
    {
        public WaitForEndOfFramePromise?                NextNode                                { get; set; }
        public CancellationToken                        CancellationToken                       { get; set; }
        public WaitForEndOfFrame?                       WaitForEndOfFrameYieldInstruction       { get; set; }
        public bool                                     IsFirst                                 { get; set; }

        public static WaitForEndOfFramePromise? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WaitForEndOfFramePromise() { Pointer= p0 };

            value.NextNode                                  = GetObject<WaitForEndOfFramePromise>(new IntPtr(p + 0x010), ReversePrism.DataModels.WaitForEndOfFramePromise.FromPointer); // 024668C3D198 0x10 NextNode                    ( 000186719860 ModelClassType WaitForEndOfFramePromise WaitForEndOfFramePromise WaitForEndOfFramePromise Pointer )
            value.CancellationToken                         = (CancellationToken)GetInt32(new IntPtr(p + 0x018)); // 024668C3D1B8 0x18 CancellationToken           ( 00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.WaitForEndOfFrameYieldInstruction         = GetObject<WaitForEndOfFrame>(new IntPtr(p + 0x010), ReversePrism.DataModels.WaitForEndOfFrame.FromPointer); // 024668C3D1F8 0x10 WaitForEndOfFrameYieldInstruction ( 000186541450 ModelClassType WaitForEndOfFrame WaitForEndOfFrame WaitForEndOfFrame Pointer )
            value.IsFirst                                   = GetBool(new IntPtr(p + 0x048)); // 024668C3D218 0x48 IsFirst                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
